CREATE  proc Sp_ReporteClientes
@status tinyint,
@ciudad varchar(20)
as
select * 
		from Clientes 
		where Clientes_Ciudad like '%'+@ciudad+'%' 
		AND Clientes_Status = 
           CASE @status WHEN 2 THEN Clientes_Status
           ELSE @status END