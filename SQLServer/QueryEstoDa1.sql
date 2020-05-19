DECLARE @Fecha DateTime = CAST('2010/31/12' AS DateTime)
SELECT DATEDIFF(MONTH,@Fecha,CAST('2011/01/01' AS DateTime)); /*--> ESTO DA 1 ¿¿??*/
SELECT DATEDIFF(YEAR,@Fecha,CAST('2011/01/01' AS DateTime)); /*--> ESTO DA 1 ¿¿??*/