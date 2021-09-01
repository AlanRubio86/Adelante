CREATE TABLE [dbo].[Servicio] (
    [IdServicio]        INT           IDENTITY (1, 1) NOT NULL,
    [IdCliente]         INT           NULL,
    [Servicio_Fecha]    DATE          NULL,
    [IdUsuario]         INT           NULL,
    [Servicio_Notas]    VARCHAR (200) NULL,
    [Servicio_Tipo]     VARCHAR (50)  NULL,
    [Servicio_Unipolar] VARCHAR (50)  NULL,
    [Servicio_Bipolar]  VARCHAR (50)  NULL,
    [Servicio_Medidas]  VARCHAR (50)  NULL,
    [Servicio_Hora]     TIME (7)      NULL,
    [Servicio_Status]   BIT           CONSTRAINT [DF_Servicio_Servicio_Status] DEFAULT ((1)) NULL,
    CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED ([IdServicio] ASC),
    CONSTRAINT [FK_Servicio_Clientes] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Clientes] ([IdCliente]),
    CONSTRAINT [FK_Servicio_Usuarios] FOREIGN KEY ([IdUsuario]) REFERENCES [dbo].[Usuarios] ([IdUsuario])
);

