CREATE proc [dbo].[Sp_RegresaServicioDetalle]
@servicio int
as

select Productos.Productos_Nombre,Productos.IdProductos,dbo.DetalleServicios.DetalleServicio_Frecuencia from Productos inner join DetalleServicios on Productos.IdProductos=DetalleServicios.DetServ_IdProducto where DetalleServicios.IdServicio=@servicio