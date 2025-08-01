-- Ficha de Trabalho: DDL MySQL - Criação, Alteração de Tabelas e Índices
-- Curso Profissional de Técnico/a de Gestão e Programação de Sistemas Informáticos 2024/2025
-- Disciplina: Programação e Sistemas de Informação

-- 1. Criar a Base de Dados
CREATE DATABASE loja;
USE loja;

-- 2. Criar Tabelas
CREATE TABLE clientes (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    email VARCHAR(100) UNIQUE
);

CREATE TABLE produtos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    preco DECIMAL(10,2) DEFAULT 0.00
);

-- 3. Alterar Tabelas
-- 3.1 Adicionar a coluna telefone à tabela clientes
ALTER TABLE clientes ADD COLUMN telefone VARCHAR(9);

-- 3.2 Alterar a coluna preco em produtos para aceitar valores até 9999.99
ALTER TABLE produtos MODIFY COLUMN preco DECIMAL(6,2) DEFAULT 0.00;

-- 3.3 Eliminar a coluna email da tabela clientes
ALTER TABLE clientes DROP COLUMN email;

-- 4. Índices
-- 4.1 Criar um índice simples na coluna nome da tabela clientes
CREATE INDEX idx_nome ON clientes(nome);

-- 4.2 Criar um índice único na coluna telefone da tabela clientes
CREATE UNIQUE INDEX idx_telefone_unico ON clientes(telefone);

-- 4.3 Eliminar o índice único criado
DROP INDEX idx_telefone_unico ON clientes;

-- 5. Bónus (Desafio)
-- 5.1 Criar a tabela vendas com relações
CREATE TABLE vendas (
    id INT PRIMARY KEY AUTO_INCREMENT,
    data_venda DATE,
    id_cliente INT,
    id_produto INT,
    FOREIGN KEY (id_cliente) REFERENCES clientes(id),
    FOREIGN KEY (id_produto) REFERENCES produtos(id)
);

-- 5.2 Criar índices compostos em data_venda e id_cliente
CREATE INDEX idx_data_cliente ON vendas(data_venda, id_cliente);

-- 6. Verificação Final
SHOW TABLES;
DESCRIBE clientes;
SHOW INDEX FROM clientes;
