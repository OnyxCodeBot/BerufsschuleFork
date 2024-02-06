create database FunEvents_Entwicklung_...
go

use FunEvents_Entwicklung_...
go

create Table tbl_EvVeranstalter 
(
ev_EvVeranstalterID int identity (1,1) primary key,
ev_Firma nvarchar(50),
ev_Starsse nvarchar(50),
ev_PLZ nvarchar(10),
ev_HNummer nvarchar(10),
ev_Ort nvarchar(50),
ev_Telefon nvarchar(25),
ev_Email nvarchar(50),
ev_Fax nvarchar(50)
);

--Tabelle tbl_EvKategorie
create Table tbl_EvKategorie 
(
ek_EvKategorieID int identity (1,1) primary key,
ek_KatBezeichnung nvarchar(15)
);

--Tabelle tbl_Events
create Table tbl_Events 
(
et_EventID int identity (1,1) primary key,
ev_EvVeranstalterID int,
foreign key(ev_EvVeranstalterID) references tbl_EvVeranstalter,
ek_EvKategorieID int,
foreign key(ek_EvKategorieID) references tbl_EvKategorie
);

--Tabelle tbl_EventDaten
create Table tbl_EventDaten 
(
ed_EvDatenID int identity (1,1) primary key,
et_EventID int,
foreign key(et_EventID) references tbl_Events,
ed_Peis smallmoney,
ed_Beginn datetime,
ed_Ende datetime,
ed_StartOrt nvarchar(50),
ed_ZielOrt nvarchar(50),
ed_MaxTeilnehmer int,
ed_AktTeilnehmer int,
ed_Freigegeben bit,
ed_Rabatt decimal(18,0),
ed_VeranstalterBenachrichtigt bit
);

--Tabelle tbl_Kunden
create Table tbl_Kunden
(
kd_KundenID int identity (1,1) primary key,
kd_Name nvarchar(50),
kd_Vorname nvarchar(50),
kd_Strasse nvarchar(50),
kd_HNummer nvarchar(10),
kd_PLZ nvarchar(10),
kd_Ort nvarchar(50),
kd_Telefon nvarchar(25),
kd_EMail nvarchar(50)
);

--Tabelle tbl_Buchungen
create Table tbl_Buchungen 
(
bu_BuchungsID int identity (1,1) primary key,
kd_KundenID int,
foreign key(kd_KundenID) references tbl_Kunden,
ed_EvDatenID int,
foreign key(ed_EvDatenID) references tbl_EventDaten,
bu_GebuchtePlaetze int,
bu_Bezahlt bit,
bu_Storniert bit,
bu_RechnungErstellt bit
);