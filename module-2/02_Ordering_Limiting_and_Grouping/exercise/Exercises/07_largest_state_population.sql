-- 7. The population of the state with the highest population. Name the column 'largest_state_population'.
-- Expected answer is around 39,500,000
-- (1 row)

SELECT TOP 1  SUM(population) AS largest_state_population
FROM state
GROUP BY state_name
ORDER BY largest_state_population DESC
