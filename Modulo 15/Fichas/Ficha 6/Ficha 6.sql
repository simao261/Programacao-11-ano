-- Parte 1: Criação do Banco de Dados e Tabelas
CREATE DATABASE clinica_gestao
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

USE clinica_gestao;

CREATE TABLE especialidades (
    ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Nome VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE medicos (
    ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Nome VARCHAR(255) NOT NULL,
    Especialidade_ID INT,
    FOREIGN KEY (Especialidade_ID) REFERENCES especialidades(ID)
);

CREATE TABLE pacientes (
    ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Nome VARCHAR(255) NOT NULL,
    NIF VARCHAR(9) UNIQUE,
    DataNascimento DATE
);

CREATE TABLE consultas (
    ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Paciente_ID INT,
    Medico_ID INT,
    DataHora DATETIME NOT NULL,
    Observacoes VARCHAR(255) DEFAULT 'Sem observações',
    FOREIGN KEY (Paciente_ID) REFERENCES pacientes(ID),
    FOREIGN KEY (Medico_ID) REFERENCES medicos(ID)
);

-- Parte 2: Modificação de Estruturas
ALTER TABLE pacientes
ADD COLUMN Telefone VARCHAR(9);

ALTER TABLE medicos
ADD COLUMN Ativo BOOLEAN DEFAULT TRUE;

-- Parte 3: Manipulação de Dados

-- Inserir especialidades
INSERT INTO especialidades (Nome) VALUES
('Cardiologia'), ('Pediatria'), ('Dermatologia'), ('Ortopedia'), ('Oftalmologia');

-- Inserir médicos
INSERT INTO medicos (Nome, Especialidade_ID) VALUES
('Dr. Luís Martins', (SELECT ID FROM especialidades WHERE Nome = 'Cardiologia')),
('Dra. Sofia Ramos', (SELECT ID FROM especialidades WHERE Nome = 'Pediatria'));

-- Inserir pacientes
INSERT INTO pacientes (Nome, NIF, DataNascimento) VALUES
('Maria Oliveira', '12345678', '1990-05-15');

INSERT INTO pacientes (Nome, NIF, Telefone) VALUES
('João Costa', '87654321', '912345678');

-- Inserir consultas
INSERT INTO consultas (Paciente_ID, Medico_ID, DataHora)
VALUES
(
    (SELECT ID FROM pacientes WHERE Nome = 'Maria Oliveira'),
    (SELECT ID FROM medicos WHERE Nome = 'Dr. Luís Martins'),
    '2024-04-20 10:00'
),
(
    (SELECT ID FROM pacientes WHERE Nome = 'João Costa'),
    (SELECT ID FROM medicos WHERE Nome = 'Dra. Sofia Ramos'),
    '2024-04-21 14:30'
);

-- Atualizar consultas do Dr. Luís Martins
UPDATE consultas
SET DataHora = '2024-05-01 09:00'
WHERE Medico_ID = (SELECT ID FROM medicos WHERE Nome = 'Dr. Luís Martins');
-- Medico_ID = 1;


-- Desativar médicos com especialidade Pediatria
UPDATE medicos
SET Ativo = FALSE
WHERE Especialidade_ID = (SELECT ID FROM especialidades WHERE Nome = 'Pediatria');
-- Especialidade_ID = 2;


-- Remover pacientes sem consultas registadas
DELETE FROM pacientes
WHERE ID NOT IN (SELECT DISTINCT Paciente_ID FROM consultas);






