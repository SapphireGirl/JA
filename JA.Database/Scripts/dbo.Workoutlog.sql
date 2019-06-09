CREATE TABLE [dbo].[Workoutlog]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [politicalAffilliation] NCHAR(10) NULL, 
    [Admin] CHAR(10) NULL
)
