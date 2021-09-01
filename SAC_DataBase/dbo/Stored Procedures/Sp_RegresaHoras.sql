CREATE PROCEDURE [dbo].[Sp_RegresaHoras]
@desde DATETIME, 
@hasta DATETIME
WITH 
EXECUTE AS CALLER
AS
SELECT 
          CitasT.*,
          Citas.*,
          CASE dbo.Citas.Citas_Estado 
			WHEN 0 THEN 'Por Confirmar' 
			WHEN 1 THEN 'Confirmada' 
			WHEN 2 THEN 'Cancelada'
			WHEN 3 then 'Asistio'
			WHEN 4 THEN 'No Asistio'
			END 'Estado',
          Clientes.Clientes_Nombre +' '+Clientes.Clientes_Apellidos AS Nombre_Cliente,
          Clientes.Clientes_Celular,
          Clientes.Clientes_Nextel,
          Clientes.Clientes_Telefono,
          Clientes.Clientes_Correo,
          CASE Clientes.Clientes_Cumplido 
                  WHEN 1 THEN '^_^'
                  WHEN 2 THEN '''_'''
                  WHEN 3 THEN 'o_0'''
         ELSE '*_-' END AS Cumplido

    FROM CitasT 
    
    INNER JOIN Citas
            ON Citas.IdCita = CitasT.idCita
           AND Citas.Citas_Estado < 2
           
    INNER JOIN Clientes
            ON Clientes.IdCliente = Citas.IdCliente
            
           
   WHERE  CitasT.CitasT_Fecha BETWEEN @desde AND @hasta