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
-- Table structure for table `dersler`
--

DROP TABLE IF EXISTS `dersler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dersler` (
  `dersKodu` varchar(4) NOT NULL,
  `dersAdi` varchar(45) NOT NULL,
  PRIMARY KEY (`dersKodu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dersler`
--

LOCK TABLES `dersler` WRITE;
/*!40000 ALTER TABLE `dersler` DISABLE KEYS */;
INSERT INTO `dersler` VALUES ('BED','BEDEN EĞİTİMİ'),('BTT','BİLİŞİM TEKNOLOJİLERİNİN TEMELLERİ'),('EDE','EDEBİYAT'),('FİZ','FİZİK'),('MAT','MATEMATİK'),('NESN','NESNE TABANLI PROGRAMLAMA'),('OP','OFİS PROGRAMLARI'),('PT','PROGRAMLAMA TEMELLERİ');
/*!40000 ALTER TABLE `dersler` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `ogrencinot`
--

DROP TABLE IF EXISTS `ogrencinot`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ogrencinot` (
  `ogrenciNotId` int NOT NULL AUTO_INCREMENT,
  `ogrenciNoFK` int NOT NULL,
  `dersKoduFK` varchar(4) NOT NULL,
  `yazili1` tinyint NOT NULL,
  `yazili2` tinyint NOT NULL,
  `yazili3` tinyint NOT NULL,
  `uygulama1` tinyint NOT NULL,
  `uygulama2` tinyint NOT NULL,
  `sozlu1` tinyint NOT NULL,
  `sozlu2` tinyint NOT NULL,
  `ortalama` tinyint DEFAULT '0',
  PRIMARY KEY (`ogrenciNotId`,`ogrenciNoFK`,`dersKoduFK`),
  KEY `fk_ogrencinot_ogrencibilgi_idx` (`ogrenciNoFK`),
  KEY `fk_ogrencinot_dersler1_idx` (`dersKoduFK`),
  CONSTRAINT `fk_ogrencinot_dersler1` FOREIGN KEY (`dersKoduFK`) REFERENCES `dersler` (`dersKodu`),
  CONSTRAINT `fk_ogrencinot_ogrencibilgi` FOREIGN KEY (`ogrenciNoFK`) REFERENCES `ogrencibilgi` (`ogrenciNo`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ogrencinot`
--

LOCK TABLES `ogrencinot` WRITE;
/*!40000 ALTER TABLE `ogrencinot` DISABLE KEYS */;
INSERT INTO `ogrencinot` VALUES (1,100,'BTT',56,56,87,87,87,87,87,0),(2,110,'OP',78,98,8,88,76,45,56,0),(3,110,'EDE',67,78,67,89,56,56,56,0),(4,130,'FİZ',76,76,56,66,66,66,76,0),(5,140,'PT',67,76,65,76,76,54,54,0),(6,110,'BTT',65,65,65,65,65,65,65,0);
/*!40000 ALTER TABLE `ogrencinot` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-14 15:37:15
