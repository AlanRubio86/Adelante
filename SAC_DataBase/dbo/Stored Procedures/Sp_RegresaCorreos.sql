CREATE PROC Sp_RegresaCorreos

AS
SELECT dbo.Clientes.Clientes_Correo FROM dbo.Clientes WHERE Clientes_Status=0