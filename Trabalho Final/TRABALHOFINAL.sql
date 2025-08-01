CREATE DATABASE AluguerVeiculos;
USE AluguerVeiculos;

CREATE TABLE Clientes (
    Cliente_ID INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(100) NOT NULL,
    NIF VARCHAR(9) NOT NULL UNIQUE,
    Morada VARCHAR(200),
    Telefone VARCHAR(15),
    Email VARCHAR(100)
);

CREATE TABLE Agencia (
    Agencia_ID INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(100) NOT NULL,
    Localizacao VARCHAR(200),
    Contacto VARCHAR(15)
);

CREATE TABLE Funcionarios (
    Funcionario_ID INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(100) NOT NULL,
    Telefone VARCHAR(15),
    Email VARCHAR(100),
    Agencia_ID INT,
    FOREIGN KEY (Agencia_ID) REFERENCES Agencia(Agencia_ID)
);

CREATE TABLE Estados (
    Estado_ID INT PRIMARY KEY AUTO_INCREMENT,
    Designacao VARCHAR(50) NOT NULL
);

CREATE TABLE Categorias (
    Categoria_ID INT PRIMARY KEY AUTO_INCREMENT,
    Designacao VARCHAR(50) NOT NULL
);

CREATE TABLE Veiculos (
    Veiculo_ID INT PRIMARY KEY AUTO_INCREMENT,
    Marca VARCHAR(50),
    Modelo VARCHAR(50),
    Ano INT,
    Cor VARCHAR(30),
    Matricula VARCHAR(15) UNIQUE,
    Km INT,
    Lugares INT,
    Preco DECIMAL(10,2),
    Designacao VARCHAR(100),
    Estado_ID INT,
    Categoria_ID INT,
    Agencia_ID INT,
    FOREIGN KEY (Estado_ID) REFERENCES Estados(Estado_ID),
    FOREIGN KEY (Categoria_ID) REFERENCES Categorias(Categoria_ID),
    FOREIGN KEY (Agencia_ID) REFERENCES Agencia(Agencia_ID)
);

CREATE TABLE Alugueres (
    Aluguer_ID INT PRIMARY KEY AUTO_INCREMENT,
    Cliente_ID INT,
    Veiculo_ID INT,
    Funcionario_ID INT,
    DataInicio DATE,
    DataFim DATE,
    PrecoTotal DECIMAL(10,2),
    FOREIGN KEY (Cliente_ID) REFERENCES Clientes(Cliente_ID),
    FOREIGN KEY (Veiculo_ID) REFERENCES Veiculos(Veiculo_ID),
    FOREIGN KEY (Funcionario_ID) REFERENCES Funcionarios(Funcionario_ID)
);

INSERT INTO Clientes (Nome, NIF, Morada, Telefone, Email) VALUES
('João Silva', '123456789', 'Rua A, 10', '912345678', 'joao@email.com'),
('Maria Costa', '987654321', 'Rua B, 20', '934567890', 'maria@email.com');

INSERT INTO Agencia (Nome, Localizacao, Contacto) VALUES
('Agencia Centro', 'Lisboa', '211234567'),
('Agencia Norte', 'Porto', '221234567');

INSERT INTO Funcionarios (Nome, Telefone, Email, Agencia_ID) VALUES
('Carlos Mendes', '912222333', 'carlos@email.com', 1),
('Ana Lopes', '913333444', 'ana@email.com', 2);

INSERT INTO Estados (Designacao) VALUES
('Disponível'), ('Alugado'), ('Manutenção');

INSERT INTO Categorias (Designacao) VALUES
('Económico'), ('SUV'), ('Luxo');

INSERT INTO Veiculos (Marca, Modelo, Ano, Cor, Matricula, Km, Lugares, Preco, Designacao, Estado_ID, Categoria_ID, Agencia_ID) VALUES
('Renault', 'Clio', 2020, 'Branco', 'AA-11-BB', 25000, 5, 35.00, 'Clio Branco', 1, 1, 1),
('BMW', 'X5', 2022, 'Preto', 'CC-22-DD', 10000, 5, 90.00, 'X5 Luxo', 1, 3, 2);

INSERT INTO Alugueres (Cliente_ID, Veiculo_ID, Funcionario_ID, DataInicio, DataFim, PrecoTotal) VALUES
(1, 1, 1, '2024-06-01', '2024-06-05', 140.00),
(2, 2, 2, '2024-06-10', '2024-06-15', 450.00);

