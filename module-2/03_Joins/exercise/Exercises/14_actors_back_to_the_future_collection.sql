-- 14. The names of actors who've appeared in the movies in the "Back to the Future Collection" (28 rows)

	SELECT DISTINCT person_name
	FROM collection c
	JOIN movie m ON c.collection_id = m.collection_id
	JOIN movie_actor ma ON m.movie_id = ma.movie_id
	JOIN person p ON ma.actor_id = p.person_id
	WHERE c.collection_name = 'Back to the Future Collection'
