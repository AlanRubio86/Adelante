CREATE PROC [dbo].[Sp_AltaAreaXClienteAdeudo]
@idarea INT,
@idcliente INT, 
@retoque BIT,
@pagados INT
AS
DECLARE @aux INT
SET @aux=(SELECT COUNT(*) FROM dbo.AreasXCliente WHERE idArea=@idarea AND idCliente=@idcliente)

IF(@aux>0)
BEGIN
UPDATE dbo.AreasXCliente 
		SET 
		--Areasxcliente_sesiones=Areasxcliente_sesiones,
		Areasxcliente_retoque=@retoque,
		Areasxcliente_pagados=Areasxcliente_pagados+@pagados 
		WHERE idArea=@idarea AND idCliente=@idcliente 
END
ELSE
BEGIN
INSERT INTO dbo.AreasXCliente
        ( idArea ,
          idCliente ,
          Areasxcliente_sesiones,
          Areasxcliente_retoque,
          Areasxcliente_pagados
        )
VALUES  ( @idarea , -- idArea - int
          @idcliente , -- idCliente - int
          0 , -- Areasxcliente_sesiones - int
          @retoque,  -- Areasxcliente_retoque - bit
          @pagados
        ) 
END