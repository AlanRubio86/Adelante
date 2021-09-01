CREATE proc [dbo].[Sp_ReporteCitas]
@cliente INT, 
@desde DATETIME, 
@hasta DATETIME
as

select 
			Clientes.Clientes_Nombre+' '+Clientes.Clientes_Apellidos as Nombre,
			Citas.IdCita,
			Clientes.IdCliente,
			Citas.Citas_Hora,
			Citas.Citas_Tipo,
			Citas.Citas_Areas,
			Citas.Citas_Fecha,
			Citas_Estado
from Citas 
	inner join Clientes on Citas.IdCliente=Clientes.IdCliente 
		where 
				Citas.IdCliente = 
			    CASE @cliente WHEN 0 THEN Citas.IdCliente
			    ELSE @cliente END
		    
		 AND Citas.Citas_Fecha BETWEEN @desde AND @hasta
				and Citas.Citas_Estado <= 2
				order by Citas.Citas_Hora