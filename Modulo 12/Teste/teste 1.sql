-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Bibliomania
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Bibliomania
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Bibliomania` DEFAULT CHARACTER SET utf8 ;
USE `Bibliomania` ;

-- -----------------------------------------------------
-- Table `Bibliomania`.`Clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliomania`.`Clientes` (
  `id` INT NOT NULL,
  `Nome` VARCHAR(100) NOT NULL,
  `Morada` VARCHAR(100) NOT NULL,
  `Email` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliomania`.`Autores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliomania`.`Autores` (
  `CodAutor` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(100) NOT NULL,
  `Nacionalidade` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`CodAutor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliomania`.`Livros`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliomania`.`Livros` (
  `ISBN` VARCHAR(13) NOT NULL,
  `Ttitulo` VARCHAR(100) NOT NULL,
  `Genero` VARCHAR(100) NOT NULL,
  `CodAutor` INT NOT NULL,
  PRIMARY KEY (`ISBN`),
  INDEX `fk_Bibliomania_Livros_idx` (`CodAutor` ASC) ,
  CONSTRAINT `fk_Bibliomania_Livros`
    FOREIGN KEY (`CodAutor`)
    REFERENCES `Bibliomania`.`Autores` (`CodAutor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Bibliomania`.`Vendas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Bibliomania`.`Vendas` (
  `NVenda` INT NOT NULL AUTO_INCREMENT,
  `DataVenda` DATE NOT NULL,
  `id-cliente` INT NOT NULL,
  `ISBN` VARCHAR(13) NOT NULL,
  `Quantidade` INT NOT NULL,
  `PrecoUnitario` DECIMAL(10) NOT NULL,
  PRIMARY KEY (`NVenda`),
  INDEX `fk_Bibliomania_Vendas_idx1` (`id-cliente` ASC) ,
  INDEX `fk_Bibliomania_Vendas_idx` (`ISBN` ASC) ,
  CONSTRAINT `fk_Vendas`
    FOREIGN KEY (`ISBN`)
    REFERENCES `Bibliomania`.`Livros` (`ISBN`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Bibliomania_Vendas`
    FOREIGN KEY (`id-cliente`)
    REFERENCES `Bibliomania`.`Clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

UPDATE `bibliomania`.`autores` SET `Nome` = 'José Saramago ', `Nacionalidade` = 'Portugal' WHERE (`CodAutor` = '1');
UPDATE `bibliomania`.`autores` SET `Nome` = 'Jane Austen ', `Nacionalidade` = 'Reino Unido' WHERE (`CodAutor` = '2');


INSERT INTO `bibliomania`.`clientes` (`Nome`, `Morada`, `Email`) VALUES ('Ana Silva ', 'Rua A, Lisboa ', 'ana@email.com');
INSERT INTO `bibliomania`.`clientes` (`Nome`, `Morada`, `Email`) VALUES ('Pedro Lopes ', 'Av. B, Porto ', 'pedro@email.com');



INSERT INTO `bibliomania`.`livros` (`ISBN`, `Ttitulo`, `Genero`, `CodAutor`) VALUES ('9789720041162 ', 'Ensaio sobre a Cegueira ', 'Ficção', '1');
INSERT INTO `bibliomania`.`livros` (`ISBN`, `Ttitulo`, `Genero`, `CodAutor`) VALUES ('9788535917419', 'Orgulho e Preconceito ', 'Romance', '2');



INSERT INTO `bibliomania`.`vendas` (`NVenda`, `DataVenda`, `id-cliente`, `ISBN`, `Quantidade`, `PrecoUnitario`) VALUES ('', '2023-10-05', '1', '9789720041162', '2', '19,99');
INSERT INTO `bibliomania`.`vendas` (`DataVenda`, `id-cliente`, `ISBN`, `Quantidade`, `PrecoUnitario`) VALUES ('2023-10-06', '2', '9788535917419', '1', '15,50');
