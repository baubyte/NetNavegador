DECLARE @Fecha DateTime /* se puede hacer tambi�n la asignaci�n ac� .... = CAST(....) */
SET @Fecha = CAST('1978/21/12' AS DateTime) /*carga el valor en la varible*/
/*es lo mimsmo DECLARE @Fecha DateTime = CAST('1978/12/21' AS DateTime*/
SELECT MONTH(@Fecha)