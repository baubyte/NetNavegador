/**Extramos desde la Posicion 1 30 caracteres con SUBSTRING, Uso de CONVERT es los mismo que CAST*/
SELECT SUBSTRING(Name,1,30) AS NombreProducto, ListPrice, CONVERT(INT,ListPrice)
FROM Production.Product
WHERE CONVERT(INT,ListPrice) LIKE '3%'