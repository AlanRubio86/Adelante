CREATE PROCEDURE [dbo].[Sp_RegresaMovCajas]
@desde DATETIME, 
@hasta DATETIME
WITH 
EXECUTE AS CALLER
AS
SELECT 
         CajasAbiertas.Caja_Concepto,
         CajasAbiertas.Caja_Cantidad AS Entrada,
         NULL AS Salida,
         CajasAbiertas.Caja_Fecha, 
         Usuarios.Usuarios_Nombre +' '+ Usuarios_Apellidos AS Nombre_Usuario 

    FROM CajasAbiertas
    INNER JOIN Usuarios
            ON IdUsuario = dbo.CajasAbiertas.IdUsuarioSesion
    
   WHERE CajasAbiertas.Caja_Cantidad > 0
     AND CajasAbiertas.Caja_Fecha BETWEEN @desde AND @hasta 
    
			 
   UNION
   
  SELECT 
         CajasAbiertas.Caja_Concepto,
         NULL AS Entrada,
         CajasAbiertas.Caja_Cantidad * -1  AS Salida,
         CajasAbiertas.Caja_Fecha, 
         Usuarios.Usuarios_Nombre +' '+ Usuarios_Apellidos AS Nombre_Usuario 

    FROM CajasAbiertas
    INNER JOIN Usuarios
            ON IdUsuario = dbo.CajasAbiertas.IdUsuarioSesion
    
   WHERE  CajasAbiertas.Caja_Cantidad < 0
      AND CajasAbiertas.Caja_Fecha BETWEEN @desde AND @hasta 
      
      ORDER BY Caja_Fecha DESC