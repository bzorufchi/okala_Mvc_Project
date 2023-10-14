SELECT Course1.Books,sum([Register].count) AS Total FROM
Course1 INNER JOIN [Register] ON Course1.ID=[Register].CourseID
GROUP BY Course1.Books
having sum([Register].count)>10
