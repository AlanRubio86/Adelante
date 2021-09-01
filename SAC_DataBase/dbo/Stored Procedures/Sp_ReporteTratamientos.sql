CREATE proc [dbo].[Sp_ReporteTratamientos] 
@cliente INT, 
@desde DATETIME, 
@hasta DATETIME
as

select  
		Servicio.IdServicio,
		Servicio.Servicio_Fecha,
	    Productos.Productos_Descripcion,
	    Servicio.servicio_notas,
	    Servicio.Servicio_Unipolar,
	    Servicio.Servicio_Bipolar,
	    Servicio.Servicio_Medidas,
	    Servicio.Servicio_tipo,
	    Servicio.Servicio_Hora,
	    Clientes.Clientes_Nombre+ ' '+Clientes.Clientes_Apellidos as Nombre

		from Servicio 
		inner join 
				DetalleServicios on Servicio.IdServicio=DetalleServicios.IdServicio
		inner join
				Productos on Productos.IdProductos=DetalleServicios.DetServ_IdProducto
		inner join Clientes on Clientes.IdCliente=Servicio.IdCliente
		
		where 
		        Clientes.IdCliente = 
			    CASE @cliente WHEN 0 THEN Clientes.IdCliente
			    ELSE @cliente END
		    
		 AND Servicio.Servicio_Fecha BETWEEN @desde AND @hasta
		group By Servicio.IdServicio,	Servicio.Servicio_Fecha,Productos.Productos_Descripcion,Servicio.servicio_notas,Servicio.Servicio_tipo,  Servicio.Servicio_Unipolar,Servicio.Servicio_Bipolar,Servicio.Servicio_Medidas,  Clientes.Clientes_Nombre,Clientes.Clientes_Apellidos,Servicio.Servicio_Hora
		order by Servicio.IdServicio,	Servicio.Servicio_Fecha