CREATE proc [dbo].[Sp_RegresaCitas]
@Fecha varchar(10)
as

select 
		Clientes.Clientes_Nombre+' '+Clientes.Clientes_Apellidos as Nombre,
		Clientes.IdCliente,
		Citas.IdCita,
		Citas.Citas_Hora,
		Citas.Citas_Tipo,
		Citas.Citas_Areas,
		Citas.Citas_Fecha,
		CASE dbo.Citas.Citas_Estado 
		WHEN 0 THEN 'Por Confirmar' 
		WHEN 1 THEN 'Confirmada' 
		WHEN 2 THEN 'Cancelada'
		WHEN 3 then 'Asistio'
		WHEN 4 THEN 'No Asistio'
		END 'Estado',
		Citas.Citas_Fin,
		CitasT.CitasT_Horas
from Citas 
	inner join Clientes on Citas.IdCliente=Clientes.IdCliente 
		inner join CitasT on Citas.IdCita=CitasT.idCita
		where Citas.Citas_Fecha=@Fecha 
				and Citas.Citas_Estado<=2
				order by Citas.Citas_Hora