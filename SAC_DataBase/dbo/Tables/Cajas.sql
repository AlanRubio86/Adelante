CREATE TABLE [dbo].[Cajas] (
    [IdCaja]           INT          IDENTITY (1, 1) NOT NULL,
    [Caja_Descripcion] VARCHAR (20) NOT NULL,
    [Caja_Status]      TINYINT      CONSTRAINT [DF__Cajas__Caja_Stat__489AC854] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Cajas] PRIMARY KEY CLUSTERED ([IdCaja] ASC)
);

