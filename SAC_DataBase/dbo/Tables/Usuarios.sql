CREATE TABLE [dbo].[Usuarios] (
    [IdUsuario]          INT          IDENTITY (2, 1) NOT NULL,
    [Usuarios_Nombre]    VARCHAR (20) NOT NULL,
    [Usuarios_Apellidos] VARCHAR (25) NOT NULL,
    [Usuarios_Puesto]    VARCHAR (50) NOT NULL,
    [Usuarios_Direccion] VARCHAR (50) NOT NULL,
    [Usuarios_Telefono]  VARCHAR (15) NULL,
    [Usuarios_Ciudad]    VARCHAR (20) NOT NULL,
    [Usuarios_Edad]      INT          NULL,
    [Usuarios_Celular]   VARCHAR (15) NULL,
    [Usuarios_Correo]    VARCHAR (50) NULL,
    [Usuarios_Status]    TINYINT      CONSTRAINT [DF_Usuarios_Usuarios_Status] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED ([IdUsuario] ASC)
);

