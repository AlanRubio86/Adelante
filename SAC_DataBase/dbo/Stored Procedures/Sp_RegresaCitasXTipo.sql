CREATE proc [dbo].[Sp_RegresaCitasXTipo]
@idCliente INT,
@Estado INT
as

SELECT   
		Citas.IdCita, 
		Citas.Citas_Tipo, 
		Citas.Citas_Fecha,
		Citas.Citas_Hora,
		CASE EstadoXCita.estado 
		WHEN 0 THEN 'Por Confirmar' 
		WHEN 1 THEN 'Confirmada' 
		WHEN 2 THEN 'Cancelada'
		WHEN 3 then 'Asistio'
		WHEN 4 THEN 'No Asistio'
		END 'Estado' 
		
   FROM Citas   
  INNER JOIN EstadoXCita on EstadoXCita.idcita = Citas.IdCita
  
		WHERE Citas.IdCliente = @idCliente 
		  AND EstadoXCita.estado =
		      CASE @Estado 
		            WHEN 7 THEN EstadoXCita.estado  
					ELSE @Estado END
					
     ORDER BY Citas.Citas_Fecha