-- MariaDB dump 10.19-11.3.2-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: rel
-- ------------------------------------------------------
-- Server version	11.3.2-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `rel`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `rel` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `rel`;

--
-- Table structure for table `demande`
--

DROP TABLE IF EXISTS `demande`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `demande` (
  `Id_Demande` int(11) NOT NULL AUTO_INCREMENT,
  `Objet_demande` varchar(50) DEFAULT NULL,
  `Commentaire` varchar(255) DEFAULT NULL,
  `type_demande` int(11) NOT NULL,
  `Prioritaire` tinyint(1) DEFAULT 0,
  `Id_Utilisateur` int(11) NOT NULL,
  `Statut` int(1) DEFAULT 0,
  `duree_debut` datetime DEFAULT NULL,
  `duree_fin` datetime DEFAULT NULL,
  `motif_att` varchar(255) DEFAULT '',
  `motif_refu` varchar(255) DEFAULT '',
  `motif_clo` varchar(255) DEFAULT '',
  `Usernotif` tinyint(1) DEFAULT 0,
  `Adminnotif` tinyint(1) DEFAULT 0,
  `Histonotif` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id_Demande`),
  KEY `Id_Utilisateur` (`Id_Utilisateur`),
  CONSTRAINT `demande_ibfk_1` FOREIGN KEY (`Id_Utilisateur`) REFERENCES `utilisateur` (`Id_Utilisateur`)
) ENGINE=InnoDB AUTO_INCREMENT=67 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `demande`
--

LOCK TABLES `demande` WRITE;
/*!40000 ALTER TABLE `demande` DISABLE KEYS */;
INSERT INTO `demande` VALUES
(55,'Test 1 notif','',1,1,1,6,'2025-02-21 06:53:45','2025-02-21 06:53:45','','','nul\r\n',0,0,0),
(56,'test bindlist','',1,1,1,6,'2025-02-21 07:03:31','2025-02-21 07:03:31','','','t moche\r\n',0,0,0),
(57,'bindlist 2 ','',1,1,1,6,'2025-02-21 07:04:48','2025-02-21 07:04:48','','','oui oui baguette',0,0,0),
(58,'shallah les notif','',1,1,1,6,'2025-02-21 08:00:22','2025-02-21 08:00:22','','','',0,0,0),
(59,'dzqdzq','',1,1,1,2,'2025-02-21 08:31:06','2025-02-21 08:31:06','','','',1,0,0),
(60,'dzdq','',3,1,1,1,'2025-02-21 08:31:11','2025-02-21 08:31:11','','','',0,1,0),
(61,'oui','',1,1,1,4,'2025-02-21 20:48:42','2025-02-21 20:48:42','wait a minute','oui','',0,1,0),
(62,'tu pue','',1,1,1,3,'2025-02-21 20:48:49','2025-02-21 20:48:49','att frr','','',0,1,0),
(63,'jadore rire','',1,1,1,1,'2025-02-21 20:49:09','2025-02-21 20:49:09','','','',0,1,0),
(64,'jui drole','',1,1,1,5,'2025-02-21 20:49:20','2025-02-21 20:49:20','','','',0,1,0),
(66,'moee','',1,0,1,1,'2025-02-24 12:51:22','2025-02-24 12:51:22','','','',0,1,0);
/*!40000 ALTER TABLE `demande` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `demande_reunion`
--

DROP TABLE IF EXISTS `demande_reunion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `demande_reunion` (
  `Id_Demande_Reunion` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Demande` int(11) NOT NULL,
  `Id_Reunion` int(11) NOT NULL,
  PRIMARY KEY (`Id_Demande_Reunion`),
  KEY `Id_Demande` (`Id_Demande`),
  KEY `Id_Reunion` (`Id_Reunion`),
  CONSTRAINT `demande_reunion_ibfk_1` FOREIGN KEY (`Id_Demande`) REFERENCES `demande` (`Id_Demande`) ON DELETE CASCADE,
  CONSTRAINT `demande_reunion_ibfk_2` FOREIGN KEY (`Id_Reunion`) REFERENCES `reunion` (`Id_Reunion`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `demande_reunion`
--

LOCK TABLES `demande_reunion` WRITE;
/*!40000 ALTER TABLE `demande_reunion` DISABLE KEYS */;
/*!40000 ALTER TABLE `demande_reunion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `demande_services`
--

DROP TABLE IF EXISTS `demande_services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `demande_services` (
  `Id_Demande_Service` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Demande` int(11) NOT NULL,
  `Id_Service` int(11) NOT NULL,
  PRIMARY KEY (`Id_Demande_Service`),
  KEY `Id_Demande` (`Id_Demande`),
  KEY `Id_Service` (`Id_Service`),
  CONSTRAINT `demande_services_ibfk_1` FOREIGN KEY (`Id_Demande`) REFERENCES `demande` (`Id_Demande`) ON DELETE CASCADE,
  CONSTRAINT `demande_services_ibfk_2` FOREIGN KEY (`Id_Service`) REFERENCES `services` (`Id_Service`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `demande_services`
--

LOCK TABLES `demande_services` WRITE;
/*!40000 ALTER TABLE `demande_services` DISABLE KEYS */;
INSERT INTO `demande_services` VALUES
(19,55,1),
(20,56,1),
(21,57,1),
(22,58,1),
(23,59,1),
(24,61,1),
(25,62,1),
(26,63,1),
(27,64,2),
(28,66,3);
/*!40000 ALTER TABLE `demande_services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `demande_vehicule`
--

DROP TABLE IF EXISTS `demande_vehicule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `demande_vehicule` (
  `Id_Demande_Vehicule` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Demande` int(11) NOT NULL,
  `Id_Vehicule` int(11) NOT NULL,
  PRIMARY KEY (`Id_Demande_Vehicule`),
  KEY `Id_Demande` (`Id_Demande`),
  KEY `Id_Vehicule` (`Id_Vehicule`),
  CONSTRAINT `demande_vehicule_ibfk_1` FOREIGN KEY (`Id_Demande`) REFERENCES `demande` (`Id_Demande`) ON DELETE CASCADE,
  CONSTRAINT `demande_vehicule_ibfk_2` FOREIGN KEY (`Id_Vehicule`) REFERENCES `vehicule` (`Id_Vehicule`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `demande_vehicule`
--

LOCK TABLES `demande_vehicule` WRITE;
/*!40000 ALTER TABLE `demande_vehicule` DISABLE KEYS */;
INSERT INTO `demande_vehicule` VALUES
(2,60,1);
/*!40000 ALTER TABLE `demande_vehicule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log`
--

DROP TABLE IF EXISTS `log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `log` (
  `Id_LOG` int(11) NOT NULL AUTO_INCREMENT,
  `type_action` varchar(50) DEFAULT NULL,
  `Date_modif` datetime DEFAULT NULL,
  `fk_id_user` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_LOG`),
  KEY `fk_id_user` (`fk_id_user`),
  CONSTRAINT `log_ibfk_1` FOREIGN KEY (`fk_id_user`) REFERENCES `utilisateur` (`Id_Utilisateur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log`
--

LOCK TABLES `log` WRITE;
/*!40000 ALTER TABLE `log` DISABLE KEYS */;
/*!40000 ALTER TABLE `log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reunion`
--

DROP TABLE IF EXISTS `reunion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reunion` (
  `Id_Reunion` int(11) NOT NULL AUTO_INCREMENT,
  `Nb_place` int(11) DEFAULT NULL,
  `Nom_salle` varchar(50) DEFAULT NULL,
  `Numero` int(11) DEFAULT NULL,
  `Heure_debut` time DEFAULT NULL,
  `Heure_fin` time DEFAULT NULL,
  `Statut` int(1) DEFAULT 0,
  PRIMARY KEY (`Id_Reunion`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reunion`
--

LOCK TABLES `reunion` WRITE;
/*!40000 ALTER TABLE `reunion` DISABLE KEYS */;
INSERT INTO `reunion` VALUES
(1,20,'Salle ABC',101,'09:00:00','11:00:00',1),
(2,30,'Salle DEF',102,'14:00:00','16:00:00',1),
(3,10,'Salle GHI',103,'08:00:00','10:00:00',0);
/*!40000 ALTER TABLE `reunion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `role` (
  `Id_Role` int(11) NOT NULL AUTO_INCREMENT,
  `Id_Utilisateur` int(11) NOT NULL,
  `isUser` tinyint(1) DEFAULT 0,
  `isAdmin` tinyint(1) DEFAULT 0,
  `isRh` tinyint(1) DEFAULT 0,
  `IsInfo` tinyint(1) DEFAULT 0,
  `IsPaie` tinyint(1) DEFAULT 0,
  `IsReunion` tinyint(1) DEFAULT 0,
  `IsVehicule` tinyint(1) DEFAULT 0,
  `isService` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`Id_Role`),
  KEY `Id_Utilisateur` (`Id_Utilisateur`),
  CONSTRAINT `role_ibfk_1` FOREIGN KEY (`Id_Utilisateur`) REFERENCES `utilisateur` (`Id_Utilisateur`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES
(1,1,1,0,0,1,0,0,0,0),
(2,2,1,0,0,0,1,0,0,1),
(3,3,0,1,0,0,0,0,0,0),
(4,4,1,0,0,0,0,0,1,0),
(7,11,1,0,0,0,0,0,0,0);
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `services` (
  `Id_Service` int(11) NOT NULL AUTO_INCREMENT,
  `Type_service` int(1) NOT NULL,
  `Tel_service` int(11) DEFAULT NULL,
  `Email_service` varchar(50) DEFAULT NULL,
  `name_service` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_Service`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `services`
--

LOCK TABLES `services` WRITE;
/*!40000 ALTER TABLE `services` DISABLE KEYS */;
INSERT INTO `services` VALUES
(1,1,145891234,'rh@entreprise.com','RH'),
(2,2,145895678,'paie@entreprise.com','Paie'),
(3,3,145899999,'it@entreprise.com','IT');
/*!40000 ALTER TABLE `services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `utilisateur` (
  `Id_Utilisateur` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) DEFAULT NULL,
  `Prenom` varchar(50) DEFAULT NULL,
  `Date_de_naissance` date DEFAULT NULL,
  `Numero` int(11) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Mot_de_passe` varchar(50) DEFAULT NULL,
  `Adresse` varchar(50) DEFAULT NULL,
  `Zip` int(11) DEFAULT NULL,
  `Ville` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id_Utilisateur`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utilisateur`
--

LOCK TABLES `utilisateur` WRITE;
/*!40000 ALTER TABLE `utilisateur` DISABLE KEYS */;
INSERT INTO `utilisateur` VALUES
(1,'Ploquin','Juliann','1985-03-12',123456789,'juliann','123','1 Rue Principale',75001,'Paris'),
(2,'Rouge','Ludo','1990-07-05',987654321,'ludo','123','12 Avenue Victor Hugo',69002,'Lyon'),
(3,'Le Morvan Idrac','Colombe','1978-11-23',112233445,'colombe','123','5 Boulevard Gambetta',33000,'Bordeaux'),
(4,'Titou','Onthetrack','1992-06-14',556677889,'titou','123','10 Avenue Pasteur',59000,'Lille'),
(5,'uoih','uih','2025-01-27',6564654,'uiukhuig','huighuig','hb',15661,'hjk'),
(6,'benji','coutier','2004-06-16',668149759,'benjcout@gmail.com','123','11 rue de gueville',78125,'gazeran'),
(7,'benji','ugheuhugi','2025-01-29',1541451451,'fefe@gefge.fe','123','fezf',18415,'fefsf'),
(8,'uiufeuufi','oifjeioj','2025-01-01',1561451691,'fesf@fesf.efcsd','123','11 rue su jeu de paume',15616,'saihville'),
(9,'gyuyu','gyuyugyu','2025-01-27',215614986,'fesfesf','123','dzqdq',1561,'fefsfes'),
(10,'vbygvyuvuvu','pkf,krjfkj','2025-01-27',1561561961,'fesfes','123','fesf',12315,'feesfes'),
(11,'hubhbhibh','hbhbhj','2025-01-27',2156156,'fefesf','123fe','fesf',12395,'fesfs');
/*!40000 ALTER TABLE `utilisateur` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicule`
--

DROP TABLE IF EXISTS `vehicule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehicule` (
  `Id_Vehicule` int(11) NOT NULL AUTO_INCREMENT,
  `Marque` varchar(50) DEFAULT NULL,
  `Modele` varchar(50) DEFAULT NULL,
  `Statut` int(1) DEFAULT 0,
  `Nb_place` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_Vehicule`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicule`
--

LOCK TABLES `vehicule` WRITE;
/*!40000 ALTER TABLE `vehicule` DISABLE KEYS */;
INSERT INTO `vehicule` VALUES
(1,'Peugeot','308',1,5),
(2,'Renault','Clio',1,4),
(3,'Tesla','Model 3',0,5);
/*!40000 ALTER TABLE `vehicule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'rel'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-03-04  9:53:00
