/* Llamado a la funci�n*/
USE Northwind
GO
SELECT CompanyName, dbo.Promocion(Customerid) as Promo
FROM Customers