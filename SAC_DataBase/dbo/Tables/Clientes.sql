CREATE TABLE [dbo].[Clientes] (
    [IdCliente]            INT          IDENTITY (1, 1) NOT NULL,
    [Clientes_Nombre]      VARCHAR (50) NOT NULL,
    [Clientes_Apellidos]   VARCHAR (50) NOT NULL,
    [Clientes_Telefono]    VARCHAR (15) NULL,
    [Clientes_Ciudad]      VARCHAR (20) NOT NULL,
    [Clientes_Edad]        DATETIME     NULL,
    [Clientes_Sexo]        VARCHAR (6)  NULL,
    [Clientes_Direccion]   VARCHAR (50) NOT NULL,
    [Clientes_Celular]     VARCHAR (15) NULL,
    [Clientes_Correo]      VARCHAR (50) NULL,
    [Clientes_Alergia]     VARCHAR (50) NULL,
    [Clientes_Enfermedad]  VARCHAR (50) NULL,
    [Clientes_Medicamento] VARCHAR (50) NULL,
    [Clientes_Status]      TINYINT      NOT NULL,
    [Clientes_Nextel]      VARCHAR (20) NULL,
    [Clientes_Referido]    VARCHAR (50) NULL,
    [Clientes_Cumplido]    TINYINT      NULL,
    [Clientes_Fecha]       DATETIME     CONSTRAINT [DF_Clientes_Clientes_Fecha] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED ([IdCliente] ASC)
);

