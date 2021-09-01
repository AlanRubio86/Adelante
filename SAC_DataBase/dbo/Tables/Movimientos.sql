CREATE TABLE [dbo].[Movimientos] (
    [IdMov]                   INT           IDENTITY (1, 1) NOT NULL,
    [IdUsuario]               INT           NULL,
    [Movimientos_Descripcion] VARCHAR (200) NOT NULL,
    [Movimientos_Fecha]       DATETIME      CONSTRAINT [DF_Movimientos_Movimientos_Fecha] DEFAULT (getdate()) NOT NULL,
    [Movimientos_Tipo]        INT           NULL,
    CONSTRAINT [PK_Movimientos] PRIMARY KEY CLUSTERED ([IdMov] ASC),
    CONSTRAINT [FK_Movimientos_Usuarios] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[Usuarios] ([IdUsuario])
);

