/* Llamado a la función*/
USE Northwind
GO
SELECT CompanyName, dbo.Promocion(Customerid) as Promo
FROM Customers