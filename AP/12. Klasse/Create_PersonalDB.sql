create database PersonalDB_wagner
GO
use PersonalDB_wagner
go

CREATE TABLE Abteilung(
	ABTNR INTEGER PRIMARY KEY,
	ABTNAME VARCHAR(255),
	BUDGET DECIMAL(11,2),
	CHEFNR INTEGER);

CREATE TABLE Projekt(
	PROJNR INTEGER PRIMARY KEY,
	BUDGET DECIMAL(11,2),
	ABTNR INTEGER, 
	FOREIGN KEY(ABTNR) REFERENCES Abteilung(ABTNR));

CREATE TABLE Personal(
	PERSNR INTEGER PRIMARY KEY,
	VNAME VARCHAR(255),
	NNAME VARCHAR(255),
	PROJNR INTEGER ,
	TELEFONNR VARCHAR(255),
	GEHALT DECIMAL(11,2),
	FOREIGN KEY(PROJNR) REFERENCES Projekt(PROJNR));

CREATE TABLE Akte(
	PERSNR INTEGER ,
	DATUM DATE,
	POSITION VARCHAR(255),
	GEHALT DECIMAL(11,2),
	FOREIGN KEY(PERSNR) REFERENCES Personal(PERSNR),
	PRIMARY KEY (PERSNR, DATUM));


INSERT INTO Abteilung VALUES
(1, 'Buchhaltung', 10000, 1),
(2, 'FuE', 15000, 71),
(3, 'Immobilien', 4000, 91),
(4, 'Marketing', 50000, 81),
(5, 'Controling', 20000, 94),
(6, 'Hausmeister', 1000, 94),
(7, 'Kantine', 1000, 94),
(8, 'Vorstand', 100000, 94),
(9, 'Fuhrpark', 7000, 94),
(10, 'Service', 30000, 71),
(11, 'Einkauf', 15000, 1),
(12, 'Verkauf', 30000, 1);

INSERT INTO Projekt VALUES
(1, 5000, 1),
(2, 1000, 1),
(3, 2200, 10),
(4, 100, 3),
(5, 500, 4),
(6, 1000, 1),
(7, 3000, 4),
(8, 1000, 8),
(9, 1000, 4),
(10, 1000, 7),
(23, 5500, 3);

INSERT INTO Personal VALUES
(1, 'Donald', 'Duck', 1, 1201, 1000),
(2, 'Dagobert', 'Duck', 1, 1202, 200),
(3, 'Zita', 'Delle', 1, 1203, 50),
(4, 'Axel', 'Nässe', 1, 1203, 50),
(5, 'Anna', 'Bolika', 1, 1203, 50),
(6, 'Gustav', 'Gans', 23, 2201, 2000),
(7, 'Gitta', 'Gans', 23, 2202, 0),
(8, 'Daniel', 'Duesentrieb', 2, 2203, 5000),
(10, 'Klaas', 'Klever', 1, 1204, 50),
(21, 'Klaus', 'Trophobie', 3, 3201, 2000),
(71, 'Micky', 'Maus', 3, 3201, 3000),
(72, 'Anna', 'Nass', 3, 3202, 1000),
(73, 'Minni', 'Maus', 3, 3203, 2000),
(51, 'Rainer', 'Wein', 6, 6202, 100),
(52, 'Rainer', 'Zufall', 6, 6203, 100),
(81, 'Tick', NULL, 7, 5201, 1500),
(82, 'Trick', NULL, 7, 5201, 1500),
(83, 'Franz', 'Gans', 7, 5205, 2000),
(84, 'Track', NULL, 4, 4201, 2000),
(90, 'Klaus', 'Trophobie', 4, 4201, 2000),
(91, 'Axel', 'Schweiss', 4, 4201, 2000),
(93, 'Fenn', 'Sterputz', 4, 4203, 2000),
(94, 'Heinz', 'Elmann', 4, 4204, 7000);

INSERT INTO Akte VALUES
(8, '2008-01-01',' Tüftler', 2000),
(8, '2008-06-01',' Erfinder', 3000),
(8, '2009-04-01',' Cheferfinder', 5000),
(1, '2009-04-01',' Oberbuchhalter', 1000),
(1, '2006-01-01',' Hilfsbuchhalter', 100),
(1, '2007-09-01',' Buchhalter', 500),
(2, '2007-11-01',' Buchhalter', 200),
(2, '2007-01-01',' Hilfsuchhalter', 90),
(3, '2007-01-01',' Hilfsbuchhalter', 90),
(4, '2007-01-01',' Hilfsbuchhalter', 90),
(5, '2007-01-01',' Hilfsbuchhalter', 90),
(6, '2003-01-01',' Angestellter', 2000),
(7, '2009-01-01',' Praktikant', 0),
(10, '2008-01-01',' Hilfsbuchhalter', 50),
(94, '1982-03-01',' Schuhputzer', 50),
(94, '1982-09-01',' Tellerwäscher', 100),
(94, '1983-05-01',' Tellerstapler', 200),
(94, '1988-05-01',' Küchenchef', 1000),
(94, '1999-05-01',' Abteilungsleiter', 3000),
(94, '2008-05-01',' Hauptabteilungsleiter', 7000),
(91, '1997-05-01',' Angestellter', 1000),
(91, '2007-05-01',' Abteilungsleiter', 2000),
(71, '2002-01-01',' Junior Berater', 1000),
(71, '2003-04-01',' Berater', 2000),
(71, '2008-04-01',' Senior Berater', 3000),
(21, '2001-01-01',' Junior Berater', 800),
(21, '2002-04-01',' Berater', 1200),
(21, '2007-04-01',' Senior Berater', 2000),
(90, '2008-01-01',' Angestellter', 2000),
(91, '2003-01-01',' Praktikant', 20),
(91, '2003-05-01',' Angestellter', 2000),
(93, '2003-05-01',' Angestellter', 2000),
(94, '2004-01-01',' Angestellter', 2000),
(81, '2008-01-01',' Berater', 1500),
(82, '2008-01-01',' Berater', 1500),
(84, '2008-01-01',' Berater', 1500),
(84, '2009-01-01',' Berater', 2000);

ALTER TABLE Abteilung
ADD CONSTRAINT fk_abt_pers FOREIGN KEY (CHEFNR) REFERENCES Personal(PERSNR);

select * from Akte;
select * from Personal;
select * from Projekt;
select * from Abteilung;