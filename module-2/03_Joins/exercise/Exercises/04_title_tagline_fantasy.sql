-- 4. The titles and taglines of all the movies that are in the Fantasy genre. Order the results by title (A-Z) (81 rows)

	SELECT title, tagline
	FROM genre g
	JOIN movie_genre mg ON g.genre_id = mg.genre_id
	JOIN movie m ON mg.movie_id = m.movie_id
	WHERE g.genre_name = 'Fantasy'
	ORDER BY title
