CREATE proc [dbo].[Sp_RegresaCantCitas]
@idCliente INT
as

SELECT    
        Count(*) AS Total_XConfirmar, 
        0 AS Total_Confirmadas,
        0 AS Total_Canceladas,
        0 AS Total_Asistidas,
        0 AS Total_NoAsistidas 
		
   FROM EstadoXCita  
  WHERE EstadoXCita.cliente = @idCliente
    AND EstadoXCita.estado = 0

UNION ALL

SELECT    
        0 AS Total_XConfirmar, 
        Count(*) AS Total_Confirmadas,
        0 AS Total_Canceladas,
        0 AS Total_Asistidas,
        0 AS Total_NoAsistidas 
		
   FROM EstadoXCita  
  WHERE EstadoXCita.cliente = @idCliente
    AND EstadoXCita.estado = 1	 
    
UNION ALL

SELECT    
        0 AS Total_XConfirmar, 
        0 AS Total_Confirmadas,
        Count(*) AS Total_Canceladas,
        0 AS Total_Asistidas,
        0 AS Total_NoAsistidas
		 
   FROM EstadoXCita  
  WHERE EstadoXCita.cliente = @idCliente
    AND EstadoXCita.estado = 2
    
UNION ALL

SELECT    
        0 AS Total_XConfirmar, 
        0 AS Total_Confirmadas,
        0 AS Total_Canceladas,
        Count(*) AS Total_Asistidas,
        0 AS Total_NoAsistidas
		 
   FROM EstadoXCita  
  WHERE EstadoXCita.cliente = @idCliente
    AND EstadoXCita.estado = 3
    
UNION ALL

SELECT    
        0 AS Total_XConfirmar, 
        0 AS Total_Confirmadas,
        0 AS Total_Canceladas,
        0 AS Total_Asistidas,
        Count(*) AS Total_NoAsistidas
		 
   FROM EstadoXCita  
  WHERE EstadoXCita.cliente = @idCliente
    AND EstadoXCita.estado = 4