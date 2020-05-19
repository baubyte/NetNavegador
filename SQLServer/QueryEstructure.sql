/* Estructuras */

/* DELCARE @AVG money = (SELECT AVG(Production.Product.ListPrice) FROM Production.Product) < $300*/
/* DELCARE @AVG money
SELECT @AVG = AVG(Production.Product.ListPrice) FROM Production.Product) */
/*WHILE @AVG < $300*/
/*la l�nea siguiente cada vez que pasa por el while vuelve a calcular el AVG...
lo cual se evita con lo anterior */
WHILE (SELECT AVG(Production.Product.ListPrice) FROM Production.Product) < $300
/* $ indica que el valor es de tipo moneda*/
BEGIN /* para poner m�s de una l�nea se debe iniciar el bloque con begin*/
UPDATE Production.Product
SET ListPrice = ListPrice * 2
SELECT MAX(ListPrice) FROM Production.Product
IF (SELECT MAX(ListPrice) FROM Production.Product) > $500
/* si ac� va m�s de una l�nea debe ir un begin*/
BREAK /* salta del WHILE, es un exit */
ELSE
CONTINUE /* Contin�a la ejecuci�n del WHILE, no es necesario */
END
PRINT 'Demasiado caro';