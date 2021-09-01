CREATE TABLE [dbo].[Paquete] (
    [IdPaquete]      INT          IDENTITY (1, 1) NOT NULL,
    [Paquete_Nombre] VARCHAR (50) NULL,
    [Paquete_Precio] MONEY        NULL,
    [Paquete_Status] TINYINT      NULL,
    CONSTRAINT [PK_Paquete] PRIMARY KEY CLUSTERED ([IdPaquete] ASC)
);

