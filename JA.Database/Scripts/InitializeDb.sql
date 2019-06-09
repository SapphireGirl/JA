CREATE PROCEDURE [dbo].[InitializeDb]
	@param1 int = 0,
	@param2 int
AS
	SELECT @param1, @param2


	--------------------------
	CREATE DATABASE [GoGirl]

GO
/****** Object:  Table [dbo].[GoGirlCustomer]    Script Date: 5/17/2019 9:40:04 PM ******/

CREATE TABLE [dbo].[GoGirlCustomer](
    [Id] INT NOT NULL PRIMARY KEY, 
	[FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
	[Email] [nvarchar](50) NOT NULL,
    [City] NVARCHAR(50) NULL, 
    [State] NVARCHAR(25) NULL, 
    [politicalAffilliation] NCHAR(10) NULL, 
    [Admin] BOOLEAN NOT NULL
 CONSTRAINT [PK_Foodlog] PRIMARY KEY CLUSTERED 
(
	[FoodlogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
Go


GO
/****** Object:  Table [dbo].[Disenrollment]    Script Date: 6/27/2018 9:40:04 PM ******/
CREATE TABLE [dbo].[Admin]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[GoGirlId] INT NOT NULL,
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [AdminType] CHAR(10) NULL

 CONSTRAINT[PK_GoGirlCustomer] PRIMARY KEY CLUSTERED
(
   [GoGirlId] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]

GO
/****** Object:  Table [dbo].[Enrollment]    Script Date: 6/27/2018 9:40:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Use [GoGirl]

CREATE TABLE [dbo].[Workoutlog]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[GoGirlId] INT NOT NULL,
    [Day] DATETIME NULL, 
    [DayOfWeek] NVARCHAR(50) NULL, 
    [Program] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [politicalAffilliation] NCHAR(10) NULL, 
    [Admin] CHAR(10) NULL

CONSTRAINT[PK_GoGirlCustomer] PRIMARY KEY CLUSTERED
(
   [GoGirlId] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]

CREATE TABLE [dbo].[Excercises]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[WorkoutLogId] INT NOT NULL,
    [Weight] NVARCHAR(50) NULL, 
    [NumberOfReps] NVARCHAR(50) NULL, 
    [Program] NVARCHAR(50) NULL

CONSTRAINT[PK_WorkoutLog] PRIMARY KEY CLUSTERED
(
 [WorkoutLogId] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]


GO
SET IDENTITY_INSERT[dbo].[GoGirlCustomer]
ON

GO
INSERT [dbo].[GoGirlCustomer] ([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
	VALUES (1,'Justine', 'Alires', 'ja@google.com', 'Seattle', 'Washington', 'FreedomFighter', '1')
INSERT [dbo].[GoGirlCustomer] ([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
	VALUES (1,'Julia', 'Chiles', 'julia@google.com', 'Seattle', 'Washington', 'FreedomFighter', '0')
INSERT [dbo].[GoGirlCustomer] ([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
	VALUES (1,'Gayle', 'Gand', 'gayle@google.com', 'Denver', 'Colorado', 'FreedomFighter', '0')
INSERT [dbo].[GoGirlCustomer] ([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
	VALUES (1,'Martha', 'Stewart', 'martha@google.com', 'Austin', 'Texas', 'FreedomFighter', '0')
INSERT [dbo].[GoGirlCustomer] ([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
	VALUES (1,'Adriana', 'Pacheco', 'adriana@google.com', 'Albuquerque', 'New Mexico', 'FreedomFighter', '0')
INSERT [dbo].[GoGirlCustomer] ([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
	VALUES (1,'Janine', 'Alires', 'janine@google.com', 'New York', 'New York', 'FreedomFighter', '0')
INSERT [dbo].[GoGirlCustomer] ([Id],[FirstName],[LastName],[Email],[City],[State],[politicalAffiliation],[Admin])
	VALUES (1,'Sara', 'Stephens', 'sara@google.com', 'Houston', 'Texas', 'FreedomFighter', '0')

	--------------------------
RETURN 0
