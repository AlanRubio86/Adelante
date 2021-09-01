CREATE TABLE [dbo].[Abonos] (
    [idAbono]        INT           IDENTITY (1, 1) NOT NULL,
    [idCliente]      INT           NOT NULL,
    [Abono_Total]    MONEY         NOT NULL,
    [Abono_Fecha]    DATETIME      NOT NULL,
    [idUsuario]      INT           NULL,
    [Abono_Motivo]   VARCHAR (MAX) NULL,
    [Abono_ModoPago] VARCHAR (MAX) NULL,
    CONSTRAINT [PK_Abonos] PRIMARY KEY CLUSTERED ([idAbono] ASC)
);

