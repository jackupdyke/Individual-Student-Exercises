-- 8. The genres of movies that Robert De Niro has appeared in that were released in 2010 or later (6 rows)

	SELECT DISTINCT genre_name
	FROM person p
	JOIN movie_actor ma ON p.person_id = ma.actor_id
	JOIN movie m ON ma.movie_id = m.movie_id
	JOIN movie_genre mg ON m.movie_id = mg.movie_id
	JOIN genre g ON mg.genre_id = g.genre_id
	WHERE p.person_name = 'Robert De Niro' AND m.release_date > = '1/1/2010'
	
