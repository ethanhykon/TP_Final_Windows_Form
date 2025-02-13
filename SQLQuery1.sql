 /* CREATE TABLE Jeux (
ID INT PRIMARY KEY IDENTITY,
Nom NVARCHAR(200),
Genre NVARCHAR(200),
date_de_sortie DATE,
Prix_en_euros NVARCHAR (200),
Disponibilité NVARCHAR (200)
);*/

INSERT INTO dbo.Jeux (Nom, Genre, date_de_sortie, Prix_en_euros, Disponibilité) 
VALUES ('jeux', 'Action', CONVERT(DATE, '13-02-2025', 105), '100', 'disponible');	

SELECT * FROM Jeux ; 
