--select * from Impiegato
--where Eta >= 29

--select * from Impiegato
--where DetrazioneFiscale = 'False'

--select * from Impiegato
--where DetrazioneFiscale = 'True'

--select * from Impiegato 
--where Cognome LIKE 'G%'

--select count(*) as ImpiegatiTotali from Impiegato

--select CAST(SUM(RedditoMensile)as NVARCHAR(15 )) + '€' as ImpiegatiTotali from Impiegato

--select CAST(SUM(RedditoMensile)/ CAST(COUNT(*) AS DECIMAL(7,2)) AS VARCHAR(15)) + '€' as MediaSoldi from Impiegato

--select max(RedditoMensile) AS RedditoMassimo from Impiegato

--select MIN(RedditoMensile) AS RedditoMassimo from Impiegato

--select COUNT(*) AS QuantitàLavoro from Impiego
--where TipoImpiego = 'A'
SELECT * FROM Impiegato as I
LEFT JOIN Impiego as Impie on I.IdImpiegato = Impie.IdImpiegato


