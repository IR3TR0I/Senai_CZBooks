--DML

USE CZ_Books;
Go

insert into TiposUsuario(TituloTipoUsuario)
Values		('Adminstrador'),
			('Autor'),
			('Cliente');
Go



Insert Into Usuarios(IdTipoUsuario,Email,SENHA)
Values				(1,'adm@adm123.com', 'adm123'),
					(2,'Saulover@gmail.com', 'saulo123'),
					(2,'brandão@gmail.com', 'paulo123'),
					(2,'nascimento@gmail.com', 'thiago123'),
					(2,'possarle@gmail.com', 'possarle123'),
					(2,'Tsukamoto@gmail.com', 'tsuka123'),
					(3,'kirilover@gmail.com', 'kirilo123');
Go


Insert into Categoria(NomeCategoria)
Values	('Ação'),		
		('Aventura'),
		('Romance'),
		('Sci-fi'),
		('Terror'),
		('Comédia'),
		('Drama'),
		('Comédia Romântica');
Go


Insert into Autor(IdUsuario)
Values		(1),
			(2),
			(3),
			(4),
			(5),
			(6);
Go


Insert into EMPRESAS(NomeEmpresa,Endereço)
Values		('Viciados em Livros','Av Getúlio Vargas-456'),
			('ReadLovers','Rua Alemão-892'),
			('Leitura sem Pensar','Rua Pensamento-234'),
			('Liga da Leitura','Av Barão de Limeira-756');
Go

INSERT INTO Livros(idAutor,IdCategoria,Titulo,Sinopse,Autor,dataPublicação,Preco)
VALUES				 (5,2,'Os Misterios dos codigos','Um livro que o ajuda a fazer codigos melhor','Wiliam Gibson','31/05/2020',20.50),
					 (2,4,'A aventura em IA','O livro que fala sobre as aventuras de um pequeno robo','Bill Gates','05/03/2019',20.50),
					 (3,5,'Os Gritos Mudos','Um pesquisador decidiu se mudar para uma cidade completamente esquecida','Mary Shelley','20/06/2021',50.75),
					 (6,7,'Pintas Malditas','Como será que é acordar com um homem ruivo com cara de assasino e forçando você a ouvir a historia dele? descubra lendo','Cassandra Clare','12/07/2021',80),
					 (1,3,'Amores sucumbidos','a meu amor, por que você se foi tão cedo será que se foi mesmo','Lewis Carrol','17/03/2021',20.50),
					 (4,8,'Doces Saudades','Um Jovem Casal termina seu relacionamento mas as lembranças ficam','Wiliam Shakespeare','05/04/2003',19.80);
Go
