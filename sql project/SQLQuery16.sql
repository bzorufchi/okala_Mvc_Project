--Create Procedure StudentSearch
--@Name nvarchar(20),
--@FamilyName nvarchar(30)
--As
--Begin
--Select * From Student
--Where Name=@Name AND FamilyName=@FamilyName
--End
EXEC StudentSearch
@Name=N'ستاره',@FamilyName=N'صادقی'