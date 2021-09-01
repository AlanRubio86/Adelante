CREATE proc [dbo].[Sp_AltaCita]
@id int,
@cliente int,
@fecha varchar(10),
@estado int,
@hora varchar(15),
@tipo varchar(20),
@areas varchar(50),
@usuarios int,
@horafin varchar(15),
@fecha2 datetime, 
@horas varchar(max),
@Nombre varchar(50)
as
Declare @aux int
Set @aux=(select COUNT(*) from Citas  where IdCita=@id)

if(@aux>0)
begin
update Citas set Citas_Fecha=@fecha,Citas_Estado=@estado,Citas_Hora=@hora,Citas_Tipo=@tipo,Citas_Areas=@areas,IdUsuario=@usuarios,Citas_Fin=@horafin ,Citas_Nombre=@Nombre where IdCita=@id
if(@estado= 2)
begin
delete from CitasT where idCita=@id
end
end
else 
begin
insert into Citas(IdCliente,Citas_Fecha,Citas_Estado,Citas_Hora,Citas_Tipo,Citas_Areas,IdUsuario,Citas_Fin,Citas_Nombre)values(@cliente,@fecha,@estado,@hora,@tipo,@areas,@usuarios,@horafin,@Nombre)
if(@estado= 2)
begin
delete from CitasT where idCita=@id
end
end

exec Sp_AltaCitasT @id,@fecha2,@horas
exec Sp_AltaEstadoCita @id,@estado,@cliente