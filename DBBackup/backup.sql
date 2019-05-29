-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           8.0.16 - MySQL Community Server - GPL
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              10.1.0.5464
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para teste
CREATE DATABASE IF NOT EXISTS `teste` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `teste`;

-- Copiando estrutura para tabela teste.enderecos
CREATE TABLE IF NOT EXISTS `enderecos` (
  `ID` varchar(255) NOT NULL,
  `Rua` varchar(255) NOT NULL,
  `Nome` varchar(255) NOT NULL,
  `Bairro` varchar(255) NOT NULL,
  `Cidade` varchar(255) NOT NULL,
  `Estado` varchar(255) NOT NULL,
  `Numero` varchar(255) NOT NULL,
  `CEP` varchar(255) NOT NULL,
  `Complemento` varchar(255) NOT NULL,
  `UserID` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IdUser` (`UserID`),
  CONSTRAINT `enderecos_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela teste.enderecos: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `enderecos` DISABLE KEYS */;
INSERT INTO `enderecos` (`ID`, `Rua`, `Nome`, `Bairro`, `Cidade`, `Estado`, `Numero`, `CEP`, `Complemento`, `UserID`) VALUES
	('08d6d41c-2ce7-d8a1-58f9-f124d088bf27', 'rua das praias', 'Cada da praia', 'Praia', 'Santos', 'SP', '20', '12345678', '', '08d6d367-d174-bb2d-cabb-b36f2cffe866'),
	('08d6d424-83f9-5bd2-afc8-80c9e0fd65f0', 'rua das praias', 'Cada da praia', 'Grande coisas', 'Itu', 'SP', '20', '12345678', '', '08d6d360-2641-1bc7-0501-cf00e4a9cde8'),
	('08d6d42b-c783-55b6-02c7-e45ada1a5283', 'rua das praias', 'Cada da praia', 'Grande coisas', 'Ipanema', 'SP', '20', '12345678', '', '08d6d360-2641-1bc7-0501-cf00e4a9cde8'),
	('08d6d4ed-f24b-cb05-bb43-026241d67fb1', 'rua das praias', 'Cada da praia', 'Grande coisas', 'Ipanema', 'SP', '20', '12345678', '', '08d6d360-2641-1bc7-0501-cf00e4a9cde8');
/*!40000 ALTER TABLE `enderecos` ENABLE KEYS */;

-- Copiando estrutura para tabela teste.pedidos
CREATE TABLE IF NOT EXISTS `pedidos` (
  `ID` varchar(255) NOT NULL,
  `Valor` double NOT NULL,
  `Data` datetime NOT NULL,
  `Descricao` varchar(255) NOT NULL,
  `Status` varchar(50) NOT NULL,
  `ProdutoID` varchar(255) NOT NULL,
  `UserID` varchar(255) NOT NULL,
  `EnderecoID` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IdUser` (`UserID`),
  KEY `produtos_ibfk_1` (`ProdutoID`),
  KEY `enderecos_ibfk_2` (`EnderecoID`),
  CONSTRAINT `enderecos_ibfk_2` FOREIGN KEY (`EnderecoID`) REFERENCES `enderecos` (`ID`),
  CONSTRAINT `produtos_ibfk_1` FOREIGN KEY (`ProdutoID`) REFERENCES `produtos` (`ID`),
  CONSTRAINT `users_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela teste.pedidos: ~8 rows (aproximadamente)
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
INSERT INTO `pedidos` (`ID`, `Valor`, `Data`, `Descricao`, `Status`, `ProdutoID`, `UserID`, `EnderecoID`) VALUES
	('08d6d4eb-40d9-d7e3-5174-3dfd31d0e277', 500, '2019-05-03 00:00:00', 'Solicitação de Fogão', 'Em analise', '08d6d4e3-e065-f04c-6644-f233c48e88c7', '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '08d6d42b-c783-55b6-02c7-e45ada1a5283'),
	('08d6d4fc-5e9d-4569-324c-c91f041f00bd', 500, '2019-05-03 00:00:00', 'Solicitação de Fogão', 'Em analise', '08d6d4e3-e065-f04c-6644-f233c48e88c7', '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '08d6d42b-c783-55b6-02c7-e45ada1a5283'),
	('08d6d4fc-6b88-43b0-545a-d4e24c50955a', 500, '2019-05-03 00:00:00', 'Solicitação de Fogão', 'Em analise', '08d6d4e3-e065-f04c-6644-f233c48e88c7', '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '08d6d42b-c783-55b6-02c7-e45ada1a5283'),
	('08d6d4fc-7304-8288-a1fb-795b453fa101', 500, '2019-05-03 00:00:00', 'Solicitação de Fogão', 'Em analise', '08d6d4e3-e065-f04c-6644-f233c48e88c7', '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '08d6d42b-c783-55b6-02c7-e45ada1a5283'),
	('08d6d4fc-ca41-5e98-6754-665a5cb008f7', 500, '2019-05-03 00:00:00', 'Solicitação de Fogão', 'Em analise', '08d6d4e3-e065-f04c-6644-f233c48e88c7', '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '08d6d42b-c783-55b6-02c7-e45ada1a5283'),
	('08d6d4fd-54f0-2d79-f3ed-1d747cdc2f9c', 100, '2019-05-03 00:00:00', 'Solicitação de Fogão', 'Em analise', '08d6d4e3-e065-f04c-6644-f233c48e88c7', '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '08d6d42b-c783-55b6-02c7-e45ada1a5283'),
	('08d6d500-8b5c-66ce-d35c-fa70d214ba73', 100, '2019-05-03 00:00:00', 'Solicitação de Fogão', 'Em analise', '08d6d4e3-e065-f04c-6644-f233c48e88c7', '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '08d6d42b-c783-55b6-02c7-e45ada1a5283'),
	('08d6d500-bd07-e4ce-6068-07b24e7e9b4a', -100, '2019-05-03 00:00:00', 'Solicitação de Fogão', 'Em analise', '08d6d4e3-e065-f04c-6644-f233c48e88c7', '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '08d6d42b-c783-55b6-02c7-e45ada1a5283');
/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;

-- Copiando estrutura para tabela teste.pontos
CREATE TABLE IF NOT EXISTS `pontos` (
  `ID` varchar(255) NOT NULL,
  `Valor` double NOT NULL,
  `UserID` varchar(255) NOT NULL,
  `Data` datetime NOT NULL,
  `Descricao` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IdUser` (`UserID`),
  CONSTRAINT `pontos_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela teste.pontos: ~7 rows (aproximadamente)
/*!40000 ALTER TABLE `pontos` DISABLE KEYS */;
INSERT INTO `pontos` (`ID`, `Valor`, `UserID`, `Data`, `Descricao`) VALUES
	('08d6d42d-d7d5-f78c-f0cd-7b1d83df8722', 1000, '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '2019-05-01 00:00:00', 'Compra no Ponto Frio - Geladeira'),
	('08d6d4de-1997-c038-472b-9387650e0c0f', 100, '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '2019-04-03 02:00:00', 'Compra no Extra - Fogão'),
	('08d6d4ea-830d-59a2-4d93-cba58508b3ca', 100, '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '2019-05-04 01:00:00', 'Compra na Amazon'),
	('08d6d4fc-be96-ff17-737f-fb0e02cfa258', 500, '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '2019-04-01 20:00:00', 'Compra no Ponto frio - Batedeira'),
	('08d6d4fd-3170-2842-7f88-9a137861c676', 100, '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '2019-05-03 00:00:00', 'Compra no Extra - Fogão'),
	('08d6d500-82e3-1051-9004-cd4339fdeb9d', 100, '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '2019-02-03 00:00:00', 'Compra no Ponto Frio - Geladeira'),
	('08d6d500-bd01-3b90-6622-174add45dff3', -100, '08d6d360-2641-1bc7-0501-cf00e4a9cde8', '2019-05-03 00:00:00', 'Solicitação de Resgate - Fone');
/*!40000 ALTER TABLE `pontos` ENABLE KEYS */;

-- Copiando estrutura para tabela teste.produtos
CREATE TABLE IF NOT EXISTS `produtos` (
  `ID` varchar(255) NOT NULL,
  `Valor` double NOT NULL,
  `Status` varchar(50) NOT NULL,
  `Descricao` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela teste.produtos: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` (`ID`, `Valor`, `Status`, `Descricao`) VALUES
	('08d6d4e3-d38d-0011-8615-5d67e7d42097', 100, 'Disponivel', 'Fogão'),
	('08d6d4e3-e065-f04c-6644-f233c48e88c7', 3000, 'Disponivel', 'Geladeira'),
	('08d6d4fb-a437-0a43-a92f-5172efb27f35', 3000, 'Disponivel', 'Torradeira');
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;

-- Copiando estrutura para tabela teste.users
CREATE TABLE IF NOT EXISTS `users` (
  `ID` varchar(255) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Pontos` double NOT NULL,
  `AccessKey` varchar(50) NOT NULL,
  `Cpf` varchar(50) NOT NULL,
  `Perfil` varchar(50) NOT NULL,
  `Nome` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela teste.users: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`ID`, `Email`, `Pontos`, `AccessKey`, `Cpf`, `Perfil`, `Nome`) VALUES
	('08d6d360-2641-1bc7-0501-cf00e4a9cde8', 'teste@gmail.com', 100, 'teste123', '98765432112', 'Adm', 'teste'),
	('08d6d367-d174-bb2d-cabb-b36f2cffe866', 'outro@gmail.com', 0, 'teste123', '98765432112', 'Adm', 'teste'),
	('08d6d430-87f4-a7f8-b303-7007b471f7a4', 'maisum@gmail.com', 300, 'teste123', '98765432112', 'Adm', 'teste'),
	('08d6d500-6e88-1444-0a65-490aa5473390', 'maisdois@gmail.com', 300, 'teste123', '98765432112', 'Adm', 'teste');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
