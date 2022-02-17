-- 17. The titles and taglines of movies that are in the "Family" genre and Samuel L. Jackson has acted in (4 rows)


	SELECT title, tagline
	FROM genre g
	JOIN movie_genre mg ON g.genre_id = mg.genre_id
	JOIN movie m ON mg.movie_id = m.movie_id
	JOIN movie_actor ma ON m.movie_id = ma.movie_id
	JOIN person p ON ma.actor_id = p.person_id
	WHERE g.genre_name = 'Family' AND person_name = 'Samuel L. Jackson'
