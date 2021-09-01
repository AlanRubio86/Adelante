CREATE TABLE [dbo].[AreasXCliente] (
    [idArea]                 INT NULL,
    [idCliente]              INT NULL,
    [Areasxcliente_sesiones] INT CONSTRAINT [DF_AreasXCliente_Areasxcliente_sesiones] DEFAULT ((0)) NULL,
    [Areasxcliente_retoque]  BIT NULL,
    [Areasxcliente_pagados]  INT CONSTRAINT [DF_AreasXCliente_Areasxcliente_pagados] DEFAULT ((0)) NULL
);

