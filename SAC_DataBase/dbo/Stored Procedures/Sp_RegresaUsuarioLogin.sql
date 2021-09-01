
CREATE proc [dbo].[Sp_RegresaUsuarioLogin] 
@nick varchar(10)
as
Declare @id int
set @id=( 
          SELECT Usuarios.IdUsuario 
            FROM Usuarios 
      
      INNER JOIN Acceso 
              ON Usuarios.IdUsuario=Acceso.IdUsuario 
           
           WHERE Acceso.Acceso_Nickname=@nick
           
         )
         
	      SELECT 
		         Usuarios.Usuarios_Nombre+' '+Usuarios.Usuarios_Apellidos as Nombre,
				 Usuarios.IdUsuario,
				 Acceso.* 
		     
			FROM Acceso 
	  
	  INNER JOIN Usuarios 
	          ON Acceso.IdUsuario=Usuarios.IdUsuario 
	          
	   
	          
	       WHERE Usuarios.IdUsuario=@id