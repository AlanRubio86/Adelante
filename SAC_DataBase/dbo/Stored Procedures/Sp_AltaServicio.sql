CREATE proc [dbo].[Sp_AltaServicio]
@id int,
@idclientes int,
@Fecha varchar(10),
@IdUsuario int,
@notas varchar(200),
@tipo varchar(50),
@unipolar varchar(50),
@bipolar varchar(50),
@medidas varchar(50),
@hora varchar(8)
as
DECLARE @aux INT 

SET @aux=(SELECT COUNT(*) FROM Servicio WHERE IdServicio=@id)

IF(@aux>0)
 BEGIN
   update Servicio 
		set 
		IdCliente=@idclientes,
		Servicio_Notas=@notas,
		Servicio_Tipo=@tipo,
		Servicio_Unipolar=@unipolar,
		Servicio_Bipolar=@bipolar,
		Servicio_Medidas=@medidas 
   where  IdServicio=@id
end
ELSE
	BEGIN
	insert into 
	Servicio(
			IdCliente,
			Servicio_Fecha,
			IdUsuario,
			Servicio_Notas,
			Servicio_Tipo,
			Servicio_Unipolar,
			Servicio_Bipolar,
			Servicio_Medidas,
			Servicio_Hora
			)
	values(
			@idclientes,
			@Fecha,
			@IdUsuario,
			@notas,
			@tipo,
			@unipolar,
			@bipolar,
			@medidas,
			@hora
			
		  )
	end