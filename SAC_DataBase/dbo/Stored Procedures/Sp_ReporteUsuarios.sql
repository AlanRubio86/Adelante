
CREATE PROCEDURE Sp_ReporteUsuarios
AS
select Usuarios.*,Acceso.Acceso_Nickname from Usuarios inner join Acceso on Usuarios.IdUsuario=Acceso.IdUsuario