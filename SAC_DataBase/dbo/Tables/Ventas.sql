CREATE TABLE [dbo].[Ventas] (
    [IdVenta]         INT      IDENTITY (1, 1) NOT NULL,
    [Venta_idUsuario] INT      NOT NULL,
    [Venta_Fecha]     DATETIME NOT NULL,
    [Venta_Importe]   MONEY    NOT NULL,
    [IdCliente]       INT      NOT NULL,
    [Venta_Tipo]      INT      NOT NULL,
    [Venta_Status]    TINYINT  CONSTRAINT [DF_Ventas_Venta_Status] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED ([IdVenta] ASC),
    CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Clientes] ([IdCliente]),
    CONSTRAINT [FK_Ventas_Usuarios] FOREIGN KEY ([Venta_idUsuario]) REFERENCES [dbo].[Usuarios] ([IdUsuario])
);

