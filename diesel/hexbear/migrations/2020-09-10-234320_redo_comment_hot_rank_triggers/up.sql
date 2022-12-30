create index if not exists idx_comment_published on public.comment (published desc);

create or replace function hexbear.refresh_comment_hot_ranks()
    RETURNS trigger
    LANGUAGE 'plpgsql'
AS $BODY$
begin

update hexbear.comment_stat as cs
  set
      hot_rank = hot_rank(score::numeric, p.published),
      hot_rank_active = hot_rank(score::numeric, c.published)
  from public.comment c
  join public.post p on c.post_id = p.id
  where cs.comment_id = c.id and c.published > now() - '1 week'::interval;

  return null;
end $BODY$;

-- Update all comment ranks every 10th comment
 create trigger refresh_comment_hot_ranks
    after insert
    on hexbear.comment_stat
    for each row
	  when (NEW.comment_id % 10 = 0)
    execute procedure hexbear.refresh_comment_hot_ranks();

create or replace function hexbear.refresh_post_hot_ranks()
    RETURNS trigger
    LANGUAGE 'plpgsql'
AS $BODY$
begin

update hexbear.post_stat ps
    set
      hot_rank = hot_rank(score::numeric, p.published),
      hot_rank_active = hot_rank(score::numeric, 
        p.published + '24:00:00'::interval * (1::double precision - exp('-0.000012146493725346809'::numeric::double precision * 
        date_part('epoch'::text, GREATEST(newest_activity_time, p.published) - p.published
      ))))
	from post p
    where post_id = p.id and p.published > now() - '1 week'::interval;

  return null;
end $BODY$;

create trigger refresh_post_hot_ranks
  after insert
  on hexbear.post_stat
  for each row
  execute procedure hexbear.refresh_post_hot_ranks();
  
-- Remove hot ranks from post insert as theyre now isolated and "background" to stat tables
create or replace function hexbear.refresh_post()
  returns trigger
  language 'plpgsql'
as $BODY$
begin
IF (TG_OP = 'DELETE') THEN
    -- Update community number of posts
    update hexbear.community_stat set number_of_posts = number_of_posts - 1 where community_id = OLD.community_id;
    update hexbear.user_stat
    set
      number_of_posts = number_of_posts - 1
    where user_id = OLD.creator_id;

  ELSIF (TG_OP = 'UPDATE') THEN
  -- only hot ranks actually depend on a post update
    update hexbear.post_stat
    set
      hot_rank = hot_rank(coalesce(score, 1::bigint)::numeric, NEW.published),
      hot_rank_active = hot_rank(coalesce(score, 1::bigint)::numeric, 
        NEW.published + '24:00:00'::interval * (1::double precision - exp('-0.000012146493725346809'::numeric::double precision * 
        date_part('epoch'::text, GREATEST(newest_activity_time, NEW.published) - NEW.published
      ))))
    where post_id = NEW.id;

  ELSIF (TG_OP = 'INSERT') THEN

    insert into hexbear.post_stat (post_id, hot_rank, hot_rank_active, newest_activity_time)
    values (
      NEW.id,
      hot_rank(0::numeric, NEW.published),
      hot_rank(0::numeric, 
        NEW.published + '24:00:00'::interval * (1::double precision - exp('-0.000012146493725346809'::numeric::double precision * 
        date_part('epoch'::text, NEW.published - NEW.published)
      ))),
      NEW.published
    );
	
    -- Update that users number of posts
    update hexbear.user_stat
    set
      number_of_posts = number_of_posts + 1
    where user_id = NEW.creator_id;
  
    -- Update community number of posts
    update hexbear.community_stat set number_of_posts = number_of_posts + 1 where community_id = NEW.community_id;
  END IF;

  return null;
end $BODY$;
