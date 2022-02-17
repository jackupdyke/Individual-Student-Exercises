-- 16. The names and birthdays of actors born in the 1950s who acted in movies that were released in 1985 (20 rows)

	SELECT DISTINCT person_name, birthday
	FROM person p
	JOIN movie_actor ma ON p.person_id = ma.actor_id
	JOIN movie m ON ma.movie_id = m.movie_id
	WHERE p.birthday >= '1/1/1950' AND p.birthday < '1/1/1960' AND m.release_date >= '1/1/1985' AND m.release_date <= '12/31/1985'
