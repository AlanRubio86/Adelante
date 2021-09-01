CREATE PROC Sp_ServicioRecordatorioCitas
as
SELECT 
CITAS.Citas_Areas,
CAST(citas.Citas_Fecha AS DATE) AS Fecha,
citas.Citas_Hora,
citas.Citas_Tipo,
dbo.Clientes.Clientes_Correo,
dbo.Clientes.Clientes_Nombre+' '+dbo.Clientes.Clientes_Apellidos AS NombreCliente 
FROM CITAS
INNER JOIN dbo.Clientes ON dbo.Citas.IdCliente=Clientes.IdCliente
WHERE  Citas_Fecha=CAST((GETDATE()+2) AS DATE) AND Citas_Estado<=2