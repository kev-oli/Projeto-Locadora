CREATE DATABASE  IF NOT EXISTS `locadora_2dsiem_2021` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `locadora_2dsiem_2021`;
-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: locadora_2dsiem_2021
-- ------------------------------------------------------
-- Server version	8.0.26

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
-- Table structure for table `tb_automovel`
--

DROP TABLE IF EXISTS `tb_automovel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_automovel` (
  `TB_AUTOMOVEL_ID` int NOT NULL AUTO_INCREMENT,
  `TB_AUTOMOVEL_NOME` varchar(32) NOT NULL,
  `TB_AUTOMOVEL_ANO_FAB` int DEFAULT NULL,
  `TB_AUTOMOVEL_COR` varchar(32) NOT NULL,
  `TB_AUTOMOVEL_KM` decimal(10,2) DEFAULT NULL,
  `TB_AUTOMOVEL_VALOR_D` decimal(10,2) DEFAULT NULL,
  `TB_AUTOMOVEL_STATUS` varchar(16) DEFAULT NULL,
  `TB_MARCA_ID` int NOT NULL,
  `TB_MODELO_ID` int NOT NULL,
  PRIMARY KEY (`TB_AUTOMOVEL_ID`),
  KEY `automovel_fk_marca_pk` (`TB_MARCA_ID`),
  KEY `automovel_fk_modelo_pk` (`TB_MODELO_ID`),
  CONSTRAINT `automovel_fk_marca_pk` FOREIGN KEY (`TB_MARCA_ID`) REFERENCES `tb_marca` (`TB_MARCA_ID`),
  CONSTRAINT `automovel_fk_modelo_pk` FOREIGN KEY (`TB_MODELO_ID`) REFERENCES `tb_modelo` (`TB_MODELO_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_automovel`
--

LOCK TABLES `tb_automovel` WRITE;
/*!40000 ALTER TABLE `tb_automovel` DISABLE KEYS */;
INSERT INTO `tb_automovel` VALUES (1,'CIVIC EXS',2010,'PRETO',60000.00,550.00,'DISPONÍVEL',2,2),(2,'GOL MI',2000,'PRETO',75000.00,100.00,'INDISPONÍVEL',7,6),(3,'LANCER',2014,'VERMELHO',23000.00,160.00,'DISPONÍVEL',9,2),(4,'PALIO ELX',2001,'CINZA',140000.00,90.00,'INDISPONÍVEL',3,6),(5,'FLUENCE ELITE',2015,'BRANCO',95000.00,130.00,'DISPONÍVEL',12,2),(6,'COROLLA XEI',2011,'BRANCO',150000.00,140.00,'DISPONÍVEL',13,2),(7,'JETTA TSI',2016,'PRATA',102000.00,150.00,'DISPONÍVEL',7,2),(8,'HB20',2011,'AZUL',98000.00,120.00,'INDISPONÍVEL',10,6),(9,'FIESTA',2012,'VERMELHO',120000.00,130.00,'DISPONÍVEL',4,6),(10,'AMAROK',2014,'VERDE',NULL,1400.00,'DISPONÍVEL',7,3),(11,'HB20',2015,'VERMELHO',NULL,120.00,'INDISPONÍVEL',10,6),(12,'CITY',2011,'PRETO',78000.00,130.00,'DISPONÍVEL',2,2),(13,'FIT',2014,'PRETO',NULL,120.00,'INDISPONÍVEL',2,6),(14,'RANGER XLT',2018,'BRANCO',35000.00,2000.00,'DISPONÍVEL',4,3),(15,'CIVIC TOURING',2018,'PRETO',59000.00,1800.00,'DISPONÍVEL',2,7);
/*!40000 ALTER TABLE `tb_automovel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cargo`
--

DROP TABLE IF EXISTS `tb_cargo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_cargo` (
  `TB_CARGO_ID` int NOT NULL AUTO_INCREMENT,
  `TB_CARGO_NOME` varchar(64) NOT NULL,
  PRIMARY KEY (`TB_CARGO_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cargo`
--

LOCK TABLES `tb_cargo` WRITE;
/*!40000 ALTER TABLE `tb_cargo` DISABLE KEYS */;
INSERT INTO `tb_cargo` VALUES (1,'LAVADOR'),(2,'LOCADOR'),(3,'MECANICO'),(4,'MANOBRISTA'),(5,'GERENTE');
/*!40000 ALTER TABLE `tb_cargo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cliente`
--

DROP TABLE IF EXISTS `tb_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_cliente` (
  `TB_CLIENTE_ID` int NOT NULL AUTO_INCREMENT,
  `TB_CLIENTE_NOME` varchar(128) NOT NULL,
  `TB_CLIENTE_TEL` varchar(16) NOT NULL,
  `TB_CLIENTE_SEXO` varchar(16) DEFAULT NULL,
  `TB_CLIENTE_EMAIL` varchar(32) DEFAULT NULL,
  `TB_CLIENTE_SENHA` varchar(32) DEFAULT NULL,
  `TB_CLIENTE_ENDERECO` varchar(64) NOT NULL,
  `TB_CLIENTE_COMPLEMENTO` varchar(32) DEFAULT NULL,
  `TB_CLIENTE_BAIRRO` varchar(64) NOT NULL,
  `TB_CLIENTE_CIDADE` varchar(64) NOT NULL,
  `TB_CLIENTE_UF` char(2) NOT NULL,
  `TB_CLIENTE_DT_NASC` date NOT NULL,
  `TB_CLIENTE_DT_CAD` date NOT NULL,
  PRIMARY KEY (`TB_CLIENTE_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cliente`
--

LOCK TABLES `tb_cliente` WRITE;
/*!40000 ALTER TABLE `tb_cliente` DISABLE KEYS */;
INSERT INTO `tb_cliente` VALUES (1,'ANDRE LINARES','11 971551446','MASCULINO','ANDRELINARESS@HOTMAIL.COM','123','AV. DOUTOR ALVARO RIBEIRO 777','apartamento 3','JARDIM DEGHI','SANTANA DE PARNAIBA','SP','1979-12-19','2010-10-10'),(2,'SILDO MENEZES','11 95443921','MASCULINO','SILDMSILDO@GMAIL.COM','123','RUA DAS CASAS 324','','PARQUE SANTANA','SANTANA DE PARNAIBA','SP','1985-10-10','2010-10-10'),(3,'MARIA DAS GRAÇAS','13 98453321','FEMININO','MARIA2000@HOTMAIL.COM','123','RUA FLORENCIA 4566','CASA B','CARAVAGIO','SÃO ROQUE','SP','2010-05-30','2010-10-10'),(4,'ROMEU ANTONI BASTOS','18 45334545','MASCULINO','ROMEU_ANTONIO@HOTMAIL.COM','123','AV. BARONESA 34','FUNDOS','HORTENCIA','TIRADENTES','MG','1970-07-22','2010-10-10'),(5,'JOAQUIM DE OLIVEIRA ASSIS','18 94332929','MASCULINO','JOAQUIM_OLIVER@YAHOO.COM.BR','123','AV. DO ESTADO, 3422','4 ANDAR','VITORIA RÉGIA','TIRADENTES','MG','2009-09-09','2010-10-10'),(6,'ROGERIO FARIAS DE MELO','22 6550303','MASCULINO','FARIAS_MELO@HOTMAIL.COM','123','RUA PATRIARCA, 342','','ROCHEDO','MONTE ALTO','BA','1980-10-23','2010-06-04'),(7,'PAULA DA SILVA VIEIRA','22 94330202','FEMININO','PAULINHA2000@YAHOO.COM.BR','123','RUA BARONESA, 4300','','JEQUITIBÁ','CANOAS','PR','1994-03-12','2010-06-04'),(9,'EVANDRO DA SILVA POTIGUAR','11 43564654','MASCULINO','POTIGUAR2011@GMAIL.COM','123','AV. FLOR DO CAMPO, 344','CASA B','ESTRELA AZUL','CARAVELA','GO','1980-09-05','2015-07-18'),(10,'ALEXANDRE MARQUES GRANADO','34 43556767','MASCULINO','GRANADO_ALEXANDRE@HOTMAIL.COM','123','AV. DAS NAÇÕES UNIDAS, 3231','BLOCO C','CENTRO','SÃO PAULO','SP','1980-12-04','2011-08-01'),(11,'ANDRE VIEIRA','11 43445677','MASCULINO','ANDREANDRE@OUTLOOK.COM','123','RUA DO BARRÃO, 2345','FUNDO','GARÇA','SANTANA DE PARNAIBA','SP','2000-09-04','2016-09-29');
/*!40000 ALTER TABLE `tb_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_funcionario`
--

DROP TABLE IF EXISTS `tb_funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_funcionario` (
  `TB_FUNCIONARIO_ID` int NOT NULL AUTO_INCREMENT,
  `TB_FUNCIONARIO_NOME` varchar(64) NOT NULL,
  `TB_FUNCIONARIO_TEL` varchar(16) DEFAULT NULL,
  `TB_FUNCIONARIO_DT_CONTRATO` date NOT NULL,
  `TB_CARGO_ID` int NOT NULL,
  PRIMARY KEY (`TB_FUNCIONARIO_ID`),
  KEY `FUNCIONARIO_FK_CARGO_PK` (`TB_CARGO_ID`),
  CONSTRAINT `FUNCIONARIO_FK_CARGO_PK` FOREIGN KEY (`TB_CARGO_ID`) REFERENCES `tb_cargo` (`TB_CARGO_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_funcionario`
--

LOCK TABLES `tb_funcionario` WRITE;
/*!40000 ALTER TABLE `tb_funcionario` DISABLE KEYS */;
INSERT INTO `tb_funcionario` VALUES (1,'JOSÉ BENEDITO','11 94553838','2010-12-20',5),(2,'ANTONIO BONILHA','12 3943939','2011-01-05',2),(3,'LUIZA PEREIRA DA SILVA','11 93423445','2011-01-05',2),(4,'JOAQUIM OZORIO DOS REIS','18 4553434','2011-06-12',3),(5,'ANTONIO DIAS BASTOS','18 3403922','2010-10-10',3),(6,'ARMANDO ARAUJO DE ANDRADE','14 34233344','2012-06-21',2);
/*!40000 ALTER TABLE `tb_funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_locacao`
--

DROP TABLE IF EXISTS `tb_locacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_locacao` (
  `TB_LOCACAO_ID` int NOT NULL AUTO_INCREMENT,
  `TB_LOCACAO_TIPO` varchar(32) NOT NULL,
  `TB_LOCACAO_VALOR` decimal(10,2) NOT NULL,
  `TB_LOCACAO_DT_INICIO` date DEFAULT NULL,
  `TB_LOCACAO_DT_FIM` date DEFAULT NULL,
  `TB_CLIENTE_ID` int DEFAULT NULL,
  `TB_FUNCIONARIO_ID` int DEFAULT NULL,
  `TB_AUTOMOVEL_ID` int DEFAULT NULL,
  PRIMARY KEY (`TB_LOCACAO_ID`),
  KEY `locacao_fk_cliente_pk` (`TB_CLIENTE_ID`),
  KEY `locacao_fk_funcionario_pk` (`TB_FUNCIONARIO_ID`),
  KEY `locacao_fk_automovel_pk` (`TB_AUTOMOVEL_ID`),
  CONSTRAINT `locacao_fk_automovel_pk` FOREIGN KEY (`TB_AUTOMOVEL_ID`) REFERENCES `tb_automovel` (`TB_AUTOMOVEL_ID`),
  CONSTRAINT `locacao_fk_cliente_pk` FOREIGN KEY (`TB_CLIENTE_ID`) REFERENCES `tb_cliente` (`TB_CLIENTE_ID`),
  CONSTRAINT `locacao_fk_funcionario_pk` FOREIGN KEY (`TB_FUNCIONARIO_ID`) REFERENCES `tb_funcionario` (`TB_FUNCIONARIO_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_locacao`
--

LOCK TABLES `tb_locacao` WRITE;
/*!40000 ALTER TABLE `tb_locacao` DISABLE KEYS */;
INSERT INTO `tb_locacao` VALUES (1,'MENSAL',5400.00,'2016-06-05','2016-07-05',1,6,1),(2,'SEMANAL',910.00,'2016-06-05','2016-06-12',5,3,4),(3,'MENSAL',3900.00,'2016-06-05','2016-07-05',1,3,5),(4,'DIÁRIA',130.00,'2016-06-07','2016-06-08',6,2,9),(5,'MENSAL',4800.00,'2016-06-12','2016-07-12',6,2,3),(6,'MENSAL',4800.00,'2016-06-12','2016-07-12',10,2,6),(7,'SEMANAL',1120.00,'2016-09-20','2016-09-27',1,3,3),(8,'SEMANAL',980.00,'2016-10-10','2016-10-17',4,3,6);
/*!40000 ALTER TABLE `tb_locacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_marca`
--

DROP TABLE IF EXISTS `tb_marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_marca` (
  `TB_MARCA_ID` int NOT NULL AUTO_INCREMENT,
  `TB_MARCA_NOME` varchar(32) NOT NULL,
  PRIMARY KEY (`TB_MARCA_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_marca`
--

LOCK TABLES `tb_marca` WRITE;
/*!40000 ALTER TABLE `tb_marca` DISABLE KEYS */;
INSERT INTO `tb_marca` VALUES (1,'LIFAN'),(2,'HONDA'),(3,'FIAT'),(4,'FORD'),(5,'CHEVROLET'),(6,'JEEP'),(7,'VOLKSWAGEM'),(8,'KIA'),(9,'MITSUBISHI'),(10,'HYUNDAI'),(11,'BMW'),(12,'RENAULT'),(13,'TOYOTA'),(14,'AUDI'),(15,'BUGATTI'),(16,'FERRARI'),(17,'SUBARU'),(18,'ASTON MARTIN'),(19,'PORCHE');
/*!40000 ALTER TABLE `tb_marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_modelo`
--

DROP TABLE IF EXISTS `tb_modelo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_modelo` (
  `TB_MODELO_ID` int NOT NULL AUTO_INCREMENT,
  `TB_MODELO_DESC` varchar(32) NOT NULL,
  PRIMARY KEY (`TB_MODELO_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_modelo`
--

LOCK TABLES `tb_modelo` WRITE;
/*!40000 ALTER TABLE `tb_modelo` DISABLE KEYS */;
INSERT INTO `tb_modelo` VALUES (1,'RACING'),(2,'SEDAN'),(3,'PICKUP'),(4,'UTILITÁRIO'),(5,'WAGON'),(6,'HATCH'),(7,'COUPÊ'),(8,'SUV'),(9,'OFF ROAD');
/*!40000 ALTER TABLE `tb_modelo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-09-08 10:25:52

-- adicionando STATUS TB_CLIENTE
alter table tb_cliente
add column TB_CLIENTE_STATUS
varchar(20) default 'ATIVO';

-- adicionando STATUS TB_MARCA
alter table tb_marca
add column TB_MARCA_STATUS
varchar(20) default 'ATIVO';

-- adicionando STATUS TB_CARGO
alter table tb_cargo
add column TB_CARGO_STATUS
varchar(20) default 'ATIVO';

-- adicionando STATUS TB_MODELO
alter table tb_modelo
add column TB_MODELO_STATUS
varchar(20) default 'ATIVO';


-- adicionando STATUS TB_FUNCIONARIO
alter table tb_funcionario
add column TB_FUNCIONARIO_STATUS
varchar(20) default 'ATIVO';

-- adicionando STATUS TB_LOCACAO
alter table tb_locacao
add column TB_LOCACAO_STATUS
varchar(20) default 'ATIVO';


select * from tb_automovel;

select * from tb_funcionario;

select * from tb_funcionario where TB_FUNCIONARIO_STATUS = 'ATIVO';


SELECT * FROM locadora_2dsiem_2021.tb_locacao;

select tb_locacao.TB_LOCACAO_ID as 'ID DA LOCAÇÃO',
tb_locacao.TB_LOCACAO_TIPO as 'TIPO DE LOCAÇÃO',
tb_locacao.TB_LOCACAO_VALOR as 'VALOR',
tb_locacao.TB_LOCACAO_DT_INICIO as 'DATA DE INÍCIO',
tb_locacao.TB_LOCACAO_DT_FIM as 'DATA FINAL',
tb_cliente.TB_CLIENTE_NOME as 'CLIENTE',
tb_funcionario.TB_FUNCIONARIO_NOME as 'FUNCIONÁRIO',
tb_automovel.TB_AUTOMOVEL_NOME as 'AUTOMÓVEL',
tb_locacao.TB_LOCACAO_STATUS as 'STATUS'
from tb_locacao 
inner join tb_cliente on tb_locacao.TB_CLIENTE_ID = tb_cliente.TB_CLIENTE_ID
inner join tb_funcionario on tb_locacao.TB_FUNCIONARIO_ID = tb_funcionario.TB_FUNCIONARIO_ID
inner join tb_automovel on tb_locacao.TB_AUTOMOVEL_ID = tb_automovel.TB_AUTOMOVEL_ID where TB_LOCACAO_STATUS = 'ATIVO';
