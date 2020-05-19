/* Estructuras */

/* DELCARE @AVG money = (SELECT AVG(Production.Product.ListPrice) FROM Production.Product) < $300*/
/* DELCARE @AVG money
SELECT @AVG = AVG(Production.Product.ListPrice) FROM Production.Product) */
/*WHILE @AVG < $300*/
/*la línea siguiente cada vez que pasa por el while vuelve a calcular el AVG...
lo cual se evita con lo anterior */
WHILE (SELECT AVG(Production.Product.ListPrice) FROM Production.Product) < $300
/* $ indica que el valor es de tipo moneda*/
BEGIN /* para poner más de una línea se debe iniciar el bloque con begin*/
UPDATE Production.Product
SET ListPrice = ListPrice * 2
SELECT MAX(ListPrice) FROM Production.Product
IF (SELECT MAX(ListPrice) FROM Production.Product) > $500
/* si acá va más de una línea debe ir un begin*/
BREAK /* salta del WHILE, es un exit */
ELSE
CONTINUE /* Continúa la ejecución del WHILE, no es necesario */
END
PRINT 'Demasiado caro';