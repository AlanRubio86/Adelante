CREATE TABLE [dbo].[DetalleServicios] (
    [IdServicio]                 INT          NULL,
    [DetServ_IdProducto]         INT          NULL,
    [DetalleServicio_Frecuencia] VARCHAR (50) NULL,
    CONSTRAINT [FK_DetalleServicios_Productos] FOREIGN KEY ([DetServ_IdProducto]) REFERENCES [dbo].[Productos] ([IdProductos]),
    CONSTRAINT [FK_DetalleServicios_Servicio] FOREIGN KEY ([IdServicio]) REFERENCES [dbo].[Servicio] ([IdServicio])
);

