/*
MySQL Backup
Source Host:           
Source Server Version: 5.5.5-10.4.22-MariaDB
Source Database:       projeto_db
Date:                  2022/04/05 23:04:00
*/

SET FOREIGN_KEY_CHECKS=0;
use projeto_db;
#----------------------------
# Table structure for cliente
#----------------------------
CREATE TABLE `cliente` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(250) NOT NULL,
  `rg` varchar(10) DEFAULT NULL,
  `CPFCNPJ` varchar(11) DEFAULT NULL,
  `DtNasc` date DEFAULT NULL,
  `endereco` varchar(255) DEFAULT NULL,
  `numEndereco` varchar(5) DEFAULT NULL,
  `bairro` varchar(250) DEFAULT NULL,
  `DtRegistro` date NOT NULL,
  `tipo` char(1) NOT NULL DEFAULT 'F',
  `ativo` char(1) NOT NULL DEFAULT 'S',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
#----------------------------
# Records for table cliente
#----------------------------


insert  into cliente values 
(1, 'AO CONSUMIDOR', '', '', null, '', '', '', '2022-03-28', 'F', 'S'), 
(2, 'BBBBBBBBBBBBBBBBBBB', '', '', null, '', '', '', '2022-03-28', 'F', 'S'), 
(3, 'CCCCCCCCCCCC', '', '', null, '', '', '', '2022-03-28', 'F', 'S');
#----------------------------
# Table structure for clientedelphi
#----------------------------
CREATE TABLE `clientedelphi` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `data_nasc` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
#----------------------------
# Records for table clientedelphi
#----------------------------


insert  into clientedelphi values 
(1, 'mayke', '2000-01-01'), 
(2, 'cleyton', '1999-02-01'), 
(3, 'qualquer', '1997-03-02'), 
(4, 'hercules', '2004-04-04'), 
(5, 'samuel', '2019-04-01'), 
(6, 'guilherme', null);
#----------------------------
# Table structure for conta
#----------------------------
CREATE TABLE `conta` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(70) NOT NULL,
  `ativo` char(1) NOT NULL DEFAULT 'S',
  `banco` char(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
#----------------------------
# No records for table conta
#----------------------------

#----------------------------
# Table structure for fornecedor
#----------------------------
CREATE TABLE `fornecedor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) NOT NULL,
  `ie` varchar(14) DEFAULT NULL,
  `CNPJ` varchar(14) DEFAULT NULL,
  `endereco` varchar(250) DEFAULT NULL,
  `numEndereco` varchar(6) DEFAULT NULL,
  `bairro` varchar(250) DEFAULT NULL,
  `dtRegistro` date NOT NULL,
  `ativo` char(1) NOT NULL DEFAULT 'S',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
#----------------------------
# Records for table fornecedor
#----------------------------


insert  into fornecedor values 
(1, 'AAAAAAAAAAA', '', '', '', '', '', '2022-04-03', 'S'), 
(2, 'BBBBBBBBBB', '', '', '', '', '', '2022-04-03', 'S'), 
(3, 'ABC', '', '', '', '', '', '2022-04-03', 'N'), 
(4, 'QUALQUER', '', '', '', '', '', '2022-04-03', 'S'), 
(5, 'MSI CELL', '11111', '', 'QUALQUER COISA', '16', 'aiaiaiai', '2022-04-03', 'S'), 
(6, 'SHEILA', '1', '00000000/00000', '1', '1', '1', '2022-04-04', 'N');
#----------------------------
# Table structure for funcionario
#----------------------------
CREATE TABLE `funcionario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) NOT NULL,
  `rg` varchar(10) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `DtNasc` date NOT NULL,
  `endereco` varchar(250) DEFAULT NULL,
  `numEndereco` varchar(5) DEFAULT NULL,
  `bairro` varchar(250) DEFAULT NULL,
  `DtRegistro` date NOT NULL,
  `grupo_usu` int(11) NOT NULL,
  `login` varchar(80) DEFAULT NULL,
  `senha` varchar(50) DEFAULT NULL,
  `ativo` char(1) NOT NULL DEFAULT 'S',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
#----------------------------
# Records for table funcionario
#----------------------------


insert  into funcionario values 
(1, 'AM SYSTEM', '', '', '2022-03-31', '', '', '', '2022-03-31', 1, '1', '1', 'S'), 
(3, 'DIOGO FILIPE FERNANDES', '437976245', '06915798811', '1943-04-01', 'RUA DAS TAMAREIRAS', '353', 'JARDIM MARINGÁ', '2022-03-31', 0, '2', '2', 'S'), 
(4, 'SUELI FERNANDA APARÍCIO', '173444696', '66330654697', '1979-01-07', '', '', '', '2022-04-01', 1, '3', '3', 'S');
#----------------------------
# Table structure for grupo_produto
#----------------------------
CREATE TABLE `grupo_produto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(255) NOT NULL,
  `ativo` char(1) NOT NULL DEFAULT 'S',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
#----------------------------
# Records for table grupo_produto
#----------------------------


insert  into grupo_produto values 
(1, '', 'S'), 
(2, 'BEBIDAS', 'S'), 
(3, 'qualquer', 'S');
#----------------------------
# Table structure for grupo_usuario
#----------------------------
CREATE TABLE `grupo_usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(70) NOT NULL,
  `ativo` varchar(1) NOT NULL DEFAULT 'S',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
#----------------------------
# Records for table grupo_usuario
#----------------------------


insert  into grupo_usuario values 
(1, 'ADMINISTRADOR', 'S');
#----------------------------
# Table structure for produto
#----------------------------
CREATE TABLE `produto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(255) NOT NULL,
  `unidade` char(5) DEFAULT NULL,
  `estoque` decimal(5,3) DEFAULT NULL,
  `pCompra` decimal(5,2) DEFAULT NULL,
  `pLucro` decimal(5,2) DEFAULT NULL,
  `pVenda` decimal(5,2) NOT NULL,
  `grupo` varchar(70) DEFAULT NULL,
  `dtRegistro` date NOT NULL,
  `ativo` char(1) NOT NULL DEFAULT 'S',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
#----------------------------
# Records for table produto
#----------------------------


insert  into produto values 
(1, 'arroz', 'un', '10.000', '10.00', '10.00', '11.00', 'qualquer', '2022-03-27', 'S'), 
(2, 'arroz doido', 'un', '15.000', '10.00', '100.00', '20.00', 'qualquer', '2022-03-27', 'S');
#----------------------------
# Table structure for venda
#----------------------------
CREATE TABLE `venda` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` int(11) NOT NULL,
  `cliente` varchar(250) NOT NULL,
  `valor` decimal(6,2) NOT NULL,
  `desconto` decimal(6,2) NOT NULL,
  `valor_total` decimal(6,2) NOT NULL,
  `pago` decimal(6,2) NOT NULL,
  `data_venda` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
#----------------------------
# Records for table venda
#----------------------------


insert  into venda values 
(1, 0, '', '0.00', '0.00', '0.00', '0.00', '0000-00-00'), 
(2, 0, '', '0.00', '0.00', '0.00', '0.00', '0000-00-00'), 
(3, 0, '', '0.00', '0.00', '0.00', '0.00', '0000-00-00'), 
(4, 0, '', '0.00', '0.00', '0.00', '0.00', '0000-00-00'), 
(5, 0, '', '0.00', '0.00', '0.00', '0.00', '0000-00-00'), 
(6, 0, '', '0.00', '0.00', '0.00', '0.00', '0000-00-00');
#----------------------------
# Table structure for venda_item
#----------------------------
CREATE TABLE `venda_item` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idVenda` int(11) NOT NULL,
  `idProd` int(11) NOT NULL,
  `descricao` varchar(255) NOT NULL,
  `quantidade` decimal(5,3) NOT NULL,
  `valor` decimal(5,2) NOT NULL,
  `desconto` decimal(5,2) NOT NULL,
  `total` decimal(5,2) NOT NULL,
  `ex` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
#----------------------------
# Records for table venda_item
#----------------------------


insert  into venda_item values 
(1, 1, 1, 'ARROZ', '1.000', '11.00', '0.00', '11.00', 0), 
(2, 2, 1, 'ARROZ', '1.000', '11.00', '0.00', '11.00', 0), 
(4, 4, 1, 'ARROZ', '1.000', '11.00', '0.00', '11.00', 0), 
(5, 5, 1, 'ARROZ', '1.000', '11.00', '0.00', '11.00', 1), 
(6, 6, 1, 'ARROZ', '1.000', '11.00', '0.00', '11.00', 1);

