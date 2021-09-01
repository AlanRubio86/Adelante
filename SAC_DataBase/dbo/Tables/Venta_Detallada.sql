CREATE TABLE [dbo].[Venta_Detallada] (
    [VtaDet_IdVenta]    INT   NOT NULL,
    [VtaDet_IdProducto] INT   NOT NULL,
    [VtaDet_Cantidad]   INT   NOT NULL,
    [VtaDet_Precio]     MONEY NOT NULL,
    CONSTRAINT [FK_Venta_Detallada_Productos] FOREIGN KEY ([VtaDet_IdProducto]) REFERENCES [dbo].[Productos] ([IdProductos]),
    CONSTRAINT [FK_Venta_Detallada_Ventas] FOREIGN KEY ([VtaDet_IdVenta]) REFERENCES [dbo].[Ventas] ([IdVenta])
);

