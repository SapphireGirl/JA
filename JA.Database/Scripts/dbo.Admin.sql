
CREATE TABLE [dbo].[Admin]
(
	[Id] INT NOT NULL PRIMARY KEY, 

    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [AdminType] CHAR(10) NULL
)
