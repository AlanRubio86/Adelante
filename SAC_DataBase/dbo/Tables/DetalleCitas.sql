CREATE TABLE [dbo].[DetalleCitas] (
    [IdCita]     INT NULL,
    [IdProducto] INT NULL,
    CONSTRAINT [FK_DetalleCitas_Citas] FOREIGN KEY ([IdCita]) REFERENCES [dbo].[Citas] ([IdCita]),
    CONSTRAINT [FK_DetalleCitas_Productos] FOREIGN KEY ([IdProducto]) REFERENCES [dbo].[Productos] ([IdProductos])
);

