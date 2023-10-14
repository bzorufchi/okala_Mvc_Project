SELECT Student.Name,AVG([Register].count) AS Total FROM
Student INNER JOIN [Register] ON Student.ID=[Register].StudentID
GROUP BY Student.Name