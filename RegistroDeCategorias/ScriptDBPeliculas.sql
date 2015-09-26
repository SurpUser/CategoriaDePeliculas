create database Pelicula;

use Pelicula;

create table Categorias(
CategoriaId int identity(1,1) primary key not null,
Descripcion varchar(100)
);


select * from Categorias;

Select MAX(CategoriaId)+1 as Id from Categorias;

update Categorias set Descripcion='esta es una pelicula de terror extremo' where CategoriaId = 2;