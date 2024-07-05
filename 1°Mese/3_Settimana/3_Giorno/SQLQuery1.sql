--select count(*) as numero_ordini from Orders

--select count(*) from Employees as numero_clienti

--select COUNT(*) from Employees as clienti_londra
--where City = 'London'

--select SUM(Freight)/count(*) '€' from Orders as media_trasporto

--select MAX(cast(Freight as decimal(7,2))) '€' from Orders as media_trasporto

--select SUM(Freight)/count(*) '€' from Orders as media_trasporto_BOTTM
--where CustomerID = 'BOTTM'

--select EmployeeID as Id_utente, SUM(Freight) as Totale_trasporto from Orders as spesa_X_Id
--GROUP BY EmployeeID 
--ORDER BY EmployeeID asc

--select count(*) as Clienti, City as Citta from Employees as numero_clienti
--GROUP BY City order by Clienti asc

--select OrderID as Ordine, (CAST( UnitPrice as int) * CAST(Quantity as int)) as Price_total
--from [Order Details]
--order by Ordine desc

--select OrderID as Ordine, (CAST( UnitPrice as int) * CAST(Quantity as int)) as Price_total
--from [Order Details]
--where OrderID= 10248
--order by Ordine desc

--select CategoryID as Categoria, Count(CategoryID) as numero_prodotti from Products
--Group by CategoryID 
--order by numero_prodotti asc

--select ShipCountry as città, count(OrderID) as ordini_totali from Orders
--group by ShipCountry
--order by ShipCountry

--select ShipCountry as città,
--cast( cast( sum(Freight) as decimal(7,2)) / cast (COUNT(Freight) as decimal(7,2)) as decimal(7,2)) as costo_medio
--from Orders
--group by ShipCountry
--order by ShipCountry