CREATE PROCEDURE [dbo].[Sp_AltaClientes]
@id int, @nombre varchar(20), @apellidos varchar(25),
 @telefono varchar(50), @ciudad varchar(20), 
 @edad datetime, @sexo varchar(6), @Direccion varchar(50), 
 @celular varchar(15), @correo varchar(50), 
 @alergia varchar(50), @enfermedad varchar(50), 
 @medicamento varchar(50), @status bit,
 @nextel varchar(20),@referido varchar(50),
 @cumplido tinyint
WITH 
EXECUTE AS CALLER
AS
DECLARE @aux INT 

SET @aux=(SELECT COUNT(*) FROM Clientes WHERE IdCliente=@id)

IF(@aux>0)
 BEGIN
  UPDATE Clientes SET  
         
		Clientes_Nombre = @nombre,
		Clientes_Apellidos = @apellidos,
		Clientes_Telefono = @telefono,
		Clientes_Ciudad = @ciudad, 
		Clientes_Edad = @edad,
		Clientes_Sexo = @sexo,
		Clientes_Direccion = @Direccion,
		Clientes_Celular = @celular,
		Clientes_Correo = @correo, 
		Clientes_Alergia = @alergia,
		Clientes_Enfermedad = @enfermedad,
		Clientes_Medicamento = @medicamento,
		Clientes_Status=@status,
		Clientes_Nextel=@nextel,
		Clientes_Referido=@referido,
		Clientes_Cumplido=@cumplido
      
  WHERE IdCliente = @id

 END
 
ELSE
	BEGIN
		INSERT INTO
		  Clientes
		  (
		    Clientes_Nombre,
			Clientes_Apellidos,
			Clientes_Telefono,
			Clientes_Ciudad, 
			Clientes_Edad,
			Clientes_Sexo,
			Clientes_Direccion,
			Clientes_Celular,
			Clientes_Correo, 
			Clientes_Alergia,
			Clientes_Enfermedad,
			Clientes_Medicamento,
			Clientes_Status,
			Clientes_Nextel,
			Clientes_Referido,
			Clientes_Cumplido
		  ) 
		  VALUES
		  ( 
		    @nombre,
			@apellidos,
			@telefono,
			@ciudad, 
			@edad,
			@sexo,
			@Direccion,
			@celular,
			@correo, 
			@alergia,
			@enfermedad,
			@medicamento,
			@status,
			@nextel,
			@referido,
			@cumplido 
		  )
		
	END