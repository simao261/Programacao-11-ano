

-- Inserção de dados
INSERT INTO especialidades (Designacao) VALUES
('Cardiologia'),
('Dermatologia'),
('Gastrenterologia'),
('Medicina Dentária'),
('Medicina Geral e Familiar'),
('Medicina Interna'),
('Oftalmologia'),
('Ortopedia'),
('Pediatria'),
('Pneumologia');

INSERT INTO sistemas_saude (Designacao) VALUES
('Açoreana - AdvanceCare'),
('ADSE'),
('Cruz Vermelha Portuguesa'),
('Fidelidade'),
('Generali - AdvanceCare'),
('Logo - AdvanceCare'),
('Medicare'),
('Multicare'),
('SAD GNR - Regime Convencionado'),
('SAD PSP - Regime Convencionado'),
('SNS - Serviço Nacional de Saúde');

-- IDs das especialidades (por ordem): 1-Cardiologia, 2-Dermatologia, 3-Gastrenterologia, 4-Medicina Dentária, 5-Medicina Geral e Familiar, 6-Medicina Interna, 7-Oftalmologia, 8-Ortopedia, 9-Pediatria, 10-Pneumologia

INSERT INTO medicos (Nome, Especialidade_ID) VALUES
('Benedita Neves', 9),
('João Coelho', 7),
('Domingos Rodrigues', 9),
('Afonso Rocha', 2),
('Domingos Costa', 1),
('Carina Costa', 5),
('Casimiro Santos', 5),
('Catarina Neves', 7),
('Daniel Mendes', 8),
('Daniel Oliveira', 10),
('João Simões', 3),
('Daniela Martins', 4);

-- IDs dos sistemas de saúde (por ordem): 1-Açoreana, 2-ADSE, 3-Cruz Vermelha, 4-Fidelidade, 5-Generali, 6-Logo, 7-Medicare, 8-Multicare, 9-SAD GNR, 10-SAD PSP, 11-SNS

INSERT INTO pacientes (Nome, Email, Password, Morada, CodigoPostal, DataNascimento, NIF, Telefone, SistemaSaude_ID, NumeroSistemaSaude) VALUES
('João Pereira', 'j.pereira@xyz.com', '123', 'Rua da Azenha, Póvoa do Pinheiro', '3025-139', '1982-01-01', '385974272', '911234567', 2, '01234567 SS'),
('Carlota Santos', 'carlota@xyz.pt', 'abc', 'Urbanização Bela Vista, Santa Clara', '3040-243', '1999-08-01', '769715839', '961234567', 7, '123456789'),
('Cidália Pereira', 'c.pereira@xyz.pt', '321', 'Rua de São Pedro, Almedina', '3000-370', '1960-03-12', '853929338', '921234567', 8, '987ABC4321');

-- IDs dos pacientes: 1-João Pereira, 2-Carlota Santos, 3-Cidália Pereira
-- IDs dos médicos: 1-Benedita Neves, 3-Domingos Rodrigues, 5-Domingos Costa, 6-Carina Costa, 10-Daniel Oliveira, 12-Daniela Martins

INSERT INTO marcacoes (Paciente_ID, Medico_ID, DataHora) VALUES
(1, 3, '2021-10-26 09:30:00'),
(2, 6, '2021-06-22 11:00:00'),
(3, 1, '2022-01-08 12:00:00'),
(3, 5, '2021-04-25 19:30:00'),
(2, 12, '2021-03-04 09:45:00'),
(3, 1, '2022-01-08 09:30:00'),
(1, 1, '2022-01-08 10:00:00'),
(2, 10, '2021-11-05 11:30:00'),
(2, 1, '2021-09-09 15:00:00');

-- Reinicializar a password de todos os pacientes
UPDATE pacientes
SET Password = 'clinica-coimbra';

-- Mudar as marcações da médica Benedita Neves (ID 1) no dia 08/01/2022 para Carina Costa (ID 6)
UPDATE marcacoes
SET Medico_ID = 6
WHERE Medico_ID = 1 AND DATE(DataHora) = '2022-01-08';

-- Eliminar todas as marcações do médico Daniel Oliveira (ID 10)
DELETE FROM marcacoes
WHERE Medico_ID = 10;
