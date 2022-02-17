-- 15. The title of the movie and the name of director for movies where the director was also an actor in the same movie (73 rows)

	SELECT title, person_name
	FROM person p
	JOIN movie_actor ma ON ma.actor_id = p.person_id
	JOIN movie m ON ma.movie_id = m.movie_id
	WHERE director_id = actor_id
