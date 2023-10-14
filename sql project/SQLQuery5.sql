SELECT Course1.EducationalPackage,[Register].Count FROM
Course1
LEFT JOIN [Register] ON
Course1.ID=[Register].CourseID