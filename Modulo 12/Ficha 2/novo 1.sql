SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

CREATE SCHEMA IF NOT EXISTS `livraria` DEFAULT CHARACTER SET utf8;
USE `livraria`;

CREATE TABLE IF NOT EXISTS `autores` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `pais` VARCHAR(100) NOT NULL,
  `email` VARCHAR(100) NULL,
  PRIMARY KEY (`id`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `editores` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `cidade` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `livros` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(200) NOT NULL,
  `ano_public` DATE NULL DEFAULT NULL,
  `autor_id` INT(11) NULL,
  `editor_id` INT(11) NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_livro_editora_idx` (`editor_id`),
  INDEX `fk_livro_autor_idx` (`autor_id`),
  CONSTRAINT `fk_livro_autor`
    FOREIGN KEY (`autor_id`)
    REFERENCES `autores` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_livro_editora`
    FOREIGN KEY (`editor_id`)
    REFERENCES `editores` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8;
USE `mydb`;

CREATE TABLE IF NOT EXISTS `fornecedores` (
  `CodForn` INT(11) NOT NULL AUTO_INCREMENT,
  `Fornecedor` VARCHAR(100) NOT NULL,
  `Morada` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`CodForn`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `materiais` (
  `CodMat` INT(11) NOT NULL AUTO_INCREMENT,
  `Designacao` VARCHAR(100) NOT NULL,
  `CodForn` INT(11) NOT NULL,
  PRIMARY KEY (`CodMat`),
  CONSTRAINT `fk_materiais_fornecedores`
    FOREIGN KEY (`CodForn`)
    REFERENCES `fornecedores` (`CodForn`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `obras` (
  `NObras` INT(11) NOT NULL AUTO_INCREMENT,
  `Local` VARCHAR(100) NOT NULL,
  `Datainicio` DATE NOT NULL,
  `Orcamento` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (`NObras`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

CREATE TABLE IF NOT EXISTS `fornecimentos` (
  `NFornecim` INT(11) NOT NULL AUTO_INCREMENT,
  `NObra` INT(11) NOT NULL,
  `CodMat` INT(11) NOT NULL,
  `Preco` DECIMAL(10,2) NOT NULL,
  `Quant` INT(11) NOT NULL,
  PRIMARY KEY (`NFornecim`),
  CONSTRAINT `fk_fornecimentos_obras`
    FOREIGN KEY (`NObra`)
    REFERENCES `obras` (`NObras`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_fornecimentos_materiais`
    FOREIGN KEY (`CodMat`)
    REFERENCES `materiais` (`CodMat`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;














UPDATE `mydb`.`fornecedores` SET `Fornecedor` = 'Portas', `Morada` = 'Porto' WHERE (`CodForn` = '4');
UPDATE `mydb`.`fornecedores` SET `Fornecedor` = 'Casimiro', `Morada` = 'Coimbra' WHERE (`CodForn` = '3');
UPDATE `mydb`.`fornecedores` SET `Fornecedor` = 'Belmiro', `Morada` = 'Braga' WHERE (`CodForn` = '2');
UPDATE `mydb`.`fornecedores` SET `Fornecedor` = 'Anibal', `Morada` = 'Lisboa' WHERE (`CodForn` = '1');

UPDATE `mydb`.`fornecimentos` SET `NObra` = '3', `CodMat` = '3', `Preco` = '2', `Quant` = '80' WHERE (`NFornecim` = '4');
UPDATE `mydb`.`fornecimentos` SET `NObra` = '2', `CodMat` = '2', `Preco` = '5', `Quant` = '20' WHERE (`NFornecim` = '3');
UPDATE `mydb`.`fornecimentos` SET `NObra` = '2', `CodMat` = '1', `Preco` = '10', `Quant` = '50' WHERE (`NFornecim` = '2');
UPDATE `mydb`.`fornecimentos` SET `NObra` = '1', `CodMat` = '1', `Preco` = '10', `Quant` = '100' WHERE (`NFornecim` = '1');

UPDATE `mydb`.`materiais` SET `Designacao` = 'Tijolos', `CodForn` = '1' WHERE (`CodMat` = '1');
UPDATE `mydb`.`materiais` SET `Designacao` = 'Cimento', `CodForn` = '1' WHERE (`CodMat` = '2');
UPDATE `mydb`.`materiais` SET `Designacao` = 'Telhas', `CodForn` = '2' WHERE (`CodMat` = '3');
UPDATE `mydb`.`materiais` SET `Designacao` = 'Azuleijos', `CodForn` = '3' WHERE (`CodMat` = '4');

UPDATE `mydb`.`obras` SET `Local` = 'Lisboa', `Datainicio` = '2011-10-01', `Orçamento` = '10000' WHERE (`NObras` = '1');
UPDATE `mydb`.`obras` SET `Local` = 'Braga', `Datainicio` = '2011-10-10', `Orçamento` = '5000' WHERE (`NObras` = '2');
UPDATE `mydb`.`obras` SET `Local` = 'Porto', `Datainicio` = '2011-11-01', `Orçamento` = '10000' WHERE (`NObras` = '3');
UPDATE `mydb`.`obras` SET `Local` = 'Lisboa', `Datainicio` = '2011-11-11', `Orçamento` = '20000' WHERE (`NObras` = '4');








