SELECT Course1.ID,Course1.Books,[Register].Count
FROM Course1 INNER JOIN [Register] ON 
Course1.ID=[Register].CourseID