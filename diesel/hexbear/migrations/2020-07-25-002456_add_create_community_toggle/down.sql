
drop view site_view;
alter table site drop column enable_create_communities;

create view site_view as 
select *,
(select name from user_ u where s.creator_id = u.id) as creator_name,
(select avatar from user_ u where s.creator_id = u.id) as creator_avatar,
(select count(*) from user_) as number_of_users,
(select count(*) from post) as number_of_posts,
(select count(*) from comment) as number_of_comments,
(select count(*) from community) as number_of_communities
from site s;

