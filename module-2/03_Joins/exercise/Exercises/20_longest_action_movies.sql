-- 20. The titles, lengths, and release dates of the 5 longest movies in the "Action" genre. Order the movies by length (highest first), then by release date (latest first).
-- (5 rows, expected lengths around 180 - 200)

	SELECT TOP 5 m.length_minutes, title, m.release_date
	FROM genre g
	JOIN movie_genre mg ON g.genre_id = mg.genre_id
	JOIN movie m ON mg.movie_id = m.movie_id
	WHERE g.genre_name = 'Action'
	ORDER BY m.length_minutes DESC, m.release_date DESC
