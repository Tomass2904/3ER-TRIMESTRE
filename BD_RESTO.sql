create table productos(
prod_id int identity (1,1) not null primary key,
prod_nombre varchar (255) not null,
prod_precio float not null
)
select * from productos

insert into productos(prod_nombre, prod_precio) values ('Servicio a la mesa',200),('Botella de Agua 500ml',650),('Botella de Gaseosa',800),('Trago sin Alcohol', 1800),('Trago con Alcohol',2300),('Empanadas Unidad',500),('Empanadas 3 Unidades', 1490),('Empanadas 6 Unidades',2890),('Empanadas 12 Unidades', 5600),('Milanesa Simple',3400),('Milanesa con Guarnicion',4100),('Milanesa Napo Simple',4000),('Milanesa Napo con Guarnicion', 4800), ('Milanesa a Caballo', 4500),('Hamburgesa al Plato Simple', 2500),('Sanguche de Hamburgesa Simple',2700),('Sanguche de Hamburgesa LyT',3000),('Sanguche de Hamburgesa JyQ ',3000),('Sanguche de Hamburgesa Completo',3650),('Sanguche de Lomo Simple',3200),('Sanguche de Lomo LyT', 3700),('Sanguche de Lomo JyQ', 3700),('Sanguche de Lomo Completo', 4300),('Bife de Pollo',4000),('Bife de Pollo con Guarnicion',4700),('Tira de Asado',4100), ('Tira de Asado con Guarnicion',4800),('Bife de Chorizo con Guarnicion de 200g',4500),('Bife de Chorizo con Guarnicion de 400g',5000),('Chorizo', 1000), ('Morcilla',1000);