-- This file should undo anything in `up.sql`
drop view hexbear.user_view;
drop view user_view;

alter table user_
drop column has_2fa;

create view user_view as
select 
  u.id,
  u.actor_id,
  u.name,
  u.preferred_username,
  u.avatar,
  u.banner,
  u.email,
  u.matrix_user_id,
  u.bio,
  u.local,
  u.admin,
  u.sitemod,
  u.banned,
  u.show_avatars,
  u.send_notifications_to_email,
  u.published,
  coalesce(pd.posts, 0) as number_of_posts,
  coalesce(pd.score, 0) as post_score,
  coalesce(cd.comments, 0) as number_of_comments,
  coalesce(cd.score, 0) as comment_score
from user_ u
left join (
    select
        p.creator_id as creator_id,
        count(distinct p.id) as posts,
        sum(pl.score) as score
    from post p
    join post_like pl on p.id = pl.post_id
    group by p.creator_id
) pd on u.id = pd.creator_id
left join (
    select
        c.creator_id,
        count(distinct c.id) as comments,
        sum(cl.score) as score
    from comment c
    join comment_like cl on c.id = cl.comment_id
    group by c.creator_id
) cd on u.id = cd.creator_id;

CREATE OR REPLACE VIEW hexbear.user_view
 AS
 SELECT u.id,
    u.actor_id,
    u.name,
    u.preferred_username,
    u.avatar,
    u.banner,
    u.email,
    u.matrix_user_id,
    u.bio,
    u.local,
    u.admin,
    u.sitemod,
    EXISTS(select 1 from community_moderator cm where cm.user_id = u.id)::boolean AS moderator,
    u.banned,
    u.show_avatars,
    u.send_notifications_to_email,
    u.published,
    COALESCE(s.number_of_posts, 0)::bigint AS number_of_posts,
    COALESCE(s.post_score, 0)::bigint AS post_score,
    COALESCE(s.number_of_comments, 0)::bigint AS number_of_comments,
    COALESCE(s.comment_score, 0)::bigint AS comment_score
   FROM user_ u
     LEFT JOIN hexbear.user_stat s ON u.id = s.user_id;