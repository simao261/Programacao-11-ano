-- Ficha de Trabalho 1 - DDL (Data Definition Language)

-- =========================
-- Exercício 1: Base de Dados
-- =========================

-- 1. Criar a base de dados biblioteca
create database biblioteca;

-- 2. Eliminar a base de dados biblioteca
drop database biblioteca;

-- =========================
-- Exercício 2: Tabelas
-- =========================

-- 1. Criar a base de dados novamente para os próximos exercícios
create database biblioteca;
use biblioteca;

-- 2. Criar a tabela livros
create table livros (
  isbn varchar(13) primary key,
  titulo varchar(255) not null,
  ano_publicacao int
);

-- 3. Criar a tabela autores
create table autores (
  id int primary key,
  nome varchar(255) not null
);

-- 4. Criar a tabela leitores
create table leitores (
  id int primary key,
  nome varchar(255) not null
);

-- 5. Eliminar a tabela autores
drop table autores;

-- 6. Eliminar a tabela livros
drop table livros;

-- 7. Eliminar a tabela leitores
drop table leitores;

-- 8. Eliminar a base de dados biblioteca
drop database biblioteca;

-- =========================
-- Exercício 3: (Desafio Avançado)
-- Criação da Tabela emprestimos com Chaves Estrangeiras
-- =========================

-- A partir daqui, usar MAIÚSCULAS para palavras-chave SQL

-- 1. Recriar a base de dados e as tabelas necessárias
CREATE DATABASE biblioteca;
USE biblioteca;

CREATE TABLE livros (
  isbn VARCHAR(13) PRIMARY KEY,
  titulo VARCHAR(255) NOT NULL,
  ano_publicacao INT
);

CREATE TABLE autores (
  id INT PRIMARY KEY,
  nome VARCHAR(255) NOT NULL
);

CREATE TABLE leitores (
  id INT PRIMARY KEY,
  nome VARCHAR(255) NOT NULL
);

-- 2. Criar a tabela emprestimos com chaves estrangeiras
CREATE TABLE emprestimos (
  id INT PRIMARY KEY,
  data_emprestimo DATE NOT NULL,
  id_livro VARCHAR(13) NOT NULL,
  id_leitor INT,
  FOREIGN KEY (id_livro) REFERENCES livros(isbn),
  FOREIGN KEY (id_leitor) REFERENCES leitores(id)
);

-- FIM DA FICHA
