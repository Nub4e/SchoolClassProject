USE [master]
GO
/****** Object:  Database [Classbook]    Script Date: 19.3.2019 г. 18:53:30 ******/
CREATE DATABASE [Classbook]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Classbook', FILENAME = N'D:\Sql Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Classbook.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Classbook_log', FILENAME = N'D:\Sql Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Classbook_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Classbook] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Classbook].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Classbook] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Classbook] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Classbook] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Classbook] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Classbook] SET ARITHABORT OFF 
GO
ALTER DATABASE [Classbook] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Classbook] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Classbook] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Classbook] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Classbook] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Classbook] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Classbook] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Classbook] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Classbook] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Classbook] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Classbook] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Classbook] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Classbook] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Classbook] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Classbook] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Classbook] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Classbook] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Classbook] SET RECOVERY FULL 
GO
ALTER DATABASE [Classbook] SET  MULTI_USER 
GO
ALTER DATABASE [Classbook] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Classbook] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Classbook] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Classbook] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Classbook] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Classbook', N'ON'
GO
ALTER DATABASE [Classbook] SET QUERY_STORE = OFF
GO
USE [Classbook]
GO
/****** Object:  Schema [classbook]    Script Date: 19.3.2019 г. 18:53:30 ******/
CREATE SCHEMA [classbook]
GO
/****** Object:  UserDefinedFunction [classbook].[enum2str$marks$description]    Script Date: 19.3.2019 г. 18:53:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [classbook].[enum2str$marks$description] 
( 
   @setval tinyint
)
RETURNS nvarchar(max)
AS 
   BEGIN
      RETURN 
         CASE @setval
            WHEN 1 THEN 'слаб'
            WHEN 2 THEN 'среден'
            WHEN 3 THEN 'добър'
            WHEN 4 THEN 'много добър'
            WHEN 5 THEN 'отличен'
            ELSE ''
         END
   END
GO
/****** Object:  UserDefinedFunction [classbook].[norm_enum$marks$description]    Script Date: 19.3.2019 г. 18:53:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [classbook].[norm_enum$marks$description] 
( 
   @setval nvarchar(max)
)
RETURNS nvarchar(max)
AS 
   BEGIN
      RETURN classbook.enum2str$marks$description(classbook.str2enum$marks$description(@setval))
   END
GO
/****** Object:  UserDefinedFunction [classbook].[str2enum$marks$description]    Script Date: 19.3.2019 г. 18:53:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [classbook].[str2enum$marks$description] 
( 
   @setval nvarchar(max)
)
RETURNS tinyint
AS 
   BEGIN
      RETURN 
         CASE @setval
            WHEN 'слаб' THEN 1
            WHEN 'среден' THEN 2
            WHEN 'добър' THEN 3
            WHEN 'много добър' THEN 4
            WHEN 'отличен' THEN 5
            ELSE 0
         END
   END
GO
/****** Object:  Table [classbook].[Classes]    Script Date: 19.3.2019 г. 18:53:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [classbook].[Classes](
	[classId] [int] IDENTITY(1,1) NOT NULL,
	[grade] [int] NOT NULL,
	[letter] [nvarchar](2) NOT NULL,
	[headTeacherId] [int] NOT NULL,
	[schoolId] [int] NOT NULL,
 CONSTRAINT [PK_classes_classId] PRIMARY KEY CLUSTERED 
(
	[classId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [classes$head_teacher_id] UNIQUE NONCLUSTERED 
(
	[headTeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [classbook].[Marks]    Script Date: 19.3.2019 г. 18:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [classbook].[Marks](
	[markId] [int] IDENTITY(1,1) NOT NULL,
	[description] [nvarchar](11) NOT NULL,
	[number] [numeric](3, 2) NOT NULL,
	[subjectId] [int] NOT NULL,
	[studentId] [int] NOT NULL,
	[teacherId] [int] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_marks_markId] PRIMARY KEY CLUSTERED 
(
	[markId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [classbook].[StudentContactInfo]    Script Date: 19.3.2019 г. 18:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [classbook].[StudentContactInfo](
	[contactInfoId] [int] IDENTITY(1,1) NOT NULL,
	[firstEmail] [nvarchar](20) NOT NULL,
	[secondEmail] [nvarchar](20) NULL,
	[firstPhoneNumber] [nvarchar](12) NOT NULL,
	[secondPhoneNumber] [nvarchar](12) NULL,
	[studentId] [int] NOT NULL,
 CONSTRAINT [PK_student_contact_info_contactInfoId] PRIMARY KEY CLUSTERED 
(
	[contactInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [student_contact_info$student_id] UNIQUE NONCLUSTERED 
(
	[studentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [classbook].[Students]    Script Date: 19.3.2019 г. 18:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [classbook].[Students](
	[studentId] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](20) NOT NULL,
	[middleName] [nvarchar](20) NOT NULL,
	[lastName] [nvarchar](20) NOT NULL,
	[birthdate] [date] NOT NULL,
	[classId] [int] NOT NULL,
 CONSTRAINT [PK_students_studentId] PRIMARY KEY CLUSTERED 
(
	[studentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [classbook].[Subjects]    Script Date: 19.3.2019 г. 18:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [classbook].[Subjects](
	[subjectId] [int] IDENTITY(7,1) NOT NULL,
	[name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_subjects_subjectId] PRIMARY KEY CLUSTERED 
(
	[subjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [subjects$name] UNIQUE NONCLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [classbook].[TeacherContactInfo]    Script Date: 19.3.2019 г. 18:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [classbook].[TeacherContactInfo](
	[contactInfoId] [int] NOT NULL,
	[firstEmail] [nvarchar](20) NOT NULL,
	[secondEmail] [nvarchar](20) NULL,
	[firstPhoneNumber] [nvarchar](12) NOT NULL,
	[secondPhoneNumber] [nvarchar](12) NULL,
	[teacherId] [int] NOT NULL,
 CONSTRAINT [PK_teacher_contact_info_contactInfoId] PRIMARY KEY CLUSTERED 
(
	[contactInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [classbook].[Teachers]    Script Date: 19.3.2019 г. 18:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [classbook].[Teachers](
	[teacherId] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](20) NOT NULL,
	[middleName] [nvarchar](20) NOT NULL,
	[lastName] [nvarchar](20) NOT NULL,
	[birthdate] [date] NOT NULL,
	[subjectId] [int] NOT NULL,
 CONSTRAINT [PK_teachers_teacherId] PRIMARY KEY CLUSTERED 
(
	[teacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [fk_classes_schools]    Script Date: 19.3.2019 г. 18:53:31 ******/
CREATE NONCLUSTERED INDEX [fk_classes_schools] ON [classbook].[Classes]
(
	[schoolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_marks_students]    Script Date: 19.3.2019 г. 18:53:31 ******/
CREATE NONCLUSTERED INDEX [fk_marks_students] ON [classbook].[Marks]
(
	[studentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_marks_subjects]    Script Date: 19.3.2019 г. 18:53:31 ******/
CREATE NONCLUSTERED INDEX [fk_marks_subjects] ON [classbook].[Marks]
(
	[subjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_marks_teachers]    Script Date: 19.3.2019 г. 18:53:31 ******/
CREATE NONCLUSTERED INDEX [fk_marks_teachers] ON [classbook].[Marks]
(
	[teacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_students_classes]    Script Date: 19.3.2019 г. 18:53:31 ******/
CREATE NONCLUSTERED INDEX [fk_students_classes] ON [classbook].[Students]
(
	[classId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_teacher_contact_info_teachers]    Script Date: 19.3.2019 г. 18:53:31 ******/
CREATE NONCLUSTERED INDEX [fk_teacher_contact_info_teachers] ON [classbook].[TeacherContactInfo]
(
	[teacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_teachers_subjects]    Script Date: 19.3.2019 г. 18:53:31 ******/
CREATE NONCLUSTERED INDEX [fk_teachers_subjects] ON [classbook].[Teachers]
(
	[subjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [classbook].[StudentContactInfo] ADD  DEFAULT (NULL) FOR [secondEmail]
GO
ALTER TABLE [classbook].[StudentContactInfo] ADD  DEFAULT (NULL) FOR [secondPhoneNumber]
GO
ALTER TABLE [classbook].[TeacherContactInfo] ADD  DEFAULT ((0)) FOR [contactInfoId]
GO
ALTER TABLE [classbook].[TeacherContactInfo] ADD  DEFAULT (NULL) FOR [secondEmail]
GO
ALTER TABLE [classbook].[TeacherContactInfo] ADD  DEFAULT (NULL) FOR [secondPhoneNumber]
GO
ALTER TABLE [classbook].[Classes]  WITH CHECK ADD  CONSTRAINT [classes$fk_classes_teachers] FOREIGN KEY([headTeacherId])
REFERENCES [classbook].[Teachers] ([teacherId])
GO
ALTER TABLE [classbook].[Classes] CHECK CONSTRAINT [classes$fk_classes_teachers]
GO
ALTER TABLE [classbook].[Marks]  WITH CHECK ADD  CONSTRAINT [marks$fk_marks_students] FOREIGN KEY([studentId])
REFERENCES [classbook].[Students] ([studentId])
GO
ALTER TABLE [classbook].[Marks] CHECK CONSTRAINT [marks$fk_marks_students]
GO
ALTER TABLE [classbook].[Marks]  WITH CHECK ADD  CONSTRAINT [marks$fk_marks_subjects] FOREIGN KEY([subjectId])
REFERENCES [classbook].[Subjects] ([subjectId])
GO
ALTER TABLE [classbook].[Marks] CHECK CONSTRAINT [marks$fk_marks_subjects]
GO
ALTER TABLE [classbook].[Marks]  WITH CHECK ADD  CONSTRAINT [marks$fk_marks_teachers] FOREIGN KEY([teacherId])
REFERENCES [classbook].[Teachers] ([teacherId])
GO
ALTER TABLE [classbook].[Marks] CHECK CONSTRAINT [marks$fk_marks_teachers]
GO
ALTER TABLE [classbook].[StudentContactInfo]  WITH CHECK ADD  CONSTRAINT [student_contact_info$fk_student_contact_info] FOREIGN KEY([studentId])
REFERENCES [classbook].[Students] ([studentId])
GO
ALTER TABLE [classbook].[StudentContactInfo] CHECK CONSTRAINT [student_contact_info$fk_student_contact_info]
GO
ALTER TABLE [classbook].[Students]  WITH CHECK ADD  CONSTRAINT [students$fk_students_classes] FOREIGN KEY([classId])
REFERENCES [classbook].[Classes] ([classId])
GO
ALTER TABLE [classbook].[Students] CHECK CONSTRAINT [students$fk_students_classes]
GO
ALTER TABLE [classbook].[TeacherContactInfo]  WITH CHECK ADD  CONSTRAINT [teacher_contact_info$fk_teacher_contact_info_teachers] FOREIGN KEY([teacherId])
REFERENCES [classbook].[Teachers] ([teacherId])
GO
ALTER TABLE [classbook].[TeacherContactInfo] CHECK CONSTRAINT [teacher_contact_info$fk_teacher_contact_info_teachers]
GO
ALTER TABLE [classbook].[Teachers]  WITH CHECK ADD  CONSTRAINT [teachers$fk_teachers_subjects] FOREIGN KEY([subjectId])
REFERENCES [classbook].[Subjects] ([subjectId])
GO
ALTER TABLE [classbook].[Teachers] CHECK CONSTRAINT [teachers$fk_teachers_subjects]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'classbook.marks' , @level0type=N'SCHEMA',@level0name=N'classbook', @level1type=N'FUNCTION',@level1name=N'enum2str$marks$description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'classbook.marks' , @level0type=N'SCHEMA',@level0name=N'classbook', @level1type=N'FUNCTION',@level1name=N'norm_enum$marks$description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'classbook.marks' , @level0type=N'SCHEMA',@level0name=N'classbook', @level1type=N'FUNCTION',@level1name=N'str2enum$marks$description'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'classbook.classes' , @level0type=N'SCHEMA',@level0name=N'classbook', @level1type=N'TABLE',@level1name=N'Classes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'classbook.marks' , @level0type=N'SCHEMA',@level0name=N'classbook', @level1type=N'TABLE',@level1name=N'Marks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'classbook.student_contact_info' , @level0type=N'SCHEMA',@level0name=N'classbook', @level1type=N'TABLE',@level1name=N'StudentContactInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'classbook.students' , @level0type=N'SCHEMA',@level0name=N'classbook', @level1type=N'TABLE',@level1name=N'Students'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'classbook.subjects' , @level0type=N'SCHEMA',@level0name=N'classbook', @level1type=N'TABLE',@level1name=N'Subjects'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'classbook.teacher_contact_info' , @level0type=N'SCHEMA',@level0name=N'classbook', @level1type=N'TABLE',@level1name=N'TeacherContactInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'classbook.teachers' , @level0type=N'SCHEMA',@level0name=N'classbook', @level1type=N'TABLE',@level1name=N'Teachers'
GO
USE [master]
GO
ALTER DATABASE [Classbook] SET  READ_WRITE 
GO
