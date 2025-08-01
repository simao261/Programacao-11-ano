-- Tarefa 1
CREATE DATABASE IF NOT EXISTS clinica_medica_coimbra CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

USE clinica_medica_coimbra;

-- Tarefa 2
CREATE TABLE especialidades (
    ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Designacao VARCHAR(100) NOT NULL
);

CREATE TABLE sistemas_saude (
    ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Designacao VARCHAR(100) NOT NULL
);

CREATE TABLE medicos (
    ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Nome VARCHAR(255) NOT NULL,
    Especialidade_ID INT DEFAULT NULL,
    FOREIGN KEY (Especialidade_ID) REFERENCES especialidades(ID)
);

CREATE TABLE pacientes (
    ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Nome VARCHAR(255) DEFAULT NULL,
    Email VARCHAR(255) DEFAULT NULL,
    Password VARCHAR(255) DEFAULT NULL,
    Morada VARCHAR(255) DEFAULT NULL,
    CodigoPostal VARCHAR(8) DEFAULT NULL,
    DataNascimento DATE DEFAULT NULL,
    NIF VARCHAR(9) DEFAULT NULL,
    Telefone VARCHAR(9) DEFAULT NULL,
    SistemaSaude_ID INT DEFAULT NULL,
    NumeroSistemaSaude VARCHAR(30) DEFAULT '0',
    FOREIGN KEY (SistemaSaude_ID) REFERENCES sistemas_saude(ID)
);

CREATE TABLE marcacoes (
    ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Paciente_ID INT NOT NULL,
    Medico_ID INT NOT NULL,
    DataHora DATETIME NOT NULL,
    FOREIGN KEY (Paciente_ID) REFERENCES pacientes(ID),
    FOREIGN KEY (Medico_ID) REFERENCES medicos(ID)
);

-- Tarefa 3
CREATE INDEX idx_NIF ON pacientes (NIF);

-- Tarefa 4
CREATE INDEX idx_DataHora ON marcacoes (DataHora);

-- Tarefa 5
/*
DROP INDEX idx_NIF ON pacientes;
DROP INDEX idx_DataHora ON marcacoes;
*/

