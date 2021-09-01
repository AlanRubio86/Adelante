CREATE PROCEDURE [dbo].[Sp_RegresaUsuario]
@dato varchar(50), @status tinyint
WITH 
EXECUTE AS CALLER
AS
SELECT  
            Usuarios.*, 
            Acceso.Acceso_Nickname,
			Acceso.Acceso_Password,
			Acceso.Acceso_MovCitas,
			Acceso.Acceso_MovTrat,
			Acceso.Acceso_CatUsuarios,
			Acceso.Acceso_CatClientes,
			Acceso.Acceso_CatAreas,
			Acceso.Acceso_RepUsuarios,
			Acceso.Acceso_RepClientes,
			Acceso.Acceso_RepAreas,
			Acceso.Acceso_RepProductos,
			Acceso.Acceso_RepCitas,
			Acceso.Acceso_RepTrat,
			Acceso.Acceso_MovVentas,
			Acceso.Acceso_MovCajas,
			Acceso.Acceso_MovAbonos,
			Acceso.Acceso_CatProductos,
			Acceso.Acceso_CatCajas,
			Acceso.Acceso_RepPunto,
			Acceso.Acceso_RepMovUsuario,
			Acceso.Acceso_AdminDB,
			Acceso.Acceso_Algortimo,
            CASE Usuarios.Usuarios_status 
                 WHEN 1 THEN 'Deshabilitado'
            ELSE 'Habilitado' END AS Estado

		  FROM Usuarios 
		   
INNER JOIN Acceso
	    	ON Acceso.IdUsuario = Usuarios.IdUsuario 
		   
		 WHERE Usuarios.Usuarios_Nombre LIKE @dato 
       AND Usuarios.Usuarios_status = 
           CASE @status WHEN 2 THEN Usuarios.Usuarios_status
           ELSE @status END
			 
      
UNION 

  SELECT  
			   Usuarios.*, 
			    Acceso.Acceso_Nickname,
				Acceso.Acceso_Password,
				Acceso.Acceso_MovCitas,
				Acceso.Acceso_MovTrat,
				Acceso.Acceso_CatUsuarios,
				Acceso.Acceso_CatClientes,
				Acceso.Acceso_CatAreas,
				Acceso.Acceso_RepUsuarios,
				Acceso.Acceso_RepClientes,
				Acceso.Acceso_RepAreas,
				Acceso.Acceso_RepProductos,
				Acceso.Acceso_RepCitas,
				Acceso.Acceso_RepTrat,
				Acceso.Acceso_MovVentas,
				Acceso.Acceso_MovCajas,
				Acceso.Acceso_MovAbonos,
				Acceso.Acceso_CatProductos,
				Acceso.Acceso_CatCajas,
				Acceso.Acceso_RepPunto,
				Acceso.Acceso_RepMovUsuario,
				Acceso.Acceso_AdminDB,
				Acceso.Acceso_Algortimo,
         CASE Usuarios.Usuarios_status 
              WHEN 1 THEN 'Deshabilitado'
         ELSE 'Habilitado' END AS Estado

		  FROM Usuarios 
		   
    INNER JOIN Acceso
	    	ON Acceso.IdUsuario = Usuarios.IdUsuario 
		   
		 WHERE Usuarios.Usuarios_Apellidos LIKE @dato 
       AND Usuarios.Usuarios_status = 
           CASE @status WHEN 2 THEN Usuarios.Usuarios_status
           ELSE @status END
UNION

     SELECT 

			   Usuarios.*, 
			    Acceso.Acceso_Nickname,
				Acceso.Acceso_Password,
				Acceso.Acceso_MovCitas,
				Acceso.Acceso_MovTrat,
				Acceso.Acceso_CatUsuarios,
				Acceso.Acceso_CatClientes,
				Acceso.Acceso_CatAreas,
				Acceso.Acceso_RepUsuarios,
				Acceso.Acceso_RepClientes,
				Acceso.Acceso_RepAreas,
				Acceso.Acceso_RepProductos,
				Acceso.Acceso_RepCitas,
				Acceso.Acceso_RepTrat,
				Acceso.Acceso_MovVentas,
				Acceso.Acceso_MovCajas,
				Acceso.Acceso_MovAbonos,
				Acceso.Acceso_CatProductos,
				Acceso.Acceso_CatCajas,
				Acceso.Acceso_RepPunto,
				Acceso.Acceso_RepMovUsuario,
				Acceso.Acceso_AdminDB,
				Acceso.Acceso_Algortimo,
         CASE Usuarios.Usuarios_status 
              WHEN 1 THEN 'Deshabilitado'
         ELSE 'Habilitado' END AS Estado

		  FROM Usuarios 
		   
    INNER JOIN Acceso
	    	    ON Acceso.IdUsuario = Usuarios.IdUsuario 
		   
		 WHERE Acceso.Acceso_Nickname LIKE @dato
       AND Usuarios.Usuarios_status = 
           CASE @status WHEN 2 THEN Usuarios.Usuarios_status
           ELSE @status END