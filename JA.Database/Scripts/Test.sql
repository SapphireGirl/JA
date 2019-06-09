INSERT[dbo].[Enrollment]
([EnrollmentID], [StudentID], [CourseID], [Grade]) VALUES(5, 2, 2, 1)
GO
INSERT[dbo].[Enrollment]
([EnrollmentID], [StudentID], [CourseID], [Grade]) VALUES(13, 2, 3, 3)
GO
INSERT[dbo].[Enrollment]
([EnrollmentID], [StudentID], [CourseID], [Grade]) VALUES(20, 1, 1, 1)
GO
INSERT[dbo].[Enrollment]
([EnrollmentID], [StudentID], [CourseID], [Grade]) VALUES(38, 1, 2, 3)
GO
SET IDENTITY_INSERT[dbo].[Enrollment]
OFF
GO
SET IDENTITY_INSERT[dbo].[Student]
ON

GO
INSERT[dbo].[Student]
([StudentID], [Name], [Email]) VALUES(1, N'Alice', N'alice@gmail.com')
GO
INSERT[dbo].[Student]
([StudentID], [Name], [Email]) VALUES(2, N'Bob', N'bob@outlook.com')
GO
SET IDENTITY_INSERT[dbo].[Student]
OFF
GO
ALTER TABLE[dbo].[Disenrollment] WITH CHECK ADD CONSTRAINT[FK_Disenrollment_Course] FOREIGN KEY([CourseID])
REFERENCES[dbo].[Course]
([CourseID])
GO
ALTER TABLE[dbo].[Disenrollment]
CHECK CONSTRAINT[FK_Disenrollment_Course]
GO
ALTER TABLE[dbo].[Disenrollment] WITH CHECK ADD CONSTRAINT[FK_Disenrollment_Student] FOREIGN KEY([StudentID])
REFERENCES[dbo].[Student]
([StudentID])
GO
ALTER TABLE[dbo].[Disenrollment]
CHECK CONSTRAINT[FK_Disenrollment_Student]
GO
ALTER TABLE[dbo].[Enrollment] WITH CHECK ADD CONSTRAINT[FK_Enrollment_Course] FOREIGN KEY([CourseID])
REFERENCES[dbo].[Course]
([CourseID])
GO
ALTER TABLE[dbo].[Enrollment]
CHECK CONSTRAINT[FK_Enrollment_Course]
GO
ALTER TABLE[dbo].[Enrollment] WITH CHECK ADD CONSTRAINT[FK_Enrollment_Student] FOREIGN KEY([StudentID])
REFERENCES[dbo].[Student]
([StudentID])
GO
ALTER TABLE[dbo].[Enrollment]
CHECK CONSTRAINT[FK_Enrollment_Student]
GO
