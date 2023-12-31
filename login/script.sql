USE [BD_alumnos]
GO
/****** Object:  Table [dbo].[alumnos]    Script Date: 09/10/2023 21:14:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[alumnos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[alumnos](
	[alum_id] [int] IDENTITY(1,1) NOT NULL,
	[alum_nombre] [varchar](255) NOT NULL,
	[alum_apellido] [varchar](255) NOT NULL,
	[alum_dni] [varchar](255) NOT NULL,
	[alum_edad] [int] NOT NULL,
	[alum_email] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[alum_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 09/10/2023 21:14:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[usuario](
	[usua_id] [int] IDENTITY(1,1) NOT NULL,
	[usua_usuario] [varchar](255) NOT NULL,
	[usua_password] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[usua_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[alumnos] ON 

INSERT [dbo].[alumnos] ([alum_id], [alum_nombre], [alum_apellido], [alum_dni], [alum_edad], [alum_email]) VALUES (1, N'Aramis', N'Barello', N'48.253.369', 21, N'aramis@gmail.com')
INSERT [dbo].[alumnos] ([alum_id], [alum_nombre], [alum_apellido], [alum_dni], [alum_edad], [alum_email]) VALUES (2, N'Taiel', N'Fuentes', N'58.152.165', 26, N'taiel@gmail.com')
INSERT [dbo].[alumnos] ([alum_id], [alum_nombre], [alum_apellido], [alum_dni], [alum_edad], [alum_email]) VALUES (3, N'Maria', N'Moreno', N'42.365.896', 21, N'Maria@gmail.com')
SET IDENTITY_INSERT [dbo].[alumnos] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([usua_id], [usua_usuario], [usua_password]) VALUES (1, N'tomas', N'123')
INSERT [dbo].[usuario] ([usua_id], [usua_usuario], [usua_password]) VALUES (2, N'admim', N'admin')
INSERT [dbo].[usuario] ([usua_id], [usua_usuario], [usua_password]) VALUES (3, N'mateo', N'1234')
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_Validar_Usuario]    Script Date: 09/10/2023 21:14:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_Validar_Usuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_Validar_Usuario] AS' 
END
GO
create procedure [dbo].[SP_Validar_Usuario](
@user varchar (255),
@password varchar (255)
)
as 
begin
select usua_id from usuario where usua_usuario=@user and usua_password=@password
end
GO
create procedure SP_Eliminar_Alumnos(
@id int
)
as
begin
delete from alumnos where alum_id=@id
end

create procedure SP_Modificar_Alumnos(
@id int,
@nombre varchar (255),
@apellido varchar (255),
@dni varchar (255),
@edad int ,
@email varchar (255)
)
as 
begin
update alumnos
set 
	alum_nombre=@nombre,
	alum_apellido=@apellido,
	alum_dni=@dni,
	alum_edad=@edad,
	alum_email=@email
	where  alum_id = @id
end

create procedure [dbo].[SP_Ingresar_Alumnos](
@Nombre varchar (255), 
@Apellido varchar (255),
@dni varchar (255) ,
@edad int,
@email varchar (255)
)
as 
begin
insert into alumnos (alum_nombre, alum_apellido, alum_dni, alum_edad, alum_email) values (@Nombre, @Apellido, @dni, @edad, @email)

end
GO

select * from alumnos

create procedure SP_Obtener_alumnos
as
begin
select * from alumnos
end