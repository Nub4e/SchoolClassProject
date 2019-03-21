-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: localhost    Database: classbook
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `classes`
--

DROP TABLE IF EXISTS `classes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `classes` (
  `classId` int(11) NOT NULL AUTO_INCREMENT,
  `grade` int(2) NOT NULL,
  `letter` varchar(2) NOT NULL,
  `headTeacherId` int(11) NOT NULL,
  `schoolId` int(11) NOT NULL,
  PRIMARY KEY (`classId`),
  UNIQUE KEY `head_teacher_id` (`headTeacherId`),
  KEY `fk_classes_schools` (`schoolId`),
  CONSTRAINT `fk_classes_teachers` FOREIGN KEY (`headTeacherId`) REFERENCES `teachers` (`teacherId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `marks`
--

DROP TABLE IF EXISTS `marks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `marks` (
  `markId` int(11) NOT NULL AUTO_INCREMENT,
  `description` enum('слаб','среден','добър','много добър','отличен') NOT NULL,
  `number` double(3,2) NOT NULL,
  `subjectId` int(11) NOT NULL,
  `studentId` int(11) NOT NULL,
  `teacherId` int(11) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`markId`),
  KEY `fk_marks_subjects` (`subjectId`),
  KEY `fk_marks_students` (`studentId`),
  KEY `fk_marks_teachers` (`teacherId`),
  CONSTRAINT `fk_marks_students` FOREIGN KEY (`studentId`) REFERENCES `students` (`studentId`),
  CONSTRAINT `fk_marks_subjects` FOREIGN KEY (`subjectId`) REFERENCES `subjects` (`subjectId`),
  CONSTRAINT `fk_marks_teachers` FOREIGN KEY (`teacherId`) REFERENCES `teachers` (`teacherId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `student_contact_info`
--

DROP TABLE IF EXISTS `student_contact_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `student_contact_info` (
  `contactInfoId` int(11) NOT NULL AUTO_INCREMENT,
  `firstEmail` varchar(20) NOT NULL,
  `secondEmail` varchar(20) DEFAULT NULL,
  `firstPhoneNumber` varchar(12) NOT NULL,
  `secondPhoneNumber` varchar(12) DEFAULT NULL,
  `studentId` int(11) NOT NULL,
  PRIMARY KEY (`contactInfoId`),
  UNIQUE KEY `student_id` (`studentId`),
  CONSTRAINT `fk_student_contact_info` FOREIGN KEY (`studentId`) REFERENCES `students` (`studentId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `students` (
  `studentId` int(11) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(20) NOT NULL,
  `middleName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `birthdate` date NOT NULL,
  `classId` int(11) NOT NULL,
  PRIMARY KEY (`studentId`),
  KEY `fk_students_classes` (`classId`),
  CONSTRAINT `fk_students_classes` FOREIGN KEY (`classId`) REFERENCES `classes` (`classId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `subjects`
--

DROP TABLE IF EXISTS `subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `subjects` (
  `subjectId` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(20) NOT NULL,
  PRIMARY KEY (`subjectId`),
  UNIQUE KEY `name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `teacher_contact_info`
--

DROP TABLE IF EXISTS `teacher_contact_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `teacher_contact_info` (
  `contactInfoId` int(11) NOT NULL DEFAULT '0',
  `firstEmail` varchar(20) NOT NULL,
  `secondEmail` varchar(20) DEFAULT NULL,
  `firstPhoneNumber` varchar(12) NOT NULL,
  `secondPhoneNumber` varchar(12) DEFAULT NULL,
  `teacherId` int(11) NOT NULL,
  PRIMARY KEY (`contactInfoId`),
  UNIQUE KEY `teacherId_UNIQUE` (`teacherId`),
  KEY `fk_teacher_contact_info_teachers` (`teacherId`),
  CONSTRAINT `fk_teacher_contact_info_teachers` FOREIGN KEY (`teacherId`) REFERENCES `teachers` (`teacherId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `teachers`
--

DROP TABLE IF EXISTS `teachers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `teachers` (
  `teacherId` int(11) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(20) NOT NULL,
  `middleName` varchar(20) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `birthdate` date NOT NULL,
  `subjectId` int(11) NOT NULL,
  PRIMARY KEY (`teacherId`),
  KEY `fk_teachers_subjects` (`subjectId`),
  CONSTRAINT `fk_teachers_subjects` FOREIGN KEY (`subjectId`) REFERENCES `subjects` (`subjectId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-03-20 20:13:23
