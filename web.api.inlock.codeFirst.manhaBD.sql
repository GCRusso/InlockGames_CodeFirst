USE inlock_games_codeFirst_manha

INSERT INTO TiposUsuario
VALUES(NEWID(),'Administrador'),(NEWID(),'Comum')

SELECT * FROM TiposUsuario

INSERT INTO Usuario
VALUES
(NEWID(),'admin@admin.com','admin123','007870F7-182F-437A-9D87-8520A68E977F'), 
(NEWID(), 'comum@comum.com','comum123','B2647126-92A0-44AA-9572-C0F0A89614E1')

SELECT * FROM Usuario

INSERT INTO Estudio
VALUES
(NEWID(),'Rockstar Games'),
(NEWID(),'Rovio')

SELECT * FROM Estudio

INSERT INTO Jogo(IdJogo,Nome,Descricao,DataLancamento,Preco,IdEstudio)
VALUES
(NEWID(),'GTA 6','Jogo de mundo aberto','2024-03-05',500.50,'A1D824F6-CFA4-42DE-B9C3-3137BEE44FA3'),
(NEWID(),'Angry Birds','Para crianças ser divertir','2011-10-05',100.50,'F681D5D2-A443-4760-93C8-52CC87C4DA42')

SELECT * FROM Jogo

DELETE FROM Jogo WHERE Nome = 'GTA 6'