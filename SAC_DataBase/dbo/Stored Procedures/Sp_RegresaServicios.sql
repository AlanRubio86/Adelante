CREATE proc [dbo].[Sp_RegresaServicios] 
@idcliente INT,
@tipo VARCHAR(50)
as

select  
		Servicio.IdServicio,
		Servicio.Servicio_Fecha,
		Servicio.Servicio_Hora,
	    Productos.Productos_Descripcion,
	    Servicio.servicio_notas,
	    Servicio.Servicio_Unipolar,
	    Servicio.Servicio_Bipolar,
	    Servicio.Servicio_Medidas,
	    Servicio.Servicio_tipo,
	    Clientes.Clientes_Nombre+ ' '+Clientes.Clientes_Apellidos as Nombre,
	    DetalleServicios.DetalleServicio_Frecuencia,
	    Usuarios.Usuarios_Nombre+' '+Usuarios.Usuarios_Apellidos as Usuario

		from Servicio 
		inner join 
				DetalleServicios on Servicio.IdServicio=DetalleServicios.IdServicio
		inner join
				Productos on Productos.IdProductos=DetalleServicios.DetServ_IdProducto
		inner join Clientes on Clientes.IdCliente=Servicio.IdCliente
		inner join Usuarios on Servicio.IdUsuario=Usuarios.IdUsuario
		
		where 
		Servicio.IdCliente=@idcliente AND servicio.Servicio_Tipo=@tipo
		group By Servicio.IdServicio,	Servicio.Servicio_Fecha,Productos.Productos_Descripcion,Servicio.servicio_notas,Servicio.Servicio_tipo,  Servicio.Servicio_Unipolar,Servicio.Servicio_Bipolar,Servicio.Servicio_Medidas,  Clientes.Clientes_Nombre,Clientes.Clientes_Apellidos,DetalleServicios.DetalleServicio_Frecuencia,Usuarios.Usuarios_Nombre,Usuarios.Usuarios_Apellidos,Servicio_Hora
		order by Servicio.IdServicio,	Servicio.Servicio_Fecha