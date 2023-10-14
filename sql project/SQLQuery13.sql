SELECT *
FROM Course1
WHERE Course1.ID  not in(SELECT Course1.ID
                   FROM Course1
                   WHERE Lesson=N'Grammer')
