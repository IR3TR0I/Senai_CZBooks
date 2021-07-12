--DDL

Create Database CZ_Books
Go

USE CZ_Books;
go



Create Table TiposUsuario (

	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	TituloTipoUsuario VARCHAR(200) UNIQUE NOT Null,
);
Go

Create Table Usuarios (
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdTipoUsuario INT FOREIGN KEY REFERENCES TiposUsuario(IdTipoUsuario),
	Email VARCHAR(200) UNIQUE NOT NULL,
	SENHA VARCHAR(20) NOT NULL,
);
Go

Create Table EMPRESAS (
	IdEmpresas INT PRIMARY KEY IDENTITY,
	NomeEmpresa VARCHAR(150) UNIQUE NOT NULL,
	Endereço VARCHAR(160) NOT NULL,
);
Go

Create Table Categoria (
	IdCategoria INT PRIMARY KEY IDENTITY,
	NomeCategoria VARCHAR(20) NOT NULL
);
Go

Create Table Livros (
	IdLivros INT PRIMARY KEY IDENTITY,
	IdCategoria Int FOREIGN KEY REFERENCES Categoria(IdCategoria),
	Titulo VARCHAR(100) UNIQUE NOT NULL,
	Sinopse VARCHAR(200) NOT NULL,
	Categoria VARCHAR(10) NOT NULL,
	Autor VARCHAR(30) NOT NULL,
	Preco Float,
	dataPublicação Date,
);
Go

Create Table Autor (
	IdAutor INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuarios(IdUsuario),
);
Go