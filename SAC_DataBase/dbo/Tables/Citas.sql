CREATE TABLE [dbo].[Citas] (
    [IdCita]       INT          IDENTITY (1, 1) NOT NULL,
    [IdCliente]    INT          NULL,
    [Citas_Fecha]  DATE         NOT NULL,
    [Citas_Estado] INT          NOT NULL,
    [Citas_Hora]   VARCHAR (15) NOT NULL,
    [Citas_Tipo]   VARCHAR (20) NULL,
    [Citas_Areas]  VARCHAR (50) NULL,
    [IdUsuario]    INT          NULL,
    [Citas_Fin]    VARCHAR (15) NULL,
    [Citas_Nombre] VARCHAR (50) NULL,
    CONSTRAINT [PK_Citas] PRIMARY KEY CLUSTERED ([IdCita] ASC),
    CONSTRAINT [FK_Citas_Clientes] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Clientes] ([IdCliente]),
    CONSTRAINT [FK_Citas_Usuarios] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[Usuarios] ([IdUsuario])
);

