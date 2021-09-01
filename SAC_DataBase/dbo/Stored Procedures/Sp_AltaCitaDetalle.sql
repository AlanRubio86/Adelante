create proc Sp_AltaCitaDetalle
@idcita int,
@idproducto int
as
Declare @aux int
set @aux=(select COUNT(*) from DetalleCitas where IdCita=@idcita and IdProducto=@idproducto)
if (@aux<1)
begin
insert into DetalleCitas(IdCita,IdProducto)values(@idcita,@idproducto)
end