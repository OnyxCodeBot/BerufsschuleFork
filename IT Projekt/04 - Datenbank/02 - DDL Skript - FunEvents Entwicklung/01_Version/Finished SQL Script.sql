--create database FunEvents_Entwicklung_21ITA007
--go

use FunEvents_Entwicklung_21ITA007
go

--Drop Tables
drop table tbl_Buchungen
drop table tbl_Kunden
drop table tbl_EventDaten
drop table tbl_Events
drop table tbl_EvKategorie
drop table tbl_EvVeranstalter

--Create Tables
create table tbl_EvVeranstalter (
	ev_EvVeranstalterID int identity,
	ev_Firma nvarchar(50),
	ev_Strasse nvarchar(50),
	ev_PLZ nvarchar(10),
	ev_HNummer nvarchar(10),
	ev_Ort nvarchar(50),
	ev_Telefon nvarchar(25),
	ev_Email nvarchar(50),
	ev_Fax nvarchar(50),
    constraint PK_tbl_EvVeranstalter primary key(ev_EvVeranstalterID)
)

create table tbl_EvKategorie (
	ek_EvKategorieID int identity,
	ek_KatBezeichnung nvarchar(15),
	constraint PK_tbl_EvKategorie primary key(ek_EvKategorieID)
)

create table tbl_Kunden (
	kd_KundenID int identity,
	kd_Namen nvarchar(50),
	kd_Vorname nvarchar(50),
	kd_Strasse nvarchar(50),
	kd_HNummer nvarchar(10),
	kd_PLZ nvarchar(10),
	kd_Ort nvarchar(50),
	kd_Telefon nvarchar(25),
	kd_EMail nvarchar(50),
	constraint PK_tbl_Kunden primary key(kd_KundenID)
)

create table tbl_Events (
	et_EventID int identity,
	ev_EvVeranstalterID int,
	ek_EvKategorieID int,
	et_Bezeichnung nvarchar(50),
	et_Beschreibung text,
	constraint PK_tbl_Events primary key(et_EventID),
	constraint FK_tbl_Events_tbl_EvVeranstalter foreign key (ev_EvVeranstalterID) references tbl_EvVeranstalter,
	constraint FK_tbl_Events_tbl_EvKategorie foreign key (ek_EvKategorieID) references tbl_EvKategorie
)

create table tbl_EventDaten (
	ed_EvDatenID int identity,
	et_EventID int,
	ed_Preis smallmoney,
	ed_Beginn datetime,
	ed_Ende datetime,
	ed_StartOrt nvarchar(50),
	ed_Zielort nvarchar(50),
	ed_Maxteilnehmer int,
	ed_AktTeilnehmer int,
	ed_Freigeben bit,
	ed_Rabtt decimal(18,0),
	ed_VeranstalterBenachrichtigt bit,
	constraint PK_tbl_EventDaten primary key(ed_EvDatenID),
	constraint FK_tbl_EventDaten_tbl_Events foreign key (et_EventID) references tbl_Events
)

create table tbl_Buchungen (
	bu_BuchungsID int identity,
	kd_KundenID int,
	ed_EvDatenID int,
	bu_GebuchtePletze int,
	bu_Bezahlt bit,
	bu_Storniert bit,
	bu_RechnungErstellen bit,
	constraint PK_tbl_Buchungen primary key(bu_BuchungsID),
	constraint FK_tbl_Buchungen_tbl_EventDaten foreign key (ed_EvDatenID) references tbl_EventDaten,
	constraint FK_tbl_Buchungen_tbl_Kunden foreign key (kd_KundenID) references tbl_Kunden
)

--Insert Data into Tables
bulk insert
	FunEvents_Entwicklung_21ITA007.dbo.tbl_Buchungen
from 'D:\DATA\FunEventsCSV\Buchungen.txt'
with
(
	CODEPAGE = 'ACP',
	FIRSTROW = 2,
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n'
)

bulk insert
	FunEvents_Entwicklung_21ITA007.dbo.tbl_EventDaten
from 'D:\DATA\FunEventsCSV\EventDaten.txt'
with
(
	CODEPAGE = 'ACP',
	FIRSTROW = 2,
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n'
)

bulk insert
	FunEvents_Entwicklung_21ITA007.dbo.tbl_Events
from 'D:\DATA\FunEventsCSV\Events.txt'
with
(
	CODEPAGE = 'ACP',
	FIRSTROW = 2,
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n'
)

bulk insert
	FunEvents_Entwicklung_21ITA007.dbo.tbl_EvKategorie
from 'D:\DATA\FunEventsCSV\EvKategorie.txt'
with
(
	CODEPAGE = 'ACP',
	FIRSTROW = 2,
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n'
)

bulk insert
	FunEvents_Entwicklung_21ITA007.dbo.tbl_EvVeranstalter
from 'D:\DATA\FunEventsCSV\EvVeranstalter.txt'
with
(
	CODEPAGE = 'ACP',
	FIRSTROW = 2,
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n'
)

bulk insert
	FunEvents_Entwicklung_21ITA007.dbo.tbl_Kunden
from 'D:\DATA\FunEventsCSV\Kunden.txt'
with
(
	CODEPAGE = 'ACP',
	FIRSTROW = 2,
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n'
)

--Select
select * from tbl_Buchungen
select * from tbl_EventDaten
select * from tbl_Events
select * from tbl_EvKategorie
select * from tbl_EvVeranstalter
select * from tbl_Kunden