CREATE PROCEDURE [dbo].[Sp_RegresaAbonosDetalles]
@idAbono INT 
WITH 
EXECUTE AS CALLER
AS
SELECT 
			 Adeudos.IdAdeudo, 
			 DetalleAbonos.DetAbono_Abono,
			 Adeudos.Adeudo_Saldo,
			 DetalleAbonos.DetAbono_Abono + Adeudos.Adeudo_Monto AS Comodin, 
			 Adeudos.Adeudo_Pagos,
			 Adeudos.Adeudo_Tipo,
			 CASE Adeudos.Adeudo_Tipo 
			   WHEN 1 THEN 'Pagado'
			   WHEN 2 THEN 'En pagos'
			   WHEN 3 THEN 'Por sesion'
			 ELSE 'Retoque' END AS Tipo_Descripcion , 
			 Adeudo_Monto,
			 Adeudos.Adeudo_Fecha 
	         
		FROM Adeudos   
          
  INNER JOIN DetalleAbonos
          ON DetalleAbonos.IdAdeudo = Adeudos.IdAdeudo 
    
       WHERE DetalleAbonos.idAbono = @idAbono