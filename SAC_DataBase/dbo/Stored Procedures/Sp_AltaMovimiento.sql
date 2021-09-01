CREATE proc Sp_AltaMovimiento
@usuario int,
@descripcion varchar(200),
@tipo int
as
insert into Movimientos(IdUsuario,Movimientos_Descripcion,Movimientos_Tipo) values (@usuario,@descripcion,@tipo)