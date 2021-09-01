create proc Sp_EliminarCitaDetalle
@idcita int,
@idproducto int
as
delete from DetalleCitas where IdCita=@idcita and IdProducto=@idproducto