CREATE PROCEDURE [dbo].[Sp_AltaUsuario]  
@id int,  @nombre varchar(20),  @apellidos varchar(25),  @puesto varchar(50),   @Direccion varchar(50),   @telefono varchar(15),   @ciudad varchar(20),   @edad int,   @celular varchar(15),   @correo varchar(50),   @nick varchar(10),   @pass varchar(10),  
 @movcitas varchar(1),   @movtrat varchar(1),   @catusua varchar(1),   @catclie varchar(1),   @catarea varchar(1),   @repusua varchar(1),   @repclie varchar(1),   @reparea varchar(1),   @repproductos varchar(1),   @repcitas varchar(1),   @reptrat varchar(
1),   @movventas varchar(1),  @movcajas varchar(1),  @movabonos varchar(1),  @catproductos varchar(1),  @catcajas varchar(1),  @reppunto varchar(1),  @movusuarios varchar(1),  @admindb varchar(1),  @algoritmo varchar(1),  @status bit WITH  EXECUTE AS CALLER  
AS  
Declare  
@aux int 

declare @Aux2 int
Set @aux=(select COUNT(*) from Usuarios where IdUsuario=@id)  
if(@aux>0)  
begin  
update Usuarios set Usuarios_Nombre=@nombre,Usuarios_Apellidos=@apellidos,Usuarios_Puesto=@puesto,Usuarios_Direccion=@Direccion,Usuarios_Telefono=@telefono,Usuarios_Ciudad=@ciudad,Usuarios_Edad=@edad,Usuarios_Celular=@celular,Usuarios_Correo=@correo,Usuarios_status=@status where IdUsuario=@id  
update Acceso set   
Acceso_Nickname=@nick,  
Acceso_Password=@pass,  
Acceso_MovCitas=@movcitas,  
Acceso_MovTrat=@movtrat,  
Acceso_CatUsuarios=@catusua,  
Acceso_CatClientes=@catclie,  
Acceso_CatAreas=@catarea,  
Acceso_RepUsuarios=@repusua,  
Acceso_RepClientes=@repclie,  
Acceso_RepAreas=@reparea,  
Acceso_RepProductos=@repproductos,  
Acceso_RepCitas=@repcitas,  
Acceso_RepTrat=@reptrat,  
Acceso_MovVentas=@movventas,  
Acceso_MovCajas=@movcajas,  
Acceso_MovAbonos=@movabonos,  
Acceso_CatProductos=@catproductos,  
Acceso_CatCajas=@catcajas,  
Acceso_RepPunto=@reppunto,  
Acceso_RepMovUsuario=@movusuarios,  
Acceso_AdminDB=@admindb,  
Acceso_Algortimo=@algoritmo  
where IdUsuario=@id  
end  
else  
begin  
insert into Usuarios(  
Usuarios_Nombre,  
Usuarios_Apellidos,  
Usuarios_Puesto,  
Usuarios_Direccion,  
Usuarios_Telefono,  
Usuarios_Ciudad,  
Usuarios_Edad,  
Usuarios_Celular,  
Usuarios_Correo,  
Usuarios_status)  
values(  
@nombre,    
@apellidos,      
@puesto,    
@Direccion,     
@telefono,     
@ciudad,    
@edad,  
@celular,     
@correo ,  
@status)

set @Aux2=@@IDENTITY
insert into Acceso   
(  
IdUsuario,  
Acceso_Nickname,  
Acceso_Password,  
Acceso_MovCitas,  
Acceso_MovTrat,  
Acceso_CatUsuarios,  
Acceso_CatClientes,  
Acceso_CatAreas,  
Acceso_RepUsuarios,  
Acceso_RepClientes,  
Acceso_RepAreas,  
Acceso_RepProductos,  
Acceso_RepCitas,  
Acceso_RepTrat,  
Acceso_MovVentas,  
Acceso_MovCajas,  
Acceso_MovAbonos,  
Acceso_CatProductos,  
Acceso_CatCajas,  
Acceso_RepPunto,  
Acceso_RepMovUsuario,  
Acceso_AdminDB,  
Acceso_Algortimo  
)values(  
@Aux2,  
@nick,     
@pass,     
@movcitas ,   
@movtrat,  
@catusua,    
@catclie,  
@catarea,  
@repusua,  
@repclie,  
@reparea,  
@repproductos,  @repcitas,  @reptrat,  @movventas, @movcajas, @movabonos, @catproductos, @catcajas, @reppunto, @movusuarios, @admindb, @algoritmo  
)  
end