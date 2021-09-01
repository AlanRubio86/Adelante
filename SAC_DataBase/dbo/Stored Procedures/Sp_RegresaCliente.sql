CREATE PROCEDURE [dbo].[Sp_RegresaCliente]
@dato varchar(50), @status tinyint
WITH 
EXECUTE AS CALLER
AS
	   SELECT 
			  Clientes.*,
	          ISNULL(SUM(Adeudos.Adeudo_Monto),0) Debe,
			  CASE Clientes.Clientes_Status WHEN 1 THEN 'Deshabilitado'
			  ELSE 'Habilitado' END AS Estado
		 FROM Clientes 
    
   FULL JOIN Adeudos
           ON Adeudos.IdCliente = Clientes.IdCliente
           
	    WHERE Clientes_Nombre LIKE @dato  
		  AND Clientes_Status = 
		  	  CASE @status WHEN 2 THEN Clientes_Status
			  ELSE @status END
			  
	 GROUP BY Clientes.IdCliente,
	          Clientes.Clientes_Alergia,
	          Clientes.Clientes_Apellidos,
	          Clientes.Clientes_Celular,
	          Clientes.Clientes_Telefono,
	          Clientes.Clientes_Ciudad,
	          Clientes.Clientes_Correo,
	          Clientes.Clientes_Direccion,
	          Clientes.Clientes_Edad,
	          Clientes.Clientes_Enfermedad,
	          Clientes.Clientes_Medicamento,
	          Clientes.Clientes_Nombre,
	          Clientes.Clientes_Status,
	          Clientes.Clientes_Sexo,
	          Clientes.Clientes_Nextel,
	          Clientes.Clientes_Referido,
	          Clientes_Cumplido,
	          Clientes_Fecha
         
 UNION
 
       SELECT 
			  Clientes.*,
			  ISNULL(SUM(Adeudos.Adeudo_Monto),0) Debe,
			  CASE Clientes.Clientes_Status WHEN 1 THEN 'Deshabilitado'
			  ELSE 'Habilitado' END AS Estado
		 FROM Clientes 
		 
   FULL JOIN Adeudos
           ON Adeudos.IdCliente = Clientes.IdCliente		 
		 
	    WHERE Clientes_Apellidos LIKE @dato
		  AND Clientes_Status = 
		 	  CASE @status WHEN 2 THEN Clientes_Status
		 	  ELSE @status END
		 	  
     GROUP BY Clientes.IdCliente,
	          Clientes.Clientes_Alergia,
	          Clientes.Clientes_Apellidos,
	          Clientes.Clientes_Celular,
	          Clientes.Clientes_Telefono,
	          Clientes.Clientes_Ciudad,
	          Clientes.Clientes_Correo,
	          Clientes.Clientes_Direccion,
	          Clientes.Clientes_Edad,
	          Clientes.Clientes_Enfermedad,
	          Clientes.Clientes_Medicamento,
	          Clientes.Clientes_Nombre,
	          Clientes.Clientes_Status,
	          Clientes.Clientes_Sexo,
	          Clientes.Clientes_Nextel,
	          Clientes.Clientes_Referido,
	          Clientes_Cumplido,
	          Clientes_Fecha