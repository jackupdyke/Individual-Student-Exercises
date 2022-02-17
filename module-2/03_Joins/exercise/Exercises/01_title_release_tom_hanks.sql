-- 1. The titles and release dates of movies that Tom Hanks has appeared in (47 rows)
  SELECT m.title, m.release_date
  FROM person p
  JOIN movie_actor ma ON ma.actor_id = p.person_id
  JOIN movie m ON m.movie_id = ma.movie_id
  WHERE p.person_name = 'Tom Hanks'


