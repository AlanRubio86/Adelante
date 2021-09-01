create proc Sp_RegresaCitaDetallada
@idcita int
as

select Productos.Productos_Nombre,Productos.IdProductos from Productos inner join DetalleCitas on Productos.IdProductos=DetalleCitas.IdProducto where DetalleCitas.IdCita=@idcita