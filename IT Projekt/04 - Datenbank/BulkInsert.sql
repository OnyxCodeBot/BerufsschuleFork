bulk insert
	FunEvents_Entwicklung_21ITA007.dbo.tbl_Buchungen
from 'D:\DATA\FunEventsCSV\Buchungen.txt'
with
(
	CODEPAGE = 'ACP',
	FIRSTROW = 2,
	FIELDTERMINATOR = ';'
)

bulk insert
	FunEvents_Entwicklung_21ITA007.dbo.tbl_EventDaten
from 'D:\DATA\FunEventsCSV\EventDaten.txt'
with
(
	CODEPAGE = 'ACP',
	FIRSTROW = 2,
	FIELDTERMINATOR = ';'
)

bulk insert
	FunEvents_Entwicklung_21ITA007.dbo.tbl_Events
from 'D:\DATA\FunEventsCSV\Events.txt'
with
(
	CODEPAGE = 'ACP',
	FIRSTROW = 2,
	FIELDTERMINATOR = ';'
)

bulk insert
	FunEvents_Entwicklung_21ITA007.dbo.tbl_EvKategorie
from 'D:\DATA\FunEventsCSV\EvKategorie.txt'
with
(
	CODEPAGE = 'ACP',
	FIRSTROW = 2,
	FIELDTERMINATOR = ';'
)

bulk insert
	FunEvents_Entwicklung_21ITA007.dbo.tbl_EvVeranstalter
from 'D:\DATA\FunEventsCSV\EvVeranstalter.txt'
with
(
	CODEPAGE = 'ACP',
	FIRSTROW = 2,
	FIELDTERMINATOR = ';'
)

bulk insert
	FunEvents_Entwicklung_21ITA007.dbo.tbl_Kunden
from 'D:\DATA\FunEventsCSV\Kunden.txt'
with
(
	CODEPAGE = 'ACP',
	FIRSTROW = 2,
	FIELDTERMINATOR = ';'
)