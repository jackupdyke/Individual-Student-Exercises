-- 13. The directors of the movies in the "Harry Potter Collection" (4 rows)

	SELECT DISTINCT person_name
	FROM collection c
	JOIN movie m ON c.collection_id = m.collection_id
	JOIN person p ON m.director_id = p.person_id
	WHERE collection_name = 'Harry Potter Collection'
