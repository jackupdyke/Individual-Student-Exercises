-- 18. The average length of movies in the "Science Fiction" genre. Name the column 'average_length'.
-- (1 row, expected result around 110-120)

	SELECT AVG(length_minutes) AS average_length
	FROM genre g
	JOIN movie_genre mg ON g.genre_id = mg.genre_id
	JOIN movie m ON mg.movie_id = m.movie_id
	WHERE g.genre_name = 'Science Fiction'
