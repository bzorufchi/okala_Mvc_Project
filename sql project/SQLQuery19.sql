SELECT Student.Name,Student.FamilyName,Course1.MovieNameClasses,
Course1.Tuition,[Register].Count,Course1.Tuition*[Register].Count AS Total
FROM Student INNER JOIN [Register] ON Student.ID=[Register].StudentID
INNER JOIN Course1 ON CourseID=[Register].CourseID
