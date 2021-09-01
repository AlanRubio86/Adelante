CREATE proc [dbo].[Sp_RegresaServicios2] 
@Nombre varchar(50)
as

select  
		Servicio.IdServicio,
		Servicio.Servicio_Fecha,
	    Servicio.servicio_notas,
	    Servicio.Servicio_tipo,
	    Servicio.Servicio_Unipolar,
	    Servicio.Servicio_Bipolar,
	    Servicio.Servicio_Medidas,
	    Servicio.IdCliente,
	    Clientes.Clientes_Nombre+ ' '+Clientes.Clientes_Apellidos as Nombre

		from Servicio 
		inner join Clientes on Clientes.IdCliente=Servicio.IdCliente
		
		where 
		Clientes.Clientes_Nombre like @Nombre and Servicio.Servicio_Status=1	
		group By Servicio.IdServicio,	Servicio.Servicio_Fecha,Servicio.servicio_notas,Servicio.Servicio_tipo,   Clientes.Clientes_Nombre,Clientes.Clientes_Apellidos,	    Servicio.Servicio_Unipolar,Servicio.Servicio_Bipolar,Servicio.Servicio_Medidas,Servicio.IdCliente
		order by Servicio.IdServicio,	Servicio.Servicio_Fecha