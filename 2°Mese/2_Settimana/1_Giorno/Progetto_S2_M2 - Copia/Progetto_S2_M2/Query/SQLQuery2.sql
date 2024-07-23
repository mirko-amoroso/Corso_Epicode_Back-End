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
