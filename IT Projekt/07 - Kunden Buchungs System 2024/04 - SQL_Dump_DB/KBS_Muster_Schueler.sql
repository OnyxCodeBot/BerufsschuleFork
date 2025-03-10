USE [KBS_Muster_IT12A_24]
GO
/****** Object:  Table [dbo].[tbl_Kunden]    Script Date: 11/24/2012 15:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Kunden](
	[kd_KundenID] [int] IDENTITY(1,1) NOT NULL,
	[kd_Name] [nvarchar](50) NOT NULL,
	[kd_Vorname] [nvarchar](50) NOT NULL,
	[kd_Strasse] [nvarchar](50) NOT NULL,
	[kd_HNummer] [nvarchar](10) NOT NULL,
	[kd_PLZ] [nvarchar](10) NOT NULL,
	[kd_Ort] [nvarchar](50) NOT NULL,
	[kd_Telefon] [nvarchar](25) NULL,
	[kd_EMail] [nvarchar](50) NULL,
	[kd_PasswortHash] [nvarchar](255) NULL
 CONSTRAINT [tbl_Kunden_PK] PRIMARY KEY CLUSTERED 
(
	[kd_KundenID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Kunden] ON
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (1, N'Meier', N'Karin', N'Hertwegen', N'77', N'87767', N'Herthausen', N'05564/432656', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (2, N'Huber', N'Martin', N'Hauptstraße', N'34', N'87786', N'Hausham', N'07887/652', N'HM@letsgo.net', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (3, N'Müller', N'Theodor', N'Himmelsjoch', N'77', N'87766', N'Jolling', N'098878/546', NULL, N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (4, N'Maderer', N'Hans', N'Leinstrasse', N'23', N'87767', N'Leinen', NULL, NULL, N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (5, N'Hammer', N'Jürgen', N'Wanderweg', N'23', N'98823', N'Valstadt', N'08274/66456', N'HJ@Hotmail.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (6, N'Huber', N'Joachim', N'Gartenweg', N'78', N'77656', N'Folstadt', N'07723/536253', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (7, N'Wallner', N'Hannes', N'Kolpingweg', N'23', N'87747', N'Pfaffenhausen', N'05563/53672', N'Wallner-h@t-onnline.de', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (8, N'Martini', N'Johann', N'Klopfbergstraße', N'1b', N'66836', N'Petersdorf', N'', N'J.Martini@t-online.de', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (9, N'Hansen', N'Claudia', N'Fellbergstraße', N'97', N'88767', N'Weng', N'', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (10, N'Kaiser', N'Monika', N'Vilstalweg', N'29', N'94474', N'Vilshofen', N'08541/56637554', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (11, N'Herrhausen', N'Alfons', N'Westring', N'388', N'66477', N'Essen', N'064783/53653447', N'AliHerr@t-onnline.de', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (12, N'Thomas', N'Gregor', N'Fassenstraße', N'88', N'74673', N'Reutingen', N'06647/44225', N'TGreg@t-onnline.de', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (13, N'Hellinger', N'Antonia', N'Hansestraße', N'29b', N'95543', N'Hansestadt', N'064782/5536422', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (14, N'Tanner', N'Jochen', N'Himmelsweg', N'66', N'53662', N'Karstadt', N'06647/53664', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (15, N'Petermann', N'Claudia', N'Herrenstraße', N'23', N'63782', N'Jogen an der Alz', N'063565/ 45637', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (16, N'Wallinger', N'Johann', N'Witzelsbergerweg', N'34', N'97746', N'Unterwalching', N'06647/ 534563', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (17, N'Maler', N'Gustav', N'Hornweg', N'45', N'74463', N'Hammelsberg', N'03886/534577', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (18, N'Meier', N'Hubert', N'Hans-Walcher-Strasse', N'23', N'86447', N'Fortheim', N'06647/67448', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (19, N'Meier', N'Ralf', N'Hochstrasse', N'16', N'86654', N'Goding', N'', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (20, N'Hessel', N'Robert', N'Am Walchensee', N'3', N'87767', N'Mellingen', N'', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (21, N'Martini', N'Walter', N'Herbststrasse', N'228', N'76647', N'Mannhof', N'', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (22, N'Huber', N'Karl', N'Weng', N'23', N'86647', N'Weng', N'', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (23, N'Huber', N'Anton', N'Wengenbergstraße', N'22', N'96675', N'Vilshochheim', N'', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (24, N'Hermalser', N'Josef', N'Briganserstraße', N'33a', N'84463', N'Borching', N'06647-54663', N'hj@t-online.de', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (25, N'Walser', N'Hermine', N'Am Graut', N'3', N'75536', N'Rannacker', N'06635/53672', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (26, N'Maler', N'Hans', N'Geringstraße', N'95', N'73383', N'Ranzing', N'04425/ 536662', N'', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (27, N'Müller', N'Fritz', N'Hahnenweg', N'3', N'98765', N'Friedrichshain', N'09456/63262', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (28, N'Andres', N'Gernot', N'Stresemannallee', N'23', N'76543', N'Oberpleichfeld', N'09876/5252', N'abqwc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (29, N'Bohlen', N'Dieter', N'Hugenottenweg', N'7a', N'12345', N'Berlin', N'01234/62363', N'abdsfc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (30, N'Feldweg', N'Verona', N'Blümchenstrasse', N'2', N'87654', N'München', N'0876/62652', N'abcdsfsdf@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (31, N'Schröder', N'German', N'Kohlrabenfurt', N'54', N'42526', N'Kehl', N'03562/5252', N'dsfsabc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (32, N'Ehrhard', N'Heinz', N'Kennedyallee', N'54', N'87227', N'Bonn', N'095/6262', N'abcsfsf@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (33, N'Lübke', N'Heinz', N'Präsidentenstrasse', N'3', N'52212', N'Stuttgart', N'0715/6262', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (34, N'Bau', N'Johannes', N'Platz des Friedens', N'34', N'97941', N'Tauberbischofsheim', N'09341/6543', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (35, N'Grün', N'Norbert', N'Automatenhalle', N'126a', N'87654', N'Lübeck', N'08765/6262', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (36, N'Hilfmir', N'Doch', N'Mäuerlein', N'2', N'54378', N'Unterthulba', N'05227/6262', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (37, N'Lorenz', N'Jens', N'Entenweg', N'7', N'76362', N'Wangenblum', N'07373/63636', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (38, N'Wiesmann', N'Simon', N'St. Peter-Str.', N'15', N'97274', N'Leinach', N'08383/773', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (39, N'Beran', N'Andreas', N'Geschister-Scholl-Ring', N'16', N'97828', N'Marktheidenfeld', N'0525/7373', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (40, N'Müllender', N'Jörg', N'Neue Anlage', N'22', N'97342', N'Obernbreit', N'0125/555', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (41, N'Meyer', N'Christoph', N'Alter Weg', N'34', N'72728', N'Schwesterndorf', N'03698/4478', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (42, N'Lamprecht', N'Stefan', N'Schweinfurterstr.', N'13', N'97464', N'Niederwerrn', N'0879/563', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (43, N'Willerding', N'Armin', N'Bismarckstr', N'12c', N'97080', N'Würzburg', N'01458/563', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (44, N'Neubauer', N'Yvonne', N'Gartenstr.', N'9', N'97279', N'Prosselsheim', N'03698/852', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (45, N'Joswig', N'Björn-Olaf', N'Laubweg', N'87', N'87654', N'Günthersleben', N'02569/445', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (46, N'Röhm', N'Simon', N'Sandgrubenstr.', N'13', N'97291', N'Thüngersheim', N'0145/8523', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (47, N'Vieler', N'Jan', N'Annastr.', N'10', N'97072', N'Würzburg', N'03698/8963', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (48, N'Zeller', N'Christian', N'BetaWeg', N'13', N'87643', N'Blaurettersheim', N'0874/552', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (49, N'Wagner', N'Christian', N'Breslauer Str.', N'62', N'97877', N'Wertheim', N'0236/598', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (50, N'Trinkenschuh', N'Vitalij', N'Bayernstr.', N'6', N'97078', N'Würzburg', N'02369/852', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (51, N'Reinhart', N'Lukas', N'Rathausstr.', N'28', N'97900', N'Külsheim', N'01489/5632', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (52, N'Schmidt', N'Daniel', N'Lärchenstraße', N'10', N'97839', N'Esselbach', N'03698/8952', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (53, N'Steinle', N'Falk', N'Nikolaushöhe', N'15c', N'97218', N'Gerbrunn', N'03652/5874', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (54, N'Wirth', N'Martin', N'Saumstraße', N'32', N'97816', N'Eisleben', N'05698/5214', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (55, N'Kürbitz', N'Sebastian', N'Austraße', N'73', N'97222', N'Rimpar', N'02369/8521', N'abc@123.com', N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (56, N'Sonnenschein', N'Kurt', N'Blumenweg', N'18', N'98765', N'Obertupfing', N'09423/63636', NULL, N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[tbl_Kunden] ([kd_KundenID], [kd_Name], [kd_Vorname], [kd_Strasse], [kd_HNummer], [kd_PLZ], [kd_Ort], [kd_Telefon], [kd_EMail], [kd_PasswortHash]) VALUES (57, N'Koller', N'Herbert', N'Hanseweg', N'23', N'74485', N'Hannig-Ost', N'03374/473883', N'', N'202cb962ac59075b964b07152d234b70')
SET IDENTITY_INSERT [dbo].[tbl_Kunden] OFF
/****** Object:  Table [dbo].[tbl_EvVeranstalter]    Script Date: 11/24/2012 15:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_EvVeranstalter](
	[ev_EvVeranstalterID] [int] IDENTITY(1,1) NOT NULL,
	[ev_Firma] [nvarchar](50) NOT NULL,
	[ev_Strasse] [nvarchar](50) NOT NULL,
	[ev_PLZ] [nvarchar](10) NOT NULL,
	[ev_HNummer] [nvarchar](10) NOT NULL,
	[ev_Ort] [nvarchar](50) NOT NULL,
	[ev_Telefon] [nvarchar](25) NULL,
	[ev_EMail] [nvarchar](50) NULL,
	[ev_Fax] [nvarchar](50) NULL,
 CONSTRAINT [tbl_EvVeranstalter_PK] PRIMARY KEY CLUSTERED 
(
	[ev_EvVeranstalterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_EvVeranstalter] ON
INSERT [dbo].[tbl_EvVeranstalter] ([ev_EvVeranstalterID], [ev_Firma], [ev_Strasse], [ev_PLZ], [ev_HNummer], [ev_Ort], [ev_Telefon], [ev_EMail], [ev_Fax]) VALUES (1, N'Falschirmspringverein Remmscheid', N'Am Flugplatz', N'76678', N'1', N'Remmscheid', N'08876/54456', NULL, NULL)
INSERT [dbo].[tbl_EvVeranstalter] ([ev_EvVeranstalterID], [ev_Firma], [ev_Strasse], [ev_PLZ], [ev_HNummer], [ev_Ort], [ev_Telefon], [ev_EMail], [ev_Fax]) VALUES (2, N'Extreme Tours DE', N'Hammerplatz', N'76677', N'15b', N'Halling', N'08869/74463', N'GetTheFun@netcom.net', N'08869/74465              ')
INSERT [dbo].[tbl_EvVeranstalter] ([ev_EvVeranstalterID], [ev_Firma], [ev_Strasse], [ev_PLZ], [ev_HNummer], [ev_Ort], [ev_Telefon], [ev_EMail], [ev_Fax]) VALUES (3, N'Bike n Fun', N'Hauptstraße', N'78778', N'34', N'Gütersdorf', N'09889/6529987', N'BnF@Hotmail.com', N'09889/6529988            ')
INSERT [dbo].[tbl_EvVeranstalter] ([ev_EvVeranstalterID], [ev_Firma], [ev_Strasse], [ev_PLZ], [ev_HNummer], [ev_Ort], [ev_Telefon], [ev_EMail], [ev_Fax]) VALUES (4, N'Climb with U', N'Scheller Str.', N'77872', N'5', N'Dorstadt', N'09664/7667-300', N'info@CWU.net', N'09664/7667-301           ')
INSERT [dbo].[tbl_EvVeranstalter] ([ev_EvVeranstalterID], [ev_Firma], [ev_Strasse], [ev_PLZ], [ev_HNummer], [ev_Ort], [ev_Telefon], [ev_EMail], [ev_Fax]) VALUES (5, N'Tauchsportfreunde Unterhaching', N'Irmenweg', N'95567', N'224b', N'Unterhaching', N'09211/65657', NULL, NULL)
INSERT [dbo].[tbl_EvVeranstalter] ([ev_EvVeranstalterID], [ev_Firma], [ev_Strasse], [ev_PLZ], [ev_HNummer], [ev_Ort], [ev_Telefon], [ev_EMail], [ev_Fax]) VALUES (6, N'Klettervereinigung Eberswald', N'Hanser - Straße', N'56645', N'45', N'Eberswald', N'06775-64563', N'Klettern.Eberswald@freemail.com', N'06775-64562')
INSERT [dbo].[tbl_EvVeranstalter] ([ev_EvVeranstalterID], [ev_Firma], [ev_Strasse], [ev_PLZ], [ev_HNummer], [ev_Ort], [ev_Telefon], [ev_EMail], [ev_Fax]) VALUES (7, N'Skisportverein Emmersee', N'Uferstraße', N'96675', N'12', N'Irring am Emmersee', N'08865-38763', N'SkiAmEmmersee@Hotmail.net', NULL)
INSERT [dbo].[tbl_EvVeranstalter] ([ev_EvVeranstalterID], [ev_Firma], [ev_Strasse], [ev_PLZ], [ev_HNummer], [ev_Ort], [ev_Telefon], [ev_EMail], [ev_Fax]) VALUES (8, N'Trend Sports GmbH', N'Halser-Str.', N'95546', N'29b', N'Walching', N'06635-30-300', N'TSGmbH@Provider.com', N'06635-30-301')
INSERT [dbo].[tbl_EvVeranstalter] ([ev_EvVeranstalterID], [ev_Firma], [ev_Strasse], [ev_PLZ], [ev_HNummer], [ev_Ort], [ev_Telefon], [ev_EMail], [ev_Fax]) VALUES (9, N'La Strada Spa', N'Via Allende', N'40000', N'12', N'Modena', N'066/76656/62445', NULL, N'066/76656/62449')
INSERT [dbo].[tbl_EvVeranstalter] ([ev_EvVeranstalterID], [ev_Firma], [ev_Strasse], [ev_PLZ], [ev_HNummer], [ev_Ort], [ev_Telefon], [ev_EMail], [ev_Fax]) VALUES (10, N'Max Tours', N'Wengenstraße', N'77678', N'8', N'Rendershain', N'06674-777656', N'MaxTours@providers.net', NULL)
SET IDENTITY_INSERT [dbo].[tbl_EvVeranstalter] OFF
/****** Object:  Table [dbo].[tbl_EvKategorie]    Script Date: 11/24/2012 15:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_EvKategorie](
	[ek_EvKategorieID] [int] IDENTITY(1,1) NOT NULL,
	[ek_KatBezeichnung] [nvarchar](15) NOT NULL,
 CONSTRAINT [tbl_EvKategorie_PK] PRIMARY KEY CLUSTERED 
(
	[ek_EvKategorieID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_EvKategorie] ON
INSERT [dbo].[tbl_EvKategorie] ([ek_EvKategorieID], [ek_KatBezeichnung]) VALUES (1, N'FunSports')
INSERT [dbo].[tbl_EvKategorie] ([ek_EvKategorieID], [ek_KatBezeichnung]) VALUES (2, N'AdventureSports')
INSERT [dbo].[tbl_EvKategorie] ([ek_EvKategorieID], [ek_KatBezeichnung]) VALUES (3, N'ExtremeSports')
INSERT [dbo].[tbl_EvKategorie] ([ek_EvKategorieID], [ek_KatBezeichnung]) VALUES (4, N'Diving')
INSERT [dbo].[tbl_EvKategorie] ([ek_EvKategorieID], [ek_KatBezeichnung]) VALUES (5, N'Skiing')
INSERT [dbo].[tbl_EvKategorie] ([ek_EvKategorieID], [ek_KatBezeichnung]) VALUES (6, N'FutureSports')
INSERT [dbo].[tbl_EvKategorie] ([ek_EvKategorieID], [ek_KatBezeichnung]) VALUES (7, N'TrendSports')
INSERT [dbo].[tbl_EvKategorie] ([ek_EvKategorieID], [ek_KatBezeichnung]) VALUES (8, N'FamilySports')
SET IDENTITY_INSERT [dbo].[tbl_EvKategorie] OFF
/****** Object:  Table [dbo].[tbl_Events]    Script Date: 11/24/2012 15:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Events](
	[et_EventID] [int] IDENTITY(1,1) NOT NULL,
	[ev_EvVeranstalterID] [int] NOT NULL,
	[ek_EvKategorieID] [int] NOT NULL,
	[et_Bezeichnung] [nvarchar](50) NOT NULL,
	[et_Beschreibung] [text] NULL,
 CONSTRAINT [tbl_EvBeschreibung_PK] PRIMARY KEY CLUSTERED 
(
	[et_EventID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Events] ON
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (1, 1, 1, N'Skydiving ', N'Skydiving am Flugplatz Remmscheid. Hoch über Deutschland taucht sichs am besten.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (2, 2, 2, N'Tracking durch Afrika', N'Geführte Trackingtour durch Afrika. Durch die glühenden Wüstenlandschaften des heißen Kontinents.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (3, 3, 1, N'Downhill Race', N'Downhill Radrennen am Wilden Kaiser. Rennen um das goldene Mountainbike.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (4, 4, 2, N'Free Climbing am Matterhorn', N'Free Climbing in schwindelnder Höhe in den schweizer Alpen. Extrem aber wirklich gut.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (5, 3, 1, N'Adria Cup', N'Radrennen von den Alpen zur Adria. Verpflegung und Übernachtung inclusive. 
')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (6, 5, 4, N'Deep Blue Meeting', N'Tauchertreffen am Attasee. Campingplatz ist reserviert.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (7, 2, 3, N'Expedition zum Südpol', N'Mit dem Hubschrauber zum Südpol. Die letzten 20 km werden zu Fuß zurückgelegt. Incl Flug und Übernachtungen.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (8, 4, 1, N'Klettern am Wilden Kaiser', N'Leichte Klettertour für Einsteiger. sehr einfach...')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (9, 5, 1, N'Unterhachinger Stadtmarathon', N'Rennen um die Stadtmeisterschaft')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (10, 1, 1, N'Tandemspringen am Flughafen Remmscheid', N'Erste Versuche für Anfänger.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (11, 5, 4, N'Tauchen auf den Malediven', N'Einmaliges Taucherlebnis im sonnigen Süden. Incl. Flug, Übernachtung und Verpflegung.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (12, 1, 1, N'Paragliding über Remmscheid', N'Paragliding über dem Flughafen Remmscheid')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (13, 1, 1, N'Balonfahren über Remmscheid', N'Kleine Balonfahrt')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (14, 2, 3, N'Himalaya Expedition', N'14 tägige Expedition durch das Himalaya Gebirge. Übernachtung im Zelt. Träger und Yaks incl.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (15, 2, 3, N'Überleben im Amazonas Becken', N'Überlebenstraining im Dschungel Südamerikas. Inclusive Flug und Verpflegung.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (16, 5, 1, N'Rafting auf der Isar', N'Raftingtour vor den Toren Münchens')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (17, 1, 1, N'Bunjee Jumping an der Remmscheider Brücke', N'Bunjee Jumping an der Remmscheider Brücke. Kopfüber in den Himmel.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (18, 5, 4, N'Tiefseetauchen im Marianegraben', N'Tiefseetauchen im Marianegraben. Beeindruckende Erlebnisse in der Tiefe des Meeres. Flug, Schiff, Übernachtung und Kost inclusive...')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (19, 1, 2, N'Drachenfliegen in den Dolomiten', N'Drachenfliegen hoch über den Dolomiten. Anfängerkurs. Ausrüstung ist nicht erforderlich')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (20, 6, 8, N'Familienwanderung auf den Großen Arber', N'Einfacher Tagesausflug für Familien mit Kindern ab 4 Jahren. Festes Schuhwerk ist gefragt! Gemütliche Brotzeit am Gipfel incl.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (21, 7, 5, N'Heli Skiing am Mount Mc Kinley', N'Mit dem Hubschrauber ins reine Wintervergnügen. Flug, Unterkunft und Verpflegung incl.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (22, 5, 4, N'Tauchen am Südpol', N'Kreuzfahrt zum Südpol mit Tauchgängen in der eisigen See.')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (23, 4, 2, N'Rafting am Fölser Lech', N'Durch die eisigen Fluten der Föls')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (24, 8, 7, N'Blade Night in Zwiesel', N'Bladen bis in den frühen Morgen')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (25, 9, 2, N'Bunjee Jumping', N'Sprung in die Tiefe der Brücke von Verona')
INSERT [dbo].[tbl_Events] ([et_EventID], [ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (26, 4, 2, N'Tracking durch die Rocky Mountains', N'Wunderbare Bergtour durch die Wildniss der Rockies. Eigenständige Anreise.')
SET IDENTITY_INSERT [dbo].[tbl_Events] OFF
/****** Object:  StoredProcedure [dbo].[spInsVeranstalter]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsVeranstalter]
(
	@ev_Firma nvarchar(50),
	@ev_Strasse nvarchar(50),
	@ev_PLZ nvarchar(10),
	@ev_HNummer nvarchar(10),
	@ev_Ort nvarchar(50),
	@ev_Telefon nvarchar(25),
	@ev_EMail nvarchar(50),
	@ev_Fax nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [tbl_EvVeranstalter] ([ev_Firma], [ev_Strasse], [ev_PLZ], [ev_HNummer], [ev_Ort], [ev_Telefon], [ev_EMail], [ev_Fax]) VALUES (@ev_Firma, @ev_Strasse, @ev_PLZ, @ev_HNummer, @ev_Ort, @ev_Telefon, @ev_EMail, @ev_Fax);
	
SELECT ev_EvVeranstalterID, ev_Firma, ev_Strasse, ev_PLZ, ev_HNummer, ev_Ort, ev_Telefon, ev_EMail, ev_Fax FROM tbl_EvVeranstalter WHERE (ev_EvVeranstalterID = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[spInsKunde]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spInsKunde    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spInsKunde]

	(
		@kd_Name nvarchar(50) ,
		@kd_Vorname nvarchar(50) ,
		@kd_Strasse nvarchar(50) ,
		@kd_HNummer nvarchar(10) ,
		@kd_PLZ nvarchar(10) ,
		@kd_Ort nvarchar(50) ,
		@kd_Telefon nvarchar(25) ,
		@kd_EMail nvarchar(50) ,
		@kd_KundenID int OUTPUT
	)

AS
	 SET NOCOUNT OFF
	 INSERT INTO tbl_Kunden(kd_Name, kd_Vorname, kd_Strasse, kd_HNummer, kd_PLZ, kd_Ort, kd_Telefon, kd_EMail)
VALUES(@kd_Name, @kd_Vorname, @kd_Strasse, @kd_HNummer, @kd_PLZ, @kd_Ort, @kd_Telefon, @kd_EMail);
	  	SELECT @kd_KundenID = kd_KundenID  
	  	FROM tbl_Kunden WHERE (kd_KundenID = @@IDENTITY); 

	  	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spInsKategorie]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsKategorie]
(
	@ek_KatBezeichnung nvarchar(15)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [tbl_EvKategorie] ([ek_KatBezeichnung]) VALUES (@ek_KatBezeichnung);
	
SELECT ek_EvKategorieID, ek_KatBezeichnung FROM tbl_EvKategorie WHERE (ek_EvKategorieID = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[spDelVeranstalter]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDelVeranstalter]
(
	@Original_ev_EvVeranstalterID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [tbl_EvVeranstalter] WHERE (([ev_EvVeranstalterID] = @Original_ev_EvVeranstalterID))
GO
/****** Object:  StoredProcedure [dbo].[spDelKategorie]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[spDelKategorie]
(
	@Original_ek_EvKategorieID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [tbl_EvKategorie] WHERE (([ek_EvKategorieID] = @Original_ek_EvKategorieID))
GO
/****** Object:  StoredProcedure [dbo].[spLoadKatBezeichnung]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spLoadKatBezeichnung    Script Date: 26.07.2004 10:32:49 ******/
CREATE PROCEDURE [dbo].[spLoadKatBezeichnung]

AS
	SELECT COUNT (ek_KatBezeichnung) FROM tbl_EvKategorie;
	SELECT ek_KatBezeichnung FROM tbl_EvKategorie;
	
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spSelectKategorie]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectKategorie]
AS
	SET NOCOUNT ON;
SELECT     tbl_EvKategorie.*
FROM         tbl_EvKategorie
GO
/****** Object:  StoredProcedure [dbo].[spUpdtVeranstalter]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdtVeranstalter]
(
	@ev_Firma nvarchar(50),
	@ev_Strasse nvarchar(50),
	@ev_PLZ nvarchar(10),
	@ev_HNummer nvarchar(10),
	@ev_Ort nvarchar(50),
	@ev_Telefon nvarchar(25),
	@ev_EMail nvarchar(50),
	@ev_Fax nvarchar(50),
	@Original_ev_EvVeranstalterID int,
	@ev_EvVeranstalterID int
)
AS
	SET NOCOUNT OFF;
UPDATE [tbl_EvVeranstalter] SET [ev_Firma] = @ev_Firma, [ev_Strasse] = @ev_Strasse, [ev_PLZ] = @ev_PLZ, [ev_HNummer] = @ev_HNummer, [ev_Ort] = @ev_Ort, [ev_Telefon] = @ev_Telefon, [ev_EMail] = @ev_EMail, [ev_Fax] = @ev_Fax WHERE (([ev_EvVeranstalterID] = @Original_ev_EvVeranstalterID));
	
SELECT ev_EvVeranstalterID, ev_Firma, ev_Strasse, ev_PLZ, ev_HNummer, ev_Ort, ev_Telefon, ev_EMail, ev_Fax FROM tbl_EvVeranstalter WHERE (ev_EvVeranstalterID = @ev_EvVeranstalterID)
GO
/****** Object:  StoredProcedure [dbo].[spSelectVeranstalter]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectVeranstalter]
AS
	SET NOCOUNT ON;
SELECT     ev_EvVeranstalterID, ev_Firma, ev_Strasse, ev_PLZ, ev_HNummer, ev_Ort, ev_Telefon, ev_EMail, ev_Fax
FROM         tbl_EvVeranstalter
GO
/****** Object:  StoredProcedure [dbo].[spSucheKunde]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spSucheKunde    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spSucheKunde]
/* UC 01.1, 02.1, 01.5, 02.1.2 Sucht einen Kunden anhand des Namens */
(
	@kd_Name nvarchar(50)
)

AS
SELECT COUNT (tbl_Kunden.kd_KundenID)
FROM tbl_Kunden
WHERE (kd_Name LIKE @kd_Name)

SELECT     kd_KundenID, kd_Name, kd_Vorname, kd_Strasse, kd_HNummer, kd_PLZ, kd_Ort, kd_Telefon, kd_EMail 
FROM tbl_Kunden
  WHERE     (kd_Name LIKE @kd_Name)
	
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spUpdtKunde]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spUpdtKunde    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spUpdtKunde]
	(
		@kd_Name nvarchar(50) ,
		@kd_Vorname nvarchar(50) ,
		@kd_Strasse nvarchar(50) ,
		@kd_HNummer nvarchar(10) ,
		@kd_PLZ nvarchar(10) ,
		@kd_Ort nvarchar(50) ,
		@kd_Telefon nvarchar(25) ,
		@kd_EMail nvarchar(50) ,
		@kd_KundenID int 
	)

AS
	SET NOCOUNT OFF;
	UPDATE tbl_Kunden SET kd_Name = @kd_Name, kd_Vorname = @kd_Vorname, kd_Strasse = @kd_Strasse, kd_HNummer = @kd_HNummer, kd_PLZ = @kd_PLZ, kd_Ort = @kd_Ort, kd_Telefon = @kd_Telefon, kd_EMail = @kd_EMail 
	WHERE (kd_KundenID = @kd_KundenID);    
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spUpdtKategorie]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdtKategorie]
(
	@ek_KatBezeichnung nvarchar(15),
	@Original_ek_EvKategorieID int,
	@ek_EvKategorieID int
)
AS
	SET NOCOUNT OFF;
UPDATE [tbl_EvKategorie] SET [ek_KatBezeichnung] = @ek_KatBezeichnung WHERE (([ek_EvKategorieID] = @Original_ek_EvKategorieID));
	
SELECT ek_EvKategorieID, ek_KatBezeichnung FROM tbl_EvKategorie WHERE (ek_EvKategorieID = @ek_EvKategorieID)
GO
/****** Object:  StoredProcedure [dbo].[spUpdtEvents]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdtEvents]
(
	@ev_EvVeranstalterID int,
	@ek_EvKategorieID int,
	@et_Bezeichnung nvarchar(50),
	@et_Beschreibung text,
	@Original_et_EventID int,
	@et_EventID int
)
AS
	SET NOCOUNT OFF;
UPDATE [tbl_Events] SET [ev_EvVeranstalterID] = @ev_EvVeranstalterID, [ek_EvKategorieID] = @ek_EvKategorieID, [et_Bezeichnung] = @et_Bezeichnung, [et_Beschreibung] = @et_Beschreibung WHERE (([et_EventID] = @Original_et_EventID));
	
SELECT et_EventID, ev_EvVeranstalterID, ek_EvKategorieID, et_Bezeichnung, et_Beschreibung FROM tbl_Events WHERE (et_EventID = @et_EventID)
GO
/****** Object:  StoredProcedure [dbo].[spSelectEvents]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectEvents]
AS
	SET NOCOUNT ON;
SELECT     et_EventID, ev_EvVeranstalterID, ek_EvKategorieID, et_Bezeichnung, et_Beschreibung
FROM         tbl_Events
ORDER BY et_Bezeichnung
GO
/****** Object:  StoredProcedure [dbo].[spDelEvents]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDelEvents]
(
	@Original_et_EventID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [tbl_Events] WHERE (([et_EventID] = @Original_et_EventID))
GO
/****** Object:  StoredProcedure [dbo].[spInsEvents]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsEvents]
(
	@ev_EvVeranstalterID int,
	@ek_EvKategorieID int,
	@et_Bezeichnung nvarchar(50),
	@et_Beschreibung text
)
AS
	SET NOCOUNT OFF;
INSERT INTO [tbl_Events] ([ev_EvVeranstalterID], [ek_EvKategorieID], [et_Bezeichnung], [et_Beschreibung]) VALUES (@ev_EvVeranstalterID, @ek_EvKategorieID, @et_Bezeichnung, @et_Beschreibung);
	
SELECT et_EventID, ev_EvVeranstalterID, ek_EvKategorieID, et_Bezeichnung, et_Beschreibung FROM tbl_Events WHERE (et_EventID = SCOPE_IDENTITY())
GO
/****** Object:  Table [dbo].[tbl_EventDaten]    Script Date: 11/24/2012 15:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_EventDaten](
	[ed_EvDatenID] [int] IDENTITY(1,1) NOT NULL,
	[et_EventID] [int] NOT NULL,
	[ed_Preis] [smallmoney] NOT NULL,
	[ed_Beginn] [datetime] NOT NULL,
	[ed_Ende] [datetime] NOT NULL,
	[ed_StartOrt] [nvarchar](50) NOT NULL,
	[ed_Zielort] [nvarchar](50) NULL,
	[ed_MaxTeilnehmer] [int] NOT NULL,
	[ed_AktTeilnehmer] [int] NOT NULL,
	[ed_Freigegeben] [bit] NOT NULL,
	[ed_Rabatt] [decimal](18, 0) NOT NULL,
	[ed_VeranstalterBenachrichtigt] [bit] NOT NULL,
 CONSTRAINT [tbl_Events_PK] PRIMARY KEY CLUSTERED 
(
	[ed_EvDatenID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_EventDaten] ON
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (1, 1, 266.0000, CAST(0x00009F320083D600 AS DateTime), CAST(0x00009F3200F73140 AS DateTime), N'Remmingen Flugplatz', NULL, 7, 0, 1, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (2, 1, 266.0000, CAST(0x00009F48009450C0 AS DateTime), CAST(0x00009F48010BCAB0 AS DateTime), N'Remmingen Flugplatz', N'', 8, 0, 0, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (3, 2, 2689.0000, CAST(0x00009EC30062E080 AS DateTime), CAST(0x00009ECB00F73140 AS DateTime), N'Simbabwe', N'Timbuktu', 5, 3, 1, CAST(20 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (4, 3, 51.0000, CAST(0x00009EB00062E080 AS DateTime), CAST(0x00009EB00151D460 AS DateTime), N'Kolling an der Laber', N'Kolling an der Laber', 6, 0, 1, CAST(12 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (5, 2, 2689.0000, CAST(0x00009ECE0062E080 AS DateTime), CAST(0x00009ED600F73140 AS DateTime), N'Timbuktu', N'Simbabwe', 5, 1, 1, CAST(20 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (6, 4, 1029.0000, CAST(0x00009F180062E080 AS DateTime), CAST(0x00009F1901391C40 AS DateTime), N'Klein Dorfen Schweiz', N'', 5, 0, 0, CAST(21 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (7, 5, 175.0000, CAST(0x00009EBB0062E080 AS DateTime), CAST(0x00009EBC016A8C80 AS DateTime), N'Tarvisio', N'Triest', 8, 7, 1, CAST(12 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (8, 6, 257.0000, CAST(0x00009F3900A4CB80 AS DateTime), CAST(0x00009F3B017B0740 AS DateTime), N'Artstadt', N'Artstadt', 5, 4, 1, CAST(16 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (9, 7, 5570.0000, CAST(0x00009FC00041EB00 AS DateTime), CAST(0x00009FC901876350 AS DateTime), N'Hamburg Flughafen', N'Hamburg Flughafen', 3, 0, 1, CAST(25 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (10, 8, 339.0000, CAST(0x00009EDA0041EB00 AS DateTime), CAST(0x00009EDB0107AC00 AS DateTime), N'Kieming', N'Kieming', 5, 0, 1, CAST(22 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (11, 9, 20.0000, CAST(0x00009EE100895440 AS DateTime), CAST(0x00009EE10107AC00 AS DateTime), N'Unterhaching, Stadtplatz', N'Unterhaching, Stadtplatz', 40, 13, 1, CAST(10 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (12, 10, 250.0000, CAST(0x00009EEB00A4CB80 AS DateTime), CAST(0x00009EEB0128A180 AS DateTime), N'Remmscheid', N'Remmscheid', 4, 0, 0, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (13, 11, 1999.0000, CAST(0x00009ECE0062E080 AS DateTime), CAST(0x00009ED30083D600 AS DateTime), N'Flughafen München', N'Flughafen München', 4, 2, 1, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (14, 13, 189.0000, CAST(0x00009F8700E6B680 AS DateTime), CAST(0x00009F8701499700 AS DateTime), N'Flugplatz Remmscheid', N'Flugplatz Remmscheid', 3, 3, 1, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (15, 14, 7899.0000, CAST(0x00009EDA004A2860 AS DateTime), CAST(0x00009EE7016A8C80 AS DateTime), N'Katmandu', N'Katmandu', 2, 0, 0, CAST(20 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (16, 12, 223.0000, CAST(0x00009F2900000000 AS DateTime), CAST(0x00009F2900000000 AS DateTime), N'Flugplatz Remmscheid', NULL, 6, 1, 1, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (17, 15, 3400.0000, CAST(0x0000A0290062E080 AS DateTime), CAST(0x0000A03901499700 AS DateTime), N'Rio', N'Tuangeno', 2, 0, 0, CAST(25 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (18, 16, 69.0000, CAST(0x00009EE40083D600 AS DateTime), CAST(0x00009EE401499700 AS DateTime), N'München', NULL, 8, 0, 0, CAST(25 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (19, 3, 50.0000, CAST(0x00009E9A0062E080 AS DateTime), CAST(0x00009E9A0151D460 AS DateTime), N'Kolling an der Laber', N'Kolling an der Laber', 5, 1, 1, CAST(12 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (20, 10, 250.0000, CAST(0x00009EF4009450C0 AS DateTime), CAST(0x00009EF40107AC00 AS DateTime), N'Remmscheid', N'Remmscheid', 4, 0, 0, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (21, 10, 250.0000, CAST(0x00009EF300A4CB80 AS DateTime), CAST(0x00009EF30107AC00 AS DateTime), N'Remmscheid', N'Remmscheid', 5, 3, 1, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (22, 10, 250.0000, CAST(0x00009F0000A4CB80 AS DateTime), CAST(0x00009F0000000000 AS DateTime), N'Remmscheid', N'Remmscheid', 3, 0, 0, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (23, 10, 250.0000, CAST(0x00009F2A00A4CB80 AS DateTime), CAST(0x00009F2A0107AC00 AS DateTime), N'Remmscheid', N'Remmscheid', 4, 0, 0, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (24, 10, 250.0000, CAST(0x00009ED900A4CB80 AS DateTime), CAST(0x00009ED90107AC00 AS DateTime), N'Remmscheid', N'Remmscheid', 5, 0, 1, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (25, 3, 50.0000, CAST(0x00009F0B0062E080 AS DateTime), CAST(0x00009F0B0151D460 AS DateTime), N'Kolling an der Laber', N'Kolling an der Laber', 5, 2, 1, CAST(12 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (26, 4, 1029.0000, CAST(0x00009F470062E080 AS DateTime), CAST(0x00009F4801391C40 AS DateTime), N'Klein Dorfen Schweiz', NULL, 2, 0, 0, CAST(21 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (27, 16, 69.0000, CAST(0x00009F4300000000 AS DateTime), CAST(0x00009F4300000000 AS DateTime), N'München', NULL, 8, 0, 0, CAST(10 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (28, 17, 120.0000, CAST(0x00009F5F00000000 AS DateTime), CAST(0x00009F5F00000000 AS DateTime), N'Remmscheid', N'Remmscheid', 29, 0, 0, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (29, 17, 120.0000, CAST(0x00009F0B00000000 AS DateTime), CAST(0x00009F0B00000000 AS DateTime), N'Remmscheid', N'Remmscheid', 21, 0, 0, CAST(0 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (30, 18, 3349.0000, CAST(0x00009F8400000000 AS DateTime), CAST(0x00009F8C00000000 AS DateTime), N'Flughafen Hamburg', N'Flughafen Hamburg', 4, 0, 0, CAST(25 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (31, 8, 339.0000, CAST(0x00009F480041EB00 AS DateTime), CAST(0x00009F480107AC00 AS DateTime), N'Kieming', N'Kieming', 5, 0, 0, CAST(22 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (32, 18, 3349.0000, CAST(0x00009F6B00000000 AS DateTime), CAST(0x00009F7300000000 AS DateTime), N'Flughafen Hamburg', N'Flughafen Hamburg', 2, 2, 1, CAST(25 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (33, 19, 322.0000, CAST(0x00009F0D00000000 AS DateTime), CAST(0x00009F0D00000000 AS DateTime), N'Maria Alm', N'Maria Alm', 5, 2, 1, CAST(18 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (34, 20, 20.0000, CAST(0x00009F0C0062E080 AS DateTime), CAST(0x00009F0C0128A180 AS DateTime), N'Bayerisch Eisenstein', N'Bayerisch Eisenstein', 18, 5, 1, CAST(12 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (35, 11, 1999.0000, CAST(0x00009EA200000000 AS DateTime), CAST(0x00009E6E00000000 AS DateTime), N'Flughafen Hamburg', N'Flughafen Hamburg', 4, 0, 1, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (36, 21, 1689.0000, CAST(0x00009EA4005265C0 AS DateTime), CAST(0x00009E6E0041EB00 AS DateTime), N'Flughafen München', N'Flughafen München', 6, 3, 1, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (37, 22, 2555.0000, CAST(0x00009EA6001B7740 AS DateTime), CAST(0x00009E7100D0BD80 AS DateTime), N'Flughafen München', N'Flughafen München', 2, 2, 1, CAST(25 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (38, 19, 322.0000, CAST(0x00009F3100000000 AS DateTime), CAST(0x00009F3100000000 AS DateTime), N'Maria Alm', NULL, 2, 0, 0, CAST(18 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (39, 23, 199.0000, CAST(0x0000A03C0062E080 AS DateTime), CAST(0x0000A03C0128A180 AS DateTime), N'Fölsing, AUT', N'Fölsing, AUT', 15, 7, 1, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (40, 23, 199.0000, CAST(0x00009F280062E080 AS DateTime), CAST(0x00009F280128A180 AS DateTime), N'Fölsing, AUT', N'Fölsing, AUT', 12, 0, 0, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (41, 24, 5.0000, CAST(0x0000A0760128A180 AS DateTime), CAST(0x0000A0770062E080 AS DateTime), N'Zwiesel', N'Zwiesel', 20, 3, 1, CAST(10 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (42, 25, 0.0000, CAST(0x00009E7B0083D600 AS DateTime), CAST(0x00009E7B0128A180 AS DateTime), N'Verona', N'Verona', 15, 0, 0, CAST(15 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (43, 26, 180.0000, CAST(0x0000A0B60062E080 AS DateTime), CAST(0x0000A0BD0128A180 AS DateTime), N'Great Falls', N'Great Falls', 6, 0, 0, CAST(20 AS Decimal(18, 0)), 0)
INSERT [dbo].[tbl_EventDaten] ([ed_EvDatenID], [et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (44, 26, 180.0000, CAST(0x0000A0860062E080 AS DateTime), CAST(0x0000A08E0128A180 AS DateTime), N'Great Falls', N'Great Falls', 6, 1, 1, CAST(20 AS Decimal(18, 0)), 0)
SET IDENTITY_INSERT [dbo].[tbl_EventDaten] OFF
/****** Object:  Table [dbo].[tbl_Buchungen]    Script Date: 11/24/2012 15:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Buchungen](
	[bu_BuchungsID] [int] IDENTITY(1,1) NOT NULL,
	[kd_KundenID] [int] NOT NULL,
	[ed_EvDatenID] [int] NOT NULL,
	[bu_GebuchtePlaetze] [int] NOT NULL,
	[bu_Bezahlt] [bit] NOT NULL,
	[bu_Storniert] [bit] NOT NULL,
	[bu_RechnungErstellt] [bit] NOT NULL,
 CONSTRAINT [tbl_Buchungen_PK] PRIMARY KEY CLUSTERED 
(
	[bu_BuchungsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_Buchungen] ON
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (1, 2, 7, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (2, 6, 14, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (3, 22, 8, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (4, 23, 8, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (5, 17, 21, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (6, 1, 21, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (7, 18, 32, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (8, 19, 5, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (9, 4, 11, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (10, 4, 39, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (11, 3, 39, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (12, 5, 37, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (13, 7, 37, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (14, 8, 39, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (15, 9, 19, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (16, 9, 25, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (17, 10, 25, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (18, 11, 33, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (19, 12, 39, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (20, 13, 39, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (21, 14, 13, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (22, 15, 32, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (23, 16, 3, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (24, 20, 7, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (25, 24, 8, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (26, 24, 7, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (27, 2, 7, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (28, 3, 11, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (29, 17, 7, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (30, 19, 39, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (31, 4, 8, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (32, 7, 39, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (33, 19, 41, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (34, 27, 44, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (35, 27, 7, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (36, 3, 3, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (37, 4, 7, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (38, 3, 16, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (39, 1, 1, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (40, 1, 41, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (41, 57, 1, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (42, 57, 36, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (43, 17, 36, 1, 0, 0, 0)
INSERT [dbo].[tbl_Buchungen] ([bu_BuchungsID], [kd_KundenID], [ed_EvDatenID], [bu_GebuchtePlaetze], [bu_Bezahlt], [bu_Storniert], [bu_RechnungErstellt]) VALUES (44, 6, 34, 1, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[tbl_Buchungen] OFF
/****** Object:  StoredProcedure [dbo].[spInsEvDaten]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsEvDaten]
(
	@et_EventID int,
	@ed_Preis smallmoney,
	@ed_Beginn datetime,
	@ed_Ende datetime,
	@ed_StartOrt nvarchar(50),
	@ed_Zielort nvarchar(50),
	@ed_MaxTeilnehmer int,
	@ed_AktTeilnehmer int,
	@ed_Freigegeben bit,
	@ed_Rabatt decimal(18, 0),
	@ed_VeranstalterBenachrichtigt bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO [tbl_EventDaten] ([et_EventID], [ed_Preis], [ed_Beginn], [ed_Ende], [ed_StartOrt], [ed_Zielort], [ed_MaxTeilnehmer], [ed_AktTeilnehmer], [ed_Freigegeben], [ed_Rabatt], [ed_VeranstalterBenachrichtigt]) VALUES (@et_EventID, @ed_Preis, @ed_Beginn, @ed_Ende, @ed_StartOrt, @ed_Zielort, @ed_MaxTeilnehmer, @ed_AktTeilnehmer, @ed_Freigegeben, @ed_Rabatt, @ed_VeranstalterBenachrichtigt);
	
SELECT ed_EvDatenID, et_EventID, ed_Preis, ed_Beginn, ed_Ende, ed_StartOrt, ed_Zielort, ed_MaxTeilnehmer, ed_AktTeilnehmer, ed_Freigegeben, ed_Rabatt, ed_VeranstalterBenachrichtigt FROM tbl_EventDaten WHERE (ed_EvDatenID = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[spDelEvDaten]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDelEvDaten]
(
	@Original_ed_EvDatenID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [tbl_EventDaten] WHERE (([ed_EvDatenID] = @Original_ed_EvDatenID))
GO
/****** Object:  StoredProcedure [dbo].[spSelectEvDaten]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectEvDaten]
AS
	SET NOCOUNT ON;
SELECT     tbl_EventDaten.*
FROM         tbl_EventDaten
GO
/****** Object:  StoredProcedure [dbo].[spSelectBenachrichtigt]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spSelectBenachrichtigt    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spSelectBenachrichtigt]

	(
		@ed_EvDatenID int
	)

AS
	DECLARE @benachrichtigt bit;
	SET NOCOUNT ON;
	SELECT @benachrichtigt = ed_VeranstalterBenachrichtigt FROM tbl_EventDaten WHERE ed_EvDatenID = @ed_EvDatenID;
	RETURN @benachrichtigt;
GO
/****** Object:  StoredProcedure [dbo].[spSelectAktTeilnehmer]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spSelectAktTeilnehmer    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spSelectAktTeilnehmer]
(
@ed_EvDatenID int
)

AS
DECLARE @aktTeilnehmer int;

	SET NOCOUNT ON;
	SELECT @aktTeilnehmer = ed_AktTeilnehmer FROM tbl_EventDaten WHERE ed_EvDatenID = @ed_EvDatenID;
	RETURN @aktTeilnehmer
GO
/****** Object:  StoredProcedure [dbo].[spLoadEventDaten]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spLoadEventDaten    Script Date: 26.07.2004 10:32:49 ******/
CREATE PROCEDURE [dbo].[spLoadEventDaten]

	(
		@et_Bezeichnung nvarchar(50)
	)

AS
	SELECT tbl_EventDaten.ed_EvDatenID, 
	tbl_EventDaten.ed_Preis, 
	tbl_EventDaten.ed_Beginn, 
	tbl_EventDaten.ed_Ende, 
	tbl_EventDaten.ed_StartOrt, 
	tbl_EventDaten.ed_Zielort, 
	tbl_EventDaten.ed_MaxTeilnehmer, 
	tbl_EventDaten.ed_AktTeilnehmer,
	tbl_EventDaten.ed_VeranstalterBenachrichtigt, 
	tbl_Events.et_EventID, 
	tbl_Events.et_Bezeichnung, 
	tbl_Events.et_Beschreibung, 
	tbl_EvVeranstalter.ev_Firma,
	tbl_EvKategorie.ek_KatBezeichnung
	
	FROM tbl_EventDaten JOIN tbl_Events ON tbl_EventDaten.et_EventID = tbl_Events.et_EventID 
	JOIN tbl_EvVeranstalter ON tbl_Events.ev_EvVeranstalterID = tbl_EvVeranstalter.ev_EvVeranstalterID
	JOIN tbl_EvKategorie ON tbl_Events.ek_EvKategorieID = tbl_EvKategorie.ek_EvKategorieID
	WHERE(tbl_EventDaten.ed_Freigegeben = 1 AND tbl_Events.et_Bezeichnung = @et_Bezeichnung AND tbl_EventDaten.ed_VeranstalterBenachrichtigt = 0);

	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spLoadEvBezeichnung]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spLoadEvBezeichnung    Script Date: 26.07.2004 10:32:49 ******/
CREATE PROCEDURE [dbo].[spLoadEvBezeichnung]

AS
	SELECT  COUNT (DISTINCT et_Bezeichnung) FROM tbl_Events 
	JOIN tbl_EventDaten ON tbl_Events.et_EventID = tbl_EventDaten.et_EventID 
	WHERE tbl_EventDaten.ed_Freigegeben = 1 AND tbl_EventDaten.ed_VeranstalterBenachrichtigt = 0;
	SELECT DISTINCT tbl_Events.et_Bezeichnung FROM tbl_Events 
	JOIN tbl_EventDaten ON tbl_Events.et_EventID = tbl_EventDaten.et_EventID 
	WHERE tbl_EventDaten.ed_Freigegeben = 1 AND tbl_EventDaten.ed_VeranstalterBenachrichtigt = 0
	 ORDER BY tbl_Events.et_Bezeichnung;
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spUpdtEvDaten]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdtEvDaten]
(
	@et_EventID int,
	@ed_Preis smallmoney,
	@ed_Beginn datetime,
	@ed_Ende datetime,
	@ed_StartOrt nvarchar(50),
	@ed_Zielort nvarchar(50),
	@ed_MaxTeilnehmer int,
	@ed_Freigegeben bit,
	@ed_Rabatt decimal(18, 0),
	@ed_VeranstalterBenachrichtigt bit,
	@Original_ed_EvDatenID int,
	@ed_EvDatenID int
)
AS
	SET NOCOUNT OFF;
UPDATE [tbl_EventDaten] SET [et_EventID] = @et_EventID, [ed_Preis] = @ed_Preis, [ed_Beginn] = @ed_Beginn, [ed_Ende] = @ed_Ende, [ed_StartOrt] = @ed_StartOrt, [ed_Zielort] = @ed_Zielort, [ed_MaxTeilnehmer] = @ed_MaxTeilnehmer, [ed_Freigegeben] = @ed_Freigegeben, [ed_Rabatt] = @ed_Rabatt, [ed_VeranstalterBenachrichtigt] = @ed_VeranstalterBenachrichtigt WHERE (([ed_EvDatenID] = @Original_ed_EvDatenID));
	
SELECT ed_EvDatenID, et_EventID, ed_Preis, ed_Beginn, ed_Ende, ed_StartOrt, ed_Zielort, ed_MaxTeilnehmer, ed_AktTeilnehmer, ed_Freigegeben, ed_Rabatt, ed_VeranstalterBenachrichtigt FROM tbl_EventDaten WHERE (ed_EvDatenID = @ed_EvDatenID)
GO
/****** Object:  StoredProcedure [dbo].[spUpdtBenachrichtigung]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spUpdtBenachrichtigung    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spUpdtBenachrichtigung]

	(
		@ed_EvdatenID int
	)

AS
	/* SET NOCOUNT ON */
	UPDATE tbl_EventDaten SET ed_VeranstalterBenachrichtigt = '1' WHERE ed_EvDatenID = @ed_EvDatenID
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spSucheVeranstalterBenachrichtigungen]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spSucheVeranstalterBenachrichtigungen    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spSucheVeranstalterBenachrichtigungen]

AS
SELECT COUNT (tbl_EvVeranstalter.ev_EvVeranstalterID) FROM tbl_EvVeranstalter 
JOIN tbl_Events ON tbl_EvVeranstalter.ev_EvVeranstalterID = tbl_Events.ev_EvVeranstalterID
JOIN tbl_EventDaten ON tbl_Events.et_EventID = tbl_EventDaten.et_EventID
WHERE DATEADD(DAY, 14, GETDATE()) > tbl_EventDaten.ed_Beginn AND tbl_EventDaten.ed_Freigegeben = 1 AND tbl_EventDaten.ed_VeranstalterBenachrichtigt = 0;

SELECT tbl_EvVeranstalter.ev_Firma, tbl_EvVeranstalter.ev_Strasse,tbl_EvVeranstalter.ev_HNummer,tbl_EvVeranstalter.ev_PLZ,tbl_EvVeranstalter.ev_Ort,
tbl_Events.et_Bezeichnung, tbl_EventDaten.ed_EvDatenID, tbl_EventDaten.ed_Beginn, tbl_EventDaten.ed_StartOrt,tbl_EventDaten.ed_AktTeilnehmer FROM tbl_EvVeranstalter 
JOIN tbl_Events ON tbl_EvVeranstalter.ev_EvVeranstalterID = tbl_Events.ev_EvVeranstalterID
JOIN tbl_EventDaten ON tbl_Events.et_EventID = tbl_EventDaten.et_EventID
WHERE (DATEADD(DAY, 14, GETDATE()) > tbl_EventDaten.ed_Beginn AND tbl_EventDaten.ed_Freigegeben = 1 AND tbl_EventDaten.ed_VeranstalterBenachrichtigt = 0);
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spAddTeilnehmer]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spAddTeilnehmer    Script Date: 26.07.2004 10:32:49 ******/
CREATE PROCEDURE [dbo].[spAddTeilnehmer]

	(
		@ed_EvDatenID int,
		@ed_AktTeilnehmer int
	)

AS
	UPDATE tbl_EventDaten SET ed_AktTeilnehmer = (ed_AktTeilnehmer + @ed_AktTeilnehmer) WHERE ed_EvDatenID = @ed_EvDatenID;
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spUpdtTeilnehmer]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spUpdtTeilnehmer    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spUpdtTeilnehmer]

	(
		@ed_AktTeilnehmer int,
		@bu_BuchungsID int
	)

AS
	UPDATE tbl_EventDaten SET ed_AktTeilnehmer = (ed_AktTeilnehmer - @ed_AktTeilnehmer)
	WHERE (SELECT DISTINCT ed_EvDatenID FROM tbl_Buchungen WHERE bu_BuchungsID = @bu_BuchungsID) = tbl_EventDaten.ed_EvDatenID;
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spUpdtRechnung]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spUpdtRechnung    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spUpdtRechnung]

	(
		@bu_BuchungsID int
	)
AS
	UPDATE tbl_Buchungen SET bu_RechnungErstellt = '1' WHERE bu_BuchungsID = @bu_BuchungsID
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spSucheOffeneRechnungen]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spSucheOffeneRechnungen    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spSucheOffeneRechnungen]

AS
SELECT COUNT (tbl_Buchungen.bu_Bezahlt) FROM tbl_Buchungen WHERE bu_RechnungErstellt = 1 AND bu_Bezahlt = 0;

SELECT tbl_Kunden.kd_KundenID, tbl_Kunden.kd_Name,tbl_Kunden.kd_Vorname, tbl_Kunden.kd_Strasse,tbl_Kunden.kd_HNummer, tbl_Kunden.kd_PLZ, tbl_Kunden.kd_Ort,
		tbl_Buchungen.bu_BuchungsID, tbl_Buchungen.bu_GebuchtePlaetze,tbl_Buchungen.bu_Bezahlt, tbl_Buchungen.bu_Storniert,
		tbl_EventDaten.ed_Beginn, tbl_EventDaten.ed_StartOrt,tbl_EventDaten.ed_Preis, tbl_Events.et_Bezeichnung
		FROM tbl_Kunden JOIN tbl_Buchungen ON tbl_Kunden.kd_KundenID = tbl_Buchungen.kd_KundenID
		JOIN tbl_EventDaten ON tbl_Buchungen.ed_EvDatenID = tbl_EventDaten.ed_EvDatenID
		JOIN tbl_Events ON tbl_EventDaten.et_EventID = tbl_Events.et_EventID
		WHERE bu_RechnungErstellt = 1 AND bu_Bezahlt = 0
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spSucheAktuelleRechnungen]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spSucheAktuelleRechnungen    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spSucheAktuelleRechnungen]

AS
SELECT COUNT (tbl_Buchungen.bu_Bezahlt) FROM tbl_Buchungen
JOIN tbl_EventDaten ON tbl_Buchungen.ed_EvDatenID = tbl_EventDaten.ed_EvDatenID
WHERE bu_RechnungErstellt = 0 AND DATEADD(DAY, 14, GETDATE()) > ed_Beginn;

SELECT tbl_Kunden.kd_KundenID, tbl_Kunden.kd_Name,tbl_Kunden.kd_Vorname, tbl_Kunden.kd_Strasse,tbl_Kunden.kd_HNummer, tbl_Kunden.kd_PLZ, tbl_Kunden.kd_Ort,
		tbl_Buchungen.bu_BuchungsID, tbl_Buchungen.bu_GebuchtePlaetze,tbl_Buchungen.bu_Bezahlt, tbl_Buchungen.bu_Storniert,
		tbl_EventDaten.ed_Beginn, tbl_EventDaten.ed_StartOrt,tbl_EventDaten.ed_Preis, tbl_Events.et_Bezeichnung
		FROM tbl_Kunden JOIN tbl_Buchungen ON tbl_Kunden.kd_KundenID = tbl_Buchungen.kd_KundenID
		JOIN tbl_EventDaten ON tbl_Buchungen.ed_EvDatenID = tbl_EventDaten.ed_EvDatenID
		JOIN tbl_Events ON tbl_EventDaten.et_EventID = tbl_Events.et_EventID
		WHERE bu_RechnungErstellt = 0 AND DATEADD(DAY, 14, GETDATE()) > ed_Beginn
	/* SET NOCOUNT ON */
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spStorniereBuchung]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spStorniereBuchung    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spStorniereBuchung]

	(
		@bu_BuchungsID int
	)

AS
	/* SET NOCOUNT ON */
	UPDATE tbl_Buchungen SET bu_Storniert = '1' WHERE bu_BuchungsID = @bu_BuchungsID
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spSelectKundenBuchungen]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spSelectKundenBuchungen    Script Date: 26.07.2004 10:32:50 ******/
CREATE PROCEDURE [dbo].[spSelectKundenBuchungen]

	(
		@kd_KundenID int
		
	)

AS
	 SET NOCOUNT OFF
	 SELECT tbl_Buchungen.bu_BuchungsID, tbl_Buchungen.bu_GebuchtePlaetze, tbl_Buchungen.bu_Bezahlt, tbl_Buchungen.bu_Storniert, tbl_EventDaten.ed_Beginn, tbl_EventDaten.ed_StartOrt, tbl_EventDaten.ed_Preis, tbl_Events.et_Bezeichnung
FROM tbl_Buchungen join tbl_EventDaten on tbl_Buchungen.ed_EvDatenID = tbl_EventDaten.ed_EvDatenID join
tbl_Events on tbl_EventDaten.et_EventID = tbl_Events.et_EventID where (tbl_Buchungen.kd_KundenID = @kd_KundenID)
	
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spLoadAnalyseKunden]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spLoadAnalyseKunden    Script Date: 26.07.2004 10:32:49 ******/
CREATE PROCEDURE [dbo].[spLoadAnalyseKunden]

	(
		@ek_KatBezeichnung nvarchar(15)
	)

AS
	SELECT COUNT (DISTINCT tbl_Kunden.kd_KundenID) FROM tbl_Kunden 
	JOIN tbl_Buchungen ON tbl_Kunden.kd_KundenID = tbl_Buchungen.kd_KundenID
	JOIN tbl_EventDaten ON tbl_Buchungen.ed_EvDatenID = tbl_EventDaten.ed_EvDatenID
	JOIN tbl_Events ON tbl_EventDaten.et_EventID = tbl_Events.et_EventID
	JOIN tbl_EvKategorie ON tbl_Events.ek_EvKategorieID = tbl_EvKategorie.ek_EvKategorieID
	WHERE tbl_EvKategorie.ek_KatBezeichnung = @ek_KatBezeichnung;
	
	SELECT DISTINCT tbl_Kunden.kd_KundenID, kd_Name, kd_Vorname, kd_Strasse, kd_HNummer, kd_PLZ, kd_Ort FROM tbl_Kunden 
	JOIN tbl_Buchungen ON tbl_Kunden.kd_KundenID = tbl_Buchungen.kd_KundenID
	JOIN tbl_EventDaten ON tbl_Buchungen.ed_EvDatenID = tbl_EventDaten.ed_EvDatenID
	JOIN tbl_Events ON tbl_EventDaten.et_EventID = tbl_Events.et_EventID
	JOIN tbl_EvKategorie ON tbl_Events.ek_EvKategorieID = tbl_EvKategorie.ek_EvKategorieID
	WHERE tbl_EvKategorie.ek_KatBezeichnung = @ek_KatBezeichnung ORDER BY tbl_Kunden.kd_Name;
	
	
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[spBucheEvent]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spBucheEvent    Script Date: 26.07.2004 10:32:49 ******/
CREATE PROCEDURE [dbo].[spBucheEvent]

	(
		@kd_KundenID int,
		@ed_EvDatenID int,
		@bu_GebuchtePlaetze int
	)

AS
	SET NOCOUNT ON;
	INSERT INTO tbl_Buchungen (kd_KundenID, ed_EvDatenID, bu_GebuchtePlaetze)VALUES(@kd_KundenID, @ed_EvDatenID, @bu_GebuchtePlaetze);
	
	RETURN @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[spBestaetigeZahlungseingang]    Script Date: 11/24/2012 15:06:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Stored Procedure dbo.spBestaetigeZahlungseingang    Script Date: 26.07.2004 10:32:49 ******/
CREATE PROCEDURE [dbo].[spBestaetigeZahlungseingang]

	(
		@bu_BuchungsID int
	)

AS
	UPDATE tbl_Buchungen SET bu_Bezahlt = 1 WHERE bu_BuchungsID = @bu_BuchungsID
	RETURN
GO
/****** Object:  Default [DF_tbl_Buchungen_bu_Bezahlt]    Script Date: 11/24/2012 15:06:12 ******/
ALTER TABLE [dbo].[tbl_Buchungen] ADD  CONSTRAINT [DF_tbl_Buchungen_bu_Bezahlt]  DEFAULT ((0)) FOR [bu_Bezahlt]
GO
/****** Object:  Default [DF_tbl_Buchungen_bu_Storniert]    Script Date: 11/24/2012 15:06:12 ******/
ALTER TABLE [dbo].[tbl_Buchungen] ADD  CONSTRAINT [DF_tbl_Buchungen_bu_Storniert]  DEFAULT ((0)) FOR [bu_Storniert]
GO
/****** Object:  Default [DF_tbl_Buchungen_bu_RechnungErstellt]    Script Date: 11/24/2012 15:06:12 ******/
ALTER TABLE [dbo].[tbl_Buchungen] ADD  CONSTRAINT [DF_tbl_Buchungen_bu_RechnungErstellt]  DEFAULT ((0)) FOR [bu_RechnungErstellt]
GO
/****** Object:  Default [DF_tbl_EventDaten_ed_Freigegeben]    Script Date: 11/24/2012 15:06:12 ******/
ALTER TABLE [dbo].[tbl_EventDaten] ADD  CONSTRAINT [DF_tbl_EventDaten_ed_Freigegeben]  DEFAULT ((0)) FOR [ed_Freigegeben]
GO
/****** Object:  Default [DF_tbl_EventDaten_ed_Rabatt]    Script Date: 11/24/2012 15:06:12 ******/
ALTER TABLE [dbo].[tbl_EventDaten] ADD  CONSTRAINT [DF_tbl_EventDaten_ed_Rabatt]  DEFAULT ((0)) FOR [ed_Rabatt]
GO
/****** Object:  Default [DF_tbl_EventDaten_ed_VeranstalterBenachrichtigt]    Script Date: 11/24/2012 15:06:12 ******/
ALTER TABLE [dbo].[tbl_EventDaten] ADD  CONSTRAINT [DF_tbl_EventDaten_ed_VeranstalterBenachrichtigt]  DEFAULT ((0)) FOR [ed_VeranstalterBenachrichtigt]
GO
/****** Object:  ForeignKey [tbl_EvDaten_tbl_Buchungen_FK1]    Script Date: 11/24/2012 15:06:12 ******/
ALTER TABLE [dbo].[tbl_Buchungen]  WITH CHECK ADD  CONSTRAINT [tbl_EvDaten_tbl_Buchungen_FK1] FOREIGN KEY([ed_EvDatenID])
REFERENCES [dbo].[tbl_EventDaten] ([ed_EvDatenID])
GO
ALTER TABLE [dbo].[tbl_Buchungen] CHECK CONSTRAINT [tbl_EvDaten_tbl_Buchungen_FK1]
GO
/****** Object:  ForeignKey [tbl_Kunden_tbl_Buchungen_FK1]    Script Date: 11/24/2012 15:06:12 ******/
ALTER TABLE [dbo].[tbl_Buchungen]  WITH CHECK ADD  CONSTRAINT [tbl_Kunden_tbl_Buchungen_FK1] FOREIGN KEY([kd_KundenID])
REFERENCES [dbo].[tbl_Kunden] ([kd_KundenID])
GO
ALTER TABLE [dbo].[tbl_Buchungen] CHECK CONSTRAINT [tbl_Kunden_tbl_Buchungen_FK1]
GO
/****** Object:  ForeignKey [tbl_Events_tbl_EvDaten_FK1]    Script Date: 11/24/2012 15:06:12 ******/
ALTER TABLE [dbo].[tbl_EventDaten]  WITH CHECK ADD  CONSTRAINT [tbl_Events_tbl_EvDaten_FK1] FOREIGN KEY([et_EventID])
REFERENCES [dbo].[tbl_Events] ([et_EventID])
GO
ALTER TABLE [dbo].[tbl_EventDaten] CHECK CONSTRAINT [tbl_Events_tbl_EvDaten_FK1]
GO
/****** Object:  ForeignKey [tbl_EvKategorie_tbl_Events_FK1]    Script Date: 11/24/2012 15:06:12 ******/
ALTER TABLE [dbo].[tbl_Events]  WITH CHECK ADD  CONSTRAINT [tbl_EvKategorie_tbl_Events_FK1] FOREIGN KEY([ek_EvKategorieID])
REFERENCES [dbo].[tbl_EvKategorie] ([ek_EvKategorieID])
GO
ALTER TABLE [dbo].[tbl_Events] CHECK CONSTRAINT [tbl_EvKategorie_tbl_Events_FK1]
GO
/****** Object:  ForeignKey [tbl_EvVeranstalter_tbl_Events_FK1]    Script Date: 11/24/2012 15:06:12 ******/
ALTER TABLE [dbo].[tbl_Events]  WITH CHECK ADD  CONSTRAINT [tbl_EvVeranstalter_tbl_Events_FK1] FOREIGN KEY([ev_EvVeranstalterID])
REFERENCES [dbo].[tbl_EvVeranstalter] ([ev_EvVeranstalterID])
GO
ALTER TABLE [dbo].[tbl_Events] CHECK CONSTRAINT [tbl_EvVeranstalter_tbl_Events_FK1]
GO

--Update der Eventdaten
UPDATE tbl_EventDaten
SET ed_Beginn = DATEADD(year, 13, ed_Beginn)
GO

UPDATE tbl_EventDaten
SET ed_Ende = DATEADD(year, 13, ed_Ende)
GO

UPDATE tbl_EventDaten
SET ed_VeranstalterBenachrichtigt = 0;
GO

/*Setzt alle Rechnungen und Stornos zurück*/
UPDATE tbl_Buchungen
SET bu_Bezahlt = 0, bu_Storniert = 0, bu_RechnungErstellt = 0
GO