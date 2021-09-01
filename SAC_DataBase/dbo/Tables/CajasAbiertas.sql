CREATE TABLE [dbo].[CajasAbiertas] (
    [IdMovCaja]       INT           IDENTITY (1, 1) NOT NULL,
    [Caja_Concepto]   VARCHAR (MAX) NULL,
    [Caja_Cantidad]   MONEY         NOT NULL,
    [Caja_Fecha]      DATETIME      NOT NULL,
    [IdUsuarioSesion] INT           NULL,
    CONSTRAINT [PK_CajasAbiertas] PRIMARY KEY CLUSTERED ([IdMovCaja] ASC),
    CONSTRAINT [FK_CajasAbiertas_Usuarios] FOREIGN KEY ([IdUsuarioSesion]) REFERENCES [dbo].[Usuarios] ([IdUsuario])
);

