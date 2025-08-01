CREATE DATABASE IF NOT EXISTS aeroporto_db
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

USE aeroporto_db;

-- Tabela companhias_aereas
CREATE TABLE companhias_aereas (
  ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
  Nome VARCHAR(100) NOT NULL,
  codigo_iata CHAR(2) UNIQUE
);

-- Tabela avioes
CREATE TABLE avioes (
  ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
  modelo VARCHAR(50) NOT NULL,
  capacidade INT NOT NULL,
  companhia_id INT,
  horas_voo INT NOT NULL DEFAULT 0,
  FOREIGN KEY (companhia_id) REFERENCES companhias_aereas(ID)
);

-- Tabela voos
CREATE TABLE voos (
  ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
  numero_voo VARCHAR(10) UNIQUE,
  origem VARCHAR(50) NOT NULL,
  destino VARCHAR(50) NOT NULL,
  data_partida DATETIME,
  aviao_id INT,
  status ENUM('Agendado', 'Cancelado', 'Concluído') NOT NULL DEFAULT 'Agendado',
  FOREIGN KEY (aviao_id) REFERENCES avioes(ID)
);

-- Tabela passageiros
CREATE TABLE passageiros (
  ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
  Nome VARCHAR(100) NOT NULL,
  passaporte VARCHAR(20) UNIQUE
);

-- Tabela reservas
CREATE TABLE reservas (
  ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
  passageiro_id INT,
  voo_id INT,
  classe ENUM('Econômica', 'Executiva', 'Primeira'),
  data_devolucao DATE,
  FOREIGN KEY (passageiro_id) REFERENCES passageiros(ID),
  FOREIGN KEY (voo_id) REFERENCES voos(ID)
);


CREATE INDEX idx_destino ON voos(destino);


INSERT INTO companhias_aereas (Nome, codigo_iata) VALUES
('TAP Air Portugal', 'TP'),
('Emirates', 'EK');

INSERT INTO avioes (modelo, capacidade, companhia_id, horas_voo) VALUES
('Airbus A320', 180, (SELECT ID FROM companhias_aereas WHERE Nome = 'TAP Air Portugal'), 0),
('Boeing 777', 350, (SELECT ID FROM companhias_aereas WHERE Nome = 'Emirates'), 0);

INSERT INTO voos (numero_voo, origem, destino, data_partida, aviao_id, status) VALUES
('TP123', 'Lisboa (LIS)', 'Paris (CDG)', '2024-10-01 08:00:00', (SELECT ID FROM avioes WHERE modelo = 'Airbus A320'), 'Agendado'),
('EK456', 'Dubai (DXB)', 'Nova Iorque (JFK)', '2024-10-02 15:30:00', (SELECT ID FROM avioes WHERE modelo = 'Boeing 777'), 'Agendado');

INSERT INTO passageiros (Nome, passaporte) VALUES
('João Silva', 'PS12345'),
('Maria Santos', 'MS67890');

INSERT INTO reservas (passageiro_id, voo_id, classe) VALUES
((SELECT ID FROM passageiros WHERE Nome = 'João Silva'), (SELECT ID FROM voos WHERE numero_voo = 'TP123'), 'Econômica'),
((SELECT ID FROM passageiros WHERE Nome = 'Maria Santos'), (SELECT ID FROM voos WHERE numero_voo = 'EK456'), 'Executiva');


UPDATE voos SET status = 'Concluído' WHERE numero_voo = 'TP123';

UPDATE avioes SET capacidade = 200 WHERE modelo = 'Airbus A320';

UPDATE avioes
SET horas_voo = 500
WHERE companhia_id = (SELECT ID FROM companhias_aereas WHERE Nome = 'TAP Air Portugal');


DELETE FROM reservas
WHERE voo_id IN (SELECT ID FROM voos WHERE status = 'Cancelado');



   
   
   
  
  
  
  
