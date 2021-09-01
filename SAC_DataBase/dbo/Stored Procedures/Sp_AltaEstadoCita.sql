CREATE PROCEDURE [dbo].[Sp_AltaEstadoCita] 
	
	@cita int,
	@estado INT,
	@cliente int
AS
 INSERT INTO dbo.EstadoXCita
         ( idcita, estado,cliente )
 VALUES  ( @cita, -- idcita - int
           @estado,  -- estado - int
           @cliente
           )