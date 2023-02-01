create database tarea2

use tarea2

create table alumnos(
Clave varchar(25) primary key not null,
Nombre varchar(25) not null,
Apellido varchar(26) not null,
Grado varchar(25) not null,
Seccion varchar(25) not null,
Fecha varchar(25) not null
)

insert into alumnos values(1,'pablo','giron','quinto','A','13-04-21')

select * from alumnos 