USE [BD_resto]
GO
/****** Object:  Table [dbo].[mesa_productos]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mesa_productos](
	[mepr_id] [int] IDENTITY(1,1) NOT NULL,
	[mepr_mesa_id] [int] NOT NULL,
	[mepr_prod_id] [int] NOT NULL,
	[mepr_precio] [float] NOT NULL,
	[mepr_cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mepr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mesas]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mesas](
	[mesa_id] [int] IDENTITY(1,1) NOT NULL,
	[mesa_numero] [int] NOT NULL,
	[mesa_capacidad] [int] NOT NULL,
	[mesa_estado] [bit] NOT NULL,
	[mesa_descripcion] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mesa_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[prod_id] [int] IDENTITY(1,1) NOT NULL,
	[prod_nombre] [varchar](255) NOT NULL,
	[prod_precio] [float] NOT NULL,
	[prod_numero] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[prod_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_cargar_mesas]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_cargar_mesas] (
@numero int,
@capacidad int,
@estado bit,
@descripcion varchar (255)
)
as 
begin
insert into mesas (mesa_numero, mesa_capacidad, mesa_estado, mesa_descripcion) values (@numero, @capacidad, @estado, @descripcion)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_cargar_productos]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_cargar_productos] (
@nombre varchar (255),
@precio float,
@numero int
)
as 
begin
insert into productos (prod_nombre, prod_precio, prod_numero) values (@nombre, @precio,@numero)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_mesa_producto]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminar_mesa_producto]
    @id INT
AS
BEGIN
    IF EXISTS (SELECT * FROM mesa_producto WHERE mepr_id = @id)
    BEGIN
        DELETE FROM mesa_productos WHERE mepr_id = @id
        -- Puedes agregar más acciones aquí después de la eliminación si es necesario
    END
    ELSE
    BEGIN
        PRINT 'El registro no existe.' -- O maneja el mensaje de otra manera que consideres adecuada
    END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_mesas]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_eliminar_mesas](
@id int
)
as 
begin
delete from mesas where mesa_id =@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_productos]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_eliminar_productos](
@id int
)
as 
begin
delete from productos where prod_id =@id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_mesa_prod]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_insertar_mesa_prod](
@mesa_id int,
@prod_id int,
@precio float,
@cantidad int
)
as
begin
insert into mesa_productos (mepr_mesa_id, mepr_prod_id,mepr_precio,mepr_cantidad) values (@mesa_id,@prod_id,@precio,@cantidad);
end
GO
/****** Object:  StoredProcedure [dbo].[sp_modificar_mesas]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_modificar_mesas](
@id int,
@numero int,
@capacidad int,
@estado bit,
@descripcion varchar (255)
)
as 
begin
update mesas
set 
	mesa_numero = @numero,
	mesa_capacidad = @capacidad,
	mesa_estado = @estado,
	mesa_descripcion = @descripcion
	where  mesa_id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_modificar_productos]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_modificar_productos](
@id int,
@nombre varchar (255),
@precio float,
@numero int
)
as 
begin
update productos
set 
	prod_nombre= @nombre,
	prod_precio=@precio,
	prod_numero = @numero
	where  prod_id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_obtener_mesa_producto]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_obtener_mesa_producto]
    @id INT
AS
BEGIN
    SELECT * 
	FROM mesa_productos 
    JOIN productos ON mepr_prod_id = prod_id
    WHERE mepr_mesa_id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_obtener_mesas]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_obtener_mesas]
as
begin
select * from mesas
end
GO
/****** Object:  StoredProcedure [dbo].[sp_obtener_productos]    Script Date: 29/11/2023 11:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_obtener_productos]
as 
begin
select * from productos
end
GO
create table usuario(
usua_id int identity (1,1) not null primary key,
usua_nombre varchar (255) not null,
usua_password varchar (255) not null
)
insert into usuario (usua_nombre, usua_password) values ('tomas','123'), ('admin','admin')
create procedure [dbo].[SP_Validar_Usuario](
@user varchar (255),
@password varchar (255)
)
as 
begin
select usua_id from usuario where usua_nombre=@user and usua_password=@password
end

select * from usuario