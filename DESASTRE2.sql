use sl_base;

create table Departamento(
IdDepartamento int primary key identity(1,1),
Departamento varchar(50) not null
);
create table Municipio(
IdMunicipio int primary key identity(1,1),
Departamento int foreign key references Departamento(IdDepartamento),
Municipio varchar(50) not null
);

ALTER TABLE Usuario add foreign key IdMunicipio references Municipio(IdMunicipio);  
GO  

create table Usuario(
IdUsuario int primary key identity(1,1),
Nombre varchar(50) not null,
Apellido varchar(50) not null,
correo varchar (50) unique not null,
clave varchar (20) not null,
IdMunicipio int foreign key references Departamento(IdDepartamento)
);

create table Etiquetas(
IdEtiqueta int primary key identity(1,1),
NombreEtiqueta varchar (50),
Estado int
);
create table Categoria(
IdCategoria int primary key identity(1,1),
NombreCategoria varchar (50),
Estado int
);
create table SubCategoria(
IdSubCategoria int primary key identity(1,1),
IdCategoria int foreign key references Categoria(IdCategoria),
NombreSubCategoria varchar (50),
Estado int
);
create table Comentarios(
IdComentario int primary key identity(1,1),
IdUsuario int foreign key references Usuario(IdUsuario),
Fecha date not null,
Hora time not null,
Comentario varchar (200) not null,
Municipio int foreign key references Municipio(IdMunicipio),
Etiqueta int foreign key references Etiquetas(IdEtiqueta),
IdCategoria int foreign key references Categoria(IdCategoria)
);
create table EtiquetaComentario(
IdEtiquetaComentario int primary key identity(1,1),
IdComentario int foreign key references Comentarios(IdComentario),
IdCategoria int foreign key references Categoria(IdCategoria),
Estado int
);
create table Preguntas(
IdPreguntas int primary key identity(1,1),
Enunciado varchar (200) not null,
Respuesta varchar ()
IdCategoria int foreign key references SubCategoria(IdSubCategoria),
IdCategoria int foreign key references Categoria(IdCategoria),
Estado int
);

create table OpcionesPreguntas(
);

