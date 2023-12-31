USE [BD_resto]
GO
/****** Object:  Table [dbo].[mesa_productos]    Script Date: 05/12/2023 19:03:25 ******/
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
/****** Object:  Table [dbo].[mesas]    Script Date: 05/12/2023 19:03:25 ******/
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
/****** Object:  Table [dbo].[productos]    Script Date: 05/12/2023 19:03:25 ******/
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
/****** Object:  Table [dbo].[usuario]    Script Date: 05/12/2023 19:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[usua_id] [int] IDENTITY(1,1) NOT NULL,
	[usua_nombre] [varchar](255) NOT NULL,
	[usua_password] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[usua_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[mesa_productos] ON 

INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (2, 1, 200, 1, 0)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (3, 7, 1497, 1, 0)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (4, 1, 200, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (5, 29, 5000, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (6, 1, 200, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (7, 1, 200, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (8, 1, 200, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (11, 1, 200, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (12, 2, 650, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (14, 6, 500, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (15, 6, 500, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (16, 7, 1497, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (17, 1, 200, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (18, 1, 200, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (21, 3, 800, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (22, 12, 4000, 1, 4)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (44, 5, 1, 200, 1)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (45, 5, 1, 200, 1)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (46, 5, 6, 500, 1)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (47, 5, 6, 500, 1)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (48, 5, 7, 1497, 1)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (49, 5, 7, 1497, 1)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (50, 8, 5, 2890, 1)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (51, 9, 6, 5600, 2)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (52, 1, 6, 200, 12)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (54, 11, 11, 4100, 1)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (56, 1, 10, 200, 1)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (61, 10, 1, 400, 2)
INSERT [dbo].[mesa_productos] ([mepr_id], [mepr_mesa_id], [mepr_prod_id], [mepr_precio], [mepr_cantidad]) VALUES (62, 10, 9, 11200, 2)
SET IDENTITY_INSERT [dbo].[mesa_productos] OFF
GO
SET IDENTITY_INSERT [dbo].[mesas] ON 

INSERT [dbo].[mesas] ([mesa_id], [mesa_numero], [mesa_capacidad], [mesa_estado], [mesa_descripcion]) VALUES (10, 5, 4, 1, N'tiene 4 sillas')
INSERT [dbo].[mesas] ([mesa_id], [mesa_numero], [mesa_capacidad], [mesa_estado], [mesa_descripcion]) VALUES (11, 6, 2, 1, N'le falta una pata a la mesa')
INSERT [dbo].[mesas] ([mesa_id], [mesa_numero], [mesa_capacidad], [mesa_estado], [mesa_descripcion]) VALUES (12, 7, 4, 0, N'tiene 3 sillas')
INSERT [dbo].[mesas] ([mesa_id], [mesa_numero], [mesa_capacidad], [mesa_estado], [mesa_descripcion]) VALUES (13, 8, 2, 1, N'tiene 2 sillas')
INSERT [dbo].[mesas] ([mesa_id], [mesa_numero], [mesa_capacidad], [mesa_estado], [mesa_descripcion]) VALUES (14, 9, 2, 1, N'silla le falta una pata')
SET IDENTITY_INSERT [dbo].[mesas] OFF
GO
SET IDENTITY_INSERT [dbo].[productos] ON 

INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (1, N'Servicio a la mesa', 200, 1)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (2, N'Botella de Agua 500ml', 650, 2)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (3, N'Botella de Gaseosa', 800, 3)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (4, N'Trago sin Alcohol', 1800, 4)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (5, N'Trago con Alcohol', 2300, 5)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (6, N'Empanadas Unidad', 500, 6)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (7, N'Empanadas 3 Unidades', 1497, 7)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (8, N'Empanadas 6 Unidades', 2890, 8)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (9, N'Empanadas 12 Unidades', 5600, 9)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (10, N'Milanesa Simple', 3400, 10)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (11, N'Milanesa con Guarnicion', 4100, 11)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (12, N'Milanesa Napo Simple', 4000, 12)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (13, N'Milanesa Napo con Guarnicion', 4800, 13)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (14, N'Milanesa a Caballo', 4500, 14)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (15, N'Hamburgesa al Plato Simple', 2500, 15)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (16, N'Sanguche de Hamburgesa Simple', 2700, 16)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (17, N'Sanguche de Hamburgesa LyT', 3000, 17)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (18, N'Sanguche de Hamburgesa JyQ ', 3000, 18)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (19, N'Sanguche de Hamburgesa Completo', 3650, 19)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (20, N'Sanguche de Lomo Simple', 3200, 20)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (21, N'Sanguche de Lomo LyT', 3700, 21)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (22, N'Sanguche de Lomo JyQ', 3700, 22)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (23, N'Sanguche de Lomo Completo', 4300, 23)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (24, N'Bife de Pollo', 4000, 24)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (25, N'Bife de Pollo con Guarnicion', 4700, 25)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (26, N'Tira de Asado', 4100, 26)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (27, N'Tira de Asado con Guarnicion', 4800, 27)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (28, N'Bife de Chorizo con Guarnicion de 200g', 4500, 28)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (29, N'Bife de Chorizo con Guarnicion de 400g', 5000, 29)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (30, N'Chorizo', 1000, 31)
INSERT [dbo].[productos] ([prod_id], [prod_nombre], [prod_precio], [prod_numero]) VALUES (31, N'Morcilla', 1000, 32)
SET IDENTITY_INSERT [dbo].[productos] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([usua_id], [usua_nombre], [usua_password]) VALUES (1, N'tomas', N'123')
INSERT [dbo].[usuario] ([usua_id], [usua_nombre], [usua_password]) VALUES (2, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
/****** Object:  StoredProcedure [dbo].[InsertOrUpdateMesaProducto]    Script Date: 05/12/2023 19:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[InsertOrUpdateMesaProducto]
    @mesaId INT,
    @prodId INT,
    @nuevaCantidad INT,
    @nuevoPrecio FLOAT
AS
BEGIN
    DECLARE @existingCount INT;

    -- Verificar si el registro ya existe para la combinación de mesa y producto
    SELECT @existingCount = COUNT(*)
    FROM mesa_productos
    WHERE mepr_mesa_id = @mesaId
    AND mepr_prod_id = @prodId;

    IF @existingCount > 0
    BEGIN
        -- Si existe, actualiza la cantidad y el precio
        UPDATE mesa_productos
        SET mepr_cantidad = mepr_cantidad + @nuevaCantidad,
            mepr_precio = mepr_precio + (@nuevoPrecio * @nuevaCantidad)
        WHERE mepr_mesa_id = @mesaId
        AND mepr_prod_id = @prodId;
    END
    ELSE
    BEGIN
        -- Si no existe, inserta un nuevo registro
        INSERT INTO mesa_productos (mepr_mesa_id, mepr_prod_id, mepr_precio, mepr_cantidad)
        VALUES (@mesaId, @prodId, @nuevoPrecio * @nuevaCantidad, @nuevaCantidad);
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_cargar_mesas]    Script Date: 05/12/2023 19:03:25 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_cargar_productos]    Script Date: 05/12/2023 19:03:25 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_eliminar_mesa_producto]    Script Date: 05/12/2023 19:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminar_mesa_producto]
    @id INT
AS
BEGIN
    IF EXISTS (SELECT * FROM mesa_productos WHERE mepr_id = @id)
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
/****** Object:  StoredProcedure [dbo].[sp_eliminar_mesas]    Script Date: 05/12/2023 19:03:25 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_eliminar_productos]    Script Date: 05/12/2023 19:03:25 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_insertar_mesa_prod]    Script Date: 05/12/2023 19:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_insertar_mesa_prod](
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
/****** Object:  StoredProcedure [dbo].[sp_modificar_mesas]    Script Date: 05/12/2023 19:03:25 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_modificar_productos]    Script Date: 05/12/2023 19:03:25 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_obtener_mesa_producto]    Script Date: 05/12/2023 19:03:25 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_obtener_mesas]    Script Date: 05/12/2023 19:03:25 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_obtener_productos]    Script Date: 05/12/2023 19:03:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_Validar_Usuario]    Script Date: 05/12/2023 19:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Validar_Usuario](
@user varchar (255),
@password varchar (255)
)
as 
begin
select usua_id from usuario where usua_nombre=@user and usua_password=@password
end
GO
