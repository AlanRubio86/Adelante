CREATE TABLE [dbo].[Adeudos] (
    [IdAdeudo]      INT           IDENTITY (1, 1) NOT NULL,
    [IdCliente]     INT           NULL,
    [Adeudo_Monto]  MONEY         NULL,
    [Adeudo_Saldo]  MONEY         NULL,
    [Adeudo_Fecha]  DATETIME      NULL,
    [Adeudo_Tipo]   INT           NULL,
    [Adeudo_Pagos]  INT           CONSTRAINT [DF_Adeudos_Adeudo_Status] DEFAULT ((0)) NULL,
    [Adeudo_Motivo] VARCHAR (MAX) NULL,
    [Adeudo_Pagado] TINYINT       CONSTRAINT [DF_Adeudos_Adeudo_Pagado] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_Adeudos] PRIMARY KEY CLUSTERED ([IdAdeudo] ASC),
    CONSTRAINT [FK_Adeudos_Clientes] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Clientes] ([IdCliente])
);

