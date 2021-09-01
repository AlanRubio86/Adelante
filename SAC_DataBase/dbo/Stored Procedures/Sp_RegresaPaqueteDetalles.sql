CREATE PROCEDURE [dbo].[Sp_RegresaPaqueteDetalles]
@idPaquete INT 
WITH 
EXECUTE AS CALLER
AS
SELECT 
			 DetallePaquete.*,
			 Productos.IdProductos,
			 Productos.Productos_Nombre,
			 Productos.Productos_Descripcion
			  
	         
		FROM DetallePaquete    
          
  INNER JOIN dbo.Productos
          ON Productos.IdProductos = DetallePaquete.IdArea  
   
       WHERE DetallePaquete.IdPaquete = @idPaquete