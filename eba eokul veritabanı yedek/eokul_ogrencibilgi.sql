-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: eokul
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `ogrencibilgi`
--

DROP TABLE IF EXISTS `ogrencibilgi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ogrencibilgi` (
  `ogrenciNo` int NOT NULL,
  `ogrenciAdi` varchar(20) NOT NULL,
  `ogrenciSoyadi` varchar(20) NOT NULL,
  `ogrenciBolumu` varchar(30) NOT NULL,
  `ogrenciSinifi` tinyint NOT NULL,
  `ogrenciDogumTarihi` date NOT NULL,
  PRIMARY KEY (`ogrenciNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ogrencibilgi`
--

LOCK TABLES `ogrencibilgi` WRITE;
/*!40000 ALTER TABLE `ogrencibilgi` DISABLE KEYS */;
INSERT INTO `ogrencibilgi` VALUES (100,'HASAN','AHMET','METAL',10,'2001-02-20'),(110,'ALİ','VELİ','MAKİNE',11,'2005-08-20'),(120,'AYŞE','FATMA','BİLİŞİM',12,'2012-09-20'),(130,'HÜSEYİN','EMİR','MOBİLYA',9,'2016-07-20'),(140,'EBRU','KAYA','BİLİŞİM',10,'2010-09-20');
/*!40000 ALTER TABLE `ogrencibilgi` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-14 15:35:59
