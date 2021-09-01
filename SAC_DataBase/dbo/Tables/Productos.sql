CREATE TABLE [dbo].[Productos] (
    [IdProductos]           INT          IDENTITY (1, 1) NOT NULL,
    [Productos_Descripcion] VARCHAR (50) NOT NULL,
    [Productos_Existencia]  INT          CONSTRAINT [DF_Productos_Productos_Existencia] DEFAULT ((0)) NOT NULL,
    [Productos_Precio]      MONEY        NOT NULL,
    [Productos_StockMinimo] INT          CONSTRAINT [DF_Productos_Productos_StockMinimo] DEFAULT ((0)) NOT NULL,
    [Productos_Status]      TINYINT      NULL,
    [Productos_Nombre]      VARCHAR (50) NULL,
    [Productos_Tipo]        TINYINT      NULL,
    [Producto_Marca]        VARCHAR (50) NULL,
    CONSTRAINT [PK__Producto__718C7D064BAC3F29] PRIMARY KEY NONCLUSTERED ([IdProductos] ASC) WITH (FILLFACTOR = 100)
);

