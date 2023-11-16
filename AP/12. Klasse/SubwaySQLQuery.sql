--create database subway_21ITA007

use subway_21ita007

create table Abteilung (
aid int identity(1,1) primary key,
aname varchar(255),
)

create table Vorgang (
vid int identity(10,10) primary key,
vname varchar(255) not null,
)

create table Angestellter (
anid int identity(1,1) primary key,
anname varchar(255) not null,
angebDat date,
angeschlecht char(1),
aid int,

foreign key (aid) references Abteilung,
)

create table Ang_Vor (
--avid int identity(1,1) primary key,
anid int,
vid int,

foreign key (anid) references Angestellter,
foreign key (vid) references Vorgang,
primary key (anid,vid)
)

create table Gehalt (
gid int identity(1,1) primary key,
betrag decimal(10,2) not null,
anid int,

foreign key (anid) references Angestellter,
)