CREATE proc Sp_AltaCitasT
@id int,
@CitasT_Fecha datetime,
@Horas varchar(max)
as
Declare @aux int
Set @aux=(select COUNT(*) from CitasT  where idCita=@id)

if(@aux>0)
begin
update CitasT set CitasT_Fecha=@CitasT_Fecha,CitasT_Horas=@Horas   where idCita=@id
end
else
begin
insert into CitasT (idCita,CitasT_Fecha,CitasT_Horas) values(@id,@CitasT_Fecha,@Horas)
end