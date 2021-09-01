CREATE proc [dbo].[Sp_AltaServicioDetalle]
@id int,
@idproducto INT,
@frecuencia VARCHAR(50),
@idcliente int
as
insert into DetalleServicios(IdServicio,DetServ_IdProducto,DetalleServicio_Frecuencia)values (@id,@idproducto,@frecuencia)
EXEC dbo.Sp_AltaAreaXCliente @idarea = @idproducto, -- int
    @idcliente = @idcliente, -- int
    @sesion = 1, -- int
    @retoque = 1, -- bit
    @pagados = 0 -- int