create table items(
_id int identity (1,1) not null primary key,
bebi_nombre varchar (255) not null,
bebi_precio float not null,
bebi_numero int not null
)




create table productos(
prod_id int identity (1,1) not null primary key,
prod_nombre varchar (255) not null,
prod_precio float not null,
prod_numero int not null
)
select * from productos

delete from productos
create table mesa_prodcutos(
mepr_id int identity (1,1) not null primary key,
mepr_mesa_id int not null,
mepr_prod_id int not null,
mepr_precio float not null,
mepr_cantidad int not null
)
create procedure sp_insertar_mesa_prod(
@mesa_id int,
@prod_id int,
@precio float,
@cantidad int
)
as
begin
insert into mesa_prodcutos (mepr_mesa_id, mepr_prod_id,mepr_precio,mepr_cantidad) values (@mesa_id,@prod_id,@precio,@cantidad);
end

create procedure sp_obtener_mesa_prod
as
begin
select * from mesa_prodcutos
end
insert into productos(prod_nombre, prod_precio, prod_numero) values ('Servicio a la mesa',200,1),('Botella de Agua 500ml',650,2),('Botella de Gaseosa',800,3),('Trago sin Alcohol', 1800,4),('Trago con Alcohol',2300,5),('Empanadas Unidad',500,6),('Empanadas 3 Unidades', 1497,7),('Empanadas 6 Unidades',2890,8),('Empanadas 12 Unidades', 5600,9),('Milanesa Simple',3400,10),('Milanesa con Guarnicion',4100,11),('Milanesa Napo Simple',4000,12),('Milanesa Napo con Guarnicion', 4800,13), ('Milanesa a Caballo', 4500,14),('Hamburgesa al Plato Simple', 2500,15),('Sanguche de Hamburgesa Simple',2700,16),('Sanguche de Hamburgesa LyT',3000,17),('Sanguche de Hamburgesa JyQ ',3000,18),('Sanguche de Hamburgesa Completo',3650,19),('Sanguche de Lomo Simple',3200,20),('Sanguche de Lomo LyT', 3700,21),('Sanguche de Lomo JyQ', 3700,22),('Sanguche de Lomo Completo', 4300,23),('Bife de Pollo',4000,24),('Bife de Pollo con Guarnicion',4700,25),('Tira de Asado',4100,26), ('Tira de Asado con Guarnicion',4800,27),('Bife de Chorizo con Guarnicion de 200g',4500,28),('Bife de Chorizo con Guarnicion de 400g',5000,29),('Chorizo', 1000,31), ('Morcilla',1000,32);