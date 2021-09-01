CREATE TABLE [dbo].[Recordatorio] (
    [Fecha]  DATE CONSTRAINT [DF_Recordatorio_Fecha] DEFAULT (getdate()) NOT NULL,
    [Estado] BIT  NOT NULL
);

