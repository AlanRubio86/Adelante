
CREATE proc [dbo].[Sp_RegresaCitas2]
@Nombre varchar(50)
as

select Clientes.Clientes_Nombre+' '+Clientes.Clientes_Apellidos as Nombre,
		Clientes.IdCliente,
		Clientes.Clientes_Correo,
		Citas.IdCita,
		Citas.Citas_Hora,
		Citas.Citas_Tipo,
		Citas.Citas_Fecha,
		CASE dbo.Citas.Citas_Estado 
		WHEN 0 THEN 'Por Confirmar' 
		WHEN 1 THEN 'Confirmada' 
		WHEN 2 THEN 'Cancelada'
		WHEN 3 then 'Asistio'
		WHEN 4 THEN 'No Asistio'
		END 'Estado',
		Citas.Citas_Fin,
		CitasT.CitasT_Horas,
		Citas.Citas_Nombre
from Citas 
	inner join Clientes on Citas.IdCliente=Clientes.IdCliente 
	inner join CitasT on Citas.IdCita=CitasT.idCita
				where Clientes.Clientes_Nombre like @Nombre
				order by Citas.Citas_Fecha,Citas.Citas_Hora