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

Insert Into Livros(IdCategoria,Titulo,Sinopse,Categoria,Autor,Preco,dataPublicação)
Values			  (4,'Neuromancer','Neuromancer conta a história de Case, um cowboy do ciberespaço e hacker da matrix. Como punição por tentar enganar os patrões, seu sistema nervoso foi contaminado por uma toxina que o impede de entrar no mundo virtual.','Sci-Fi','Wiliam Gibson',32.90,'30/05/2012'),
					(5,'Frankenstein','O livro narra a história do ousado doutor Victor Frankenstein, cientista que se lança no experimento de retomar a vida de um ser inanimado. Isso resulta na concepção de uma criatura sobre-humana e monstruosa que passa a lhe perseguir, tornando-se um arquétipo de seu próprio criador.','Terror','Mary Shelley',59.99,'28/09/2006'),
					(7,'Hamlet','A peça, situada na Dinamarca, reconta a história de como o Príncipe Hamlet tenta vingar a morte de seu pai, Hamlet, o rei, executado por Cláudio, seu irmão, que o envenenou e em seguida tomou o trono casando-se com a rainha.','Drama','Wiliam Shakespeare',69.99,'14/04/1926'),
					(1,'Cidade dos Ossos','Clary Fray, 15 anos, decide passar a noite em uma boate em Nova York. ... Clary testemunha um crime, e não um crime qualquer: um assassinato cometido por três adolescentes cobertos por enigmáticas tatuagens, brandindo armas esquisitas. Para completar, o corpo da vítima desaparece no ar.','Ação','Cassandra Clare',45.99,'14/03/1987'),
					(2,'Alice no país das Maravilhas','O livro conta a história de Alice, uma menina curiosa que segue um Coelho Branco de colete e relógio, mergulhando sem pensar na sua toca. ... A menina acaba fazendo parte de um julgamento sem sentido e sendo condenada à morte pela Rainha de Copas, tirana que mandava cortar a cabeça de todos que a incomodavam.','Aventura','Lewis Carrol',29.99,'23/06/1976');
Go

Insert into EMPRESAS(NomeEmpresa,Endereço)
Values		('Viciados em Livros','Av Getúlio Vargas-456'),
			('ReadLovers','Rua Alemão-892'),
			('Leitura sem Pensar','Rua Pensamento-234'),
			('Liga da Leitura','Av Barão de Limeira-756');
Go