﻿--CREATE TABLE [dbo].[Cliente]
--(
--	[IdCliente] INT NOT NULL PRIMARY KEY IDENTITY,
--	Cod_Fisc NVARCHAR(16) NULL CHECK(Cod_Fisc = 16),
--	Cognome NVARCHAR(30) NULL,
--	Nome NVARCHAR(30) NULL,
--	Citta NVARCHAR(30) NULL,
--	Provincia NVARCHAR(2) NULL CHECK(Provincia = 2),
--	Email NVARCHAR(30) NULL,
--	Telefono NVARCHAR(10) NULL CHECK(Telefono = 10)
--)

--CREATE TABLE [dbo].[Camere]
--(
--	[IdCamera] INT NOT NULL PRIMARY KEY IDENTITY,
--	NumCam INT NOT NULL CHECK(NumCam >= 1) UNIQUE,
--	Descrizione NVARCHAR(50) NULL,
--	Doppia BIT DEFAULT 0
--)

--CREATE TABLE [dbo].[Prenotazioni] (
--    [IdPrenotazione]              INT           IDENTITY (1, 1) NOT NULL,
--    [DataPrenotazione]            DATETIME2 (7) DEFAULT (getdate()) NOT NULL,
--    [DataInizio]                  DATETIME2 (7) NOT NULL,
--    [DataFine]                    DATETIME2 (7) NOT NULL,
--    [Caparra]                     DECIMAL (18)  NULL,
--    [Importo]                     DECIMAL (18)  NULL,
--    [MezzaPensione]               BIT           DEFAULT ((0)) NOT NULL,
--    [PensioneCompleta]            BIT           DEFAULT ((0)) NOT NULL,
--    [PernottamentoPrimaColazione] BIT           DEFAULT ((0)) NOT NULL,
--    [IdCamera]                    INT           NOT NULL,
--    [IdClienti]                   INT           NOT NULL,
--    PRIMARY KEY CLUSTERED ([IdPrenotazione] ASC),
--    CHECK ([DataInizio] > getdate()),
--    CHECK ([DataFine] > [DataInizio]),
--    CHECK ([Importo] > (0)),
--    CONSTRAINT [FK_Prenotazioni_Camere] FOREIGN KEY ([IdCamera]) REFERENCES [dbo].[Camere] ([IdCamera]),
--    CONSTRAINT [FK_Prenotazioni_Clienti] FOREIGN KEY ([IdClienti]) REFERENCES [dbo].[Cliente] ([IdCliente])
--);

--CREATE TABLE [dbo].[Servizi]
--(
--	[IdServizi] INT NOT NULL PRIMARY KEY IDENTITY,
--	DataServizio DATETIME2 NULL DEFAULT GETDATE(),
--	ColazioneCamera BIT NULL DEFAULT 0,
--	MiniBar BIT NULL DEFAULT 0,
--	Internet BIT NULL DEFAULT 0,
--	LettoPiu BIT NULL DEFAULT 0,
--	Culla BIT NULL DEFAULT 0,
--	IdPrenotazione INT NOT NULL,
--    CONSTRAINT FK_Prenotazioni FOREIGN KEY (IdPrenotazione) REFERENCES Prenotazioni(IdPrenotazione)
--)

--INSERT INTO [User](Username, [Password], FrinedlyName) VALUES('mirko', 'mirko', 'mirketto'),('andree', 'andree', 'didi')
--INSERT INTO [Role](RolesName) VALUES('Utente'),('Amministartore'),('Master')
--INSERT INTO UnioneLogin(UserId, RoleId) VALUES(1, 2), (2, 1)


--SELECT * FROM Camere
--SELECT * FROM Clienti
--SELECT * FROM Prenotazioni
--SELECT * FROM Servizi


--INSERT INTO [dbo].[Prenotazioni] ([DataPrenotazione], [DataInizio], [DataFine], [Caparra], [Importo], [MezzaPensione], [PensioneCompleta], [PernottamentoPrimaColazione], [IdCamera], [IdClienti])
--VALUES 
--(GETDATE(), '2024-08-01', '2024-08-10', 100, 500, 1, 0, 0, 1, 8),
--(GETDATE(), '2024-08-05', '2024-08-15', 150, 600, 0, 1, 0, 2, 9),
--(GETDATE(), '2024-08-10', '2024-08-20', 200, 700, 1, 0, 0, 3, 10),
--(GETDATE(), '2024-08-15', '2024-08-25', 250, 800, 0, 1, 0, 4, 11),
--(GETDATE(), '2024-08-20', '2024-08-30', 300, 900, 1, 0, 0, 5, 12),
--(GETDATE(), '2024-08-25', '2024-09-05', 350, 1000, 0, 1, 0, 6, 13),
--(GETDATE(), '2024-09-01', '2024-09-10', 400, 1100, 1, 0, 0, 7, 14),
--(GETDATE(), '2024-09-05', '2024-09-15', 450, 1200, 0, 1, 0, 8, 15),
--(GETDATE(), '2024-09-10', '2024-09-20', 500, 1300, 1, 0, 0, 9, 16),
--(GETDATE(), '2024-09-15', '2024-09-25', 550, 1400, 0, 1, 0, 10, 17),
--(GETDATE(), '2024-09-20', '2024-09-30', 600, 1500, 1, 0, 0, 1, 8),
--(GETDATE(), '2024-09-25', '2024-10-05', 650, 1600, 0, 1, 0, 2, 9),
--(GETDATE(), '2024-10-01', '2024-10-10', 700, 1700, 1, 0, 0, 3, 10),
--(GETDATE(), '2024-10-05', '2024-10-15', 750, 1800, 0, 1, 0, 4, 11),
--(GETDATE(), '2024-10-10', '2024-10-20', 800, 1900, 1, 0, 0, 5, 12),
--(GETDATE(), '2024-10-15', '2024-10-25', 850, 2000, 0, 1, 0, 6, 13),
--(GETDATE(), '2024-10-20', '2024-10-30', 900, 2100, 1, 0, 0, 7, 14),
--(GETDATE(), '2024-10-25', '2024-11-05', 950, 2200, 0, 1, 0, 8, 15),
--(GETDATE(), '2024-11-01', '2024-11-10', 1000, 2300, 1, 0, 0, 9, 16),
--(GETDATE(), '2024-11-05', '2024-11-15', 1050, 2400, 0, 1, 0, 10, 17);