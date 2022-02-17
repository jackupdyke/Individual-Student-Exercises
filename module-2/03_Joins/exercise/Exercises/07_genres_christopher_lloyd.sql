-- 7. The genres of movies that Christopher Lloyd has appeared in (8 rows)
-- Hint: DISTINCT will prevent duplicate values in your query results.

	SELECT DISTINCT genre_name
	FROM person p
	JOIN movie_actor ma ON p.person_id = ma.actor_id
	JOIN movie m ON ma.movie_id = m.movie_id
	JOIN movie_genre mg ON m.movie_id = mg.movie_id
	JOIN genre g ON mg.genre_id = g.genre_id
	WHERE p.person_name = 'Christopher Lloyd'
