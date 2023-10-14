SELECT Course1.MovieNameClasses,sum([Register].count) AS Total FROM
Course1 INNER JOIN [Register] ON Course1.ID=[Register].CourseID
GROUP BY Course1.MovieNameClasses