USE [BD_alumnos]
GO
/****** Object:  Table [dbo].[alumnos]    Script Date: 30/10/2023 21:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumnos](
	[alum_id] [int] IDENTITY(1,1) NOT NULL,
	[alum_nombre] [varchar](255) NOT NULL,
	[alum_email] [varchar](255) NOT NULL,
	[alum_edad] [int] NOT NULL,
	[alum_direccion] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[alum_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 30/10/2023 21:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[usua_id] [int] IDENTITY(1,1) NOT NULL,
	[usua_usuario] [varchar](255) NOT NULL,
	[usua_contraseña] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[usua_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[alumnos] ON 

INSERT [dbo].[alumnos] ([alum_id], [alum_nombre], [alum_email], [alum_edad], [alum_direccion]) VALUES (1, N'Tomas', N'tmas@gmail.com', 18, N'tropa 123')
INSERT [dbo].[alumnos] ([alum_id], [alum_nombre], [alum_email], [alum_edad], [alum_direccion]) VALUES (2, N'Elizabeth', N'E123@gmail.com', 20, N'candido irazusta')
SET IDENTITY_INSERT [dbo].[alumnos] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([usua_id], [usua_usuario], [usua_contraseña]) VALUES (1, N'tomas', N'123')
INSERT [dbo].[usuario] ([usua_id], [usua_usuario], [usua_contraseña]) VALUES (2, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_Ingresar_Alumnos]    Script Date: 30/10/2023 21:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Ingresar_Alumnos](
@Nombre varchar (255), 
@Email varchar (255),
@edad int ,
@direccion varchar (255)
)
as 
begin
insert into alumnos (alum_nombre, alum_email, alum_edad, alum_direccion) values (@Nombre, @Email, @edad, @direccion)

end
GO
/****** Object:  StoredProcedure [dbo].[SP_Validar_Usuario]    Script Date: 30/10/2023 21:11:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Validar_Usuario](
@NombreUsuario varchar (255), 
@Contraseña varchar (255)
)
as 
begin
select usua_id from usuario where usua_usuario=@NombreUsuario and usua_contraseña = @Contraseña

end
GO
