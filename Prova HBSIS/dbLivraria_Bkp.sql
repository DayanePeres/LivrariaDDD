-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: dblivraria
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20191025205712_firstMigration','2.2.6-servicing-10079');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `autor`
--

DROP TABLE IF EXISTS `autor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `autor` (
  `Id` char(36) NOT NULL,
  `CreateAt` datetime(6) DEFAULT NULL,
  `UpdateAt` datetime(6) DEFAULT NULL,
  `Nome` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `autor`
--

LOCK TABLES `autor` WRITE;
/*!40000 ALTER TABLE `autor` DISABLE KEYS */;
INSERT INTO `autor` VALUES ('1','2019-10-26 00:00:00.000000','2019-10-26 00:00:00.000000','J.K Rowling');
/*!40000 ALTER TABLE `autor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `editora`
--

DROP TABLE IF EXISTS `editora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `editora` (
  `Id` char(36) NOT NULL,
  `CreateAt` datetime(6) DEFAULT NULL,
  `UpdateAt` datetime(6) DEFAULT NULL,
  `Nome` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `editora`
--

LOCK TABLES `editora` WRITE;
/*!40000 ALTER TABLE `editora` DISABLE KEYS */;
INSERT INTO `editora` VALUES ('1','2019-10-26 00:00:00.000000','2019-10-26 00:00:00.000000','Rocco');
/*!40000 ALTER TABLE `editora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `livro`
--

DROP TABLE IF EXISTS `livro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `livro` (
  `Id` char(36) NOT NULL,
  `CreateAt` datetime(6) DEFAULT NULL,
  `UpdateAt` datetime(6) DEFAULT NULL,
  `Titulo` varchar(100) NOT NULL,
  `AnoEdicao` datetime(6) NOT NULL,
  `Genero` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `livro`
--

LOCK TABLES `livro` WRITE;
/*!40000 ALTER TABLE `livro` DISABLE KEYS */;
INSERT INTO `livro` VALUES ('233af433-3587-4122-8c3a-9a75b24e6dc1','2019-10-28 01:01:26.826518',NULL,'Harry Potter e o Prisioneiro de Azkaban','1997-01-01 00:00:00.000000','Fantasia'),('3b960dbf-a3d6-4dc3-80ff-9861b2e30f4c','2019-10-28 01:03:11.241344',NULL,'Harry Potter e a Ordem da Fênix','2002-01-01 00:00:00.000000','Fantasia'),('4c3a931b-bce7-4c69-8142-ea2ca9e7c4e7','2019-10-28 01:03:46.284756',NULL,'Harry Potter e as Relíquias da Morte','2007-01-01 00:00:00.000000','Fantasia'),('645ef11e-1d43-4884-85b2-2742929442cf','2019-10-26 20:05:58.972184',NULL,'Harry Potter e a Pedra Filosofal','1991-01-01 00:00:00.000000','Fantasia'),('a7a17eec-5d31-41b2-80ea-5766acf94941','2019-10-28 01:01:57.782952',NULL,'Harry Potter e o Cálice de Fogo','2000-01-01 00:00:00.000000','Fantasia'),('c622c458-d0f7-464c-b043-4671314386fb','2019-10-28 00:58:57.098614',NULL,'Harry Potter e a Câmara Secreta','1993-01-01 00:00:00.000000','Fantasia'),('db1356b0-a1b3-4b14-a31c-cabfd464d820','2019-10-28 01:03:28.618357',NULL,'Harry Potter e o Enigma do Príncipe','2005-01-01 00:00:00.000000','Fantasia');
/*!40000 ALTER TABLE `livro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `livroautor`
--

DROP TABLE IF EXISTS `livroautor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `livroautor` (
  `Id` char(36) NOT NULL,
  `CreateAt` datetime(6) DEFAULT NULL,
  `UpdateAt` datetime(6) DEFAULT NULL,
  `Qtde` int(11) NOT NULL,
  `codLivro` int(11) NOT NULL,
  `codAutor` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_LivroAutor_Autor_Id` FOREIGN KEY (`Id`) REFERENCES `autor` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_LivroAutor_Livro_Id` FOREIGN KEY (`Id`) REFERENCES `livro` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `livroautor`
--

LOCK TABLES `livroautor` WRITE;
/*!40000 ALTER TABLE `livroautor` DISABLE KEYS */;
/*!40000 ALTER TABLE `livroautor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `livroeditora`
--

DROP TABLE IF EXISTS `livroeditora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `livroeditora` (
  `Id` char(36) NOT NULL,
  `CreateAt` datetime(6) DEFAULT NULL,
  `UpdateAt` datetime(6) DEFAULT NULL,
  `Qtde` int(11) NOT NULL,
  `codEditora` int(11) NOT NULL,
  `codLivro` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `FK_LivroEditora_Editora_Id` FOREIGN KEY (`Id`) REFERENCES `editora` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_LivroEditora_Livro_Id` FOREIGN KEY (`Id`) REFERENCES `livro` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `livroeditora`
--

LOCK TABLES `livroeditora` WRITE;
/*!40000 ALTER TABLE `livroeditora` DISABLE KEYS */;
/*!40000 ALTER TABLE `livroeditora` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-10-27 22:21:27
