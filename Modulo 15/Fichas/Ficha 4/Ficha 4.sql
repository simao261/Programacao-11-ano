-- 1. Criar a base de dados
CREATE DATABASE dados_imagens
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

-- 2. Usar a base de dados
USE dados_imagens;

-- 3. Criar a tabela imagens
CREATE TABLE imagens (
    ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    NomeFicheiro VARCHAR(255),
    TamanhoFicheiro VARCHAR(20),
    Resolucao INT,
    DataCriacao DATETIME
);

-- 4. Adicionar o campo DataModificacao
ALTER TABLE imagens
ADD DataModificacao DATETIME;

-- 5. Alterar o tipo de TamanhoFicheiro para INT
ALTER TABLE imagens
MODIFY TamanhoFicheiro INT;

-- 6. Eliminar o campo Resolucao
ALTER TABLE imagens
DROP COLUMN Resolucao;

-- 7. Eliminar a tabela imagens
DROP TABLE imagens;

-- 8. Eliminar a base de dados
DROP DATABASE dados_imagens;

