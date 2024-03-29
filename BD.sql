USE [PROYECTO1]
GO
Table [dbo].[USUARIOS]    

GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[nombres] [varchar](50) NULL,
	[apellidos] [varchar](50) NULL,
	[nombre_usuario] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NULL,
	[fecha_nacimiento] [varchar](50) NULL,
	[pais] [varchar](50) NULL,
	[correo_electronico] [varchar](50) NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)
GO
