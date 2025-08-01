-- Grupo I 

-- 1. 
CREATE DATABASE IF NOT EXISTS escola_virtual
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_general_ci;
USE escola_virtual;

-- 2. 
CREATE TABLE cursos (
  ID INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  Designacao VARCHAR(100) NOT NULL
);

-- 3. 
CREATE TABLE alunos (
  ID INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  Nome VARCHAR(100) NOT NULL,
  Email VARCHAR(100) DEFAULT NULL,
  Curso_ID INT,
  FOREIGN KEY (Curso_ID) REFERENCES cursos(ID)
);

-- 4. 
CREATE INDEX idx_Nome ON alunos(Nome);

-- 5. 
ALTER TABLE alunos
  ADD COLUMN DataNascimento DATE,
  MODIFY COLUMN Email VARCHAR(150);

-- 6. 
ALTER TABLE alunos
  DROP COLUMN DataNascimento;

-- 7. 
DROP TABLE IF EXISTS alunos;
DROP DATABASE IF EXISTS escola_virtual;

-- Grupo II 
-- 8. 
CREATE DATABASE IF NOT EXISTS escola_virtual
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_general_ci;
USE escola_virtual;

CREATE TABLE cursos (
  ID INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  Designacao VARCHAR(100) NOT NULL
);

CREATE TABLE alunos (
  ID INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  Nome VARCHAR(100) NOT NULL,
  Email VARCHAR(150) DEFAULT NULL,
  Curso_ID INT,
  FOREIGN KEY (Curso_ID) REFERENCES cursos(ID)
);

-- 9. 
INSERT INTO cursos (Designacao) VALUES
  ('Informática'),
  ('Multimédia'),
  ('Contabilidade');

-- 10. 
INSERT INTO alunos (Nome, Email, Curso_ID) VALUES
  ('Ana Silva', 'ana@email.pt', 1),
  ('Bruno Costa', 'bruno@email.pt', 2),
  ('Carla Dias', 'carla@email.pt', 3);

-- 11. 
UPDATE alunos SET Email = 'alunos@megat.pt';

-- 12.
DELETE FROM alunos WHERE Curso_ID = 2;

-- 13. 
DELETE FROM cursos
WHERE ID NOT IN (SELECT DISTINCT Curso_ID FROM alunos WHERE Curso_ID IS NOT NULL);

-- Grupo III

-- 14. 
CREATE DATABASE IF NOT EXISTS inventario_loja
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_general_ci;
USE inventario_loja;

-- 15.
CREATE TABLE produtos (
  ID INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  Nome VARCHAR(100) NOT NULL,
  Preco DECIMAL(7,2) NOT NULL,
  Stock INT NOT NULL
);

-- 16. 
INSERT INTO produtos (Nome, Preco, Stock) VALUES
  ('Teclado', 17.90, 12),
  ('Rato', 12.90, 24),
  ('Monitor', 129.90, 6);

-- 17. 
UPDATE produtos SET Stock = Stock + 5 WHERE Preco > 30;

-- 18.
DELETE FROM produtos WHERE Stock = 0;








