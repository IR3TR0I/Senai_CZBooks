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
					(2,'brand�o@gmail.com', 'paulo123'),
					(2,'nascimento@gmail.com', 'thiago123'),
					(2,'possarle@gmail.com', 'possarle123'),
					(2,'Tsukamoto@gmail.com', 'tsuka123'),
					(3,'kirilover@gmail.com', 'kirilo123');
Go


Insert into Categoria(NomeCategoria)
Values	('A��o'),		
		('Aventura'),
		('Romance'),
		('Sci-fi'),
		('Terror'),
		('Com�dia'),
		('Drama'),
		('Com�dia Rom�ntica');
Go

Insert Into Livros(IdCategoria,Titulo,Sinopse,Categoria,Autor,Preco,dataPublica��o)
Values			  (4,'Neuromancer','Neuromancer conta a hist�ria de Case, um cowboy do ciberespa�o e hacker da matrix. Como puni��o por tentar enganar os patr�es, seu sistema nervoso foi contaminado por uma toxina que o impede de entrar no mundo virtual.','Sci-Fi','Wiliam Gibson',32.90,'30/05/2012'),
					(5,'Frankenstein','O livro narra a hist�ria do ousado doutor Victor Frankenstein, cientista que se lan�a no experimento de retomar a vida de um ser inanimado. Isso resulta na concep��o de uma criatura sobre-humana e monstruosa que passa a lhe perseguir, tornando-se um arqu�tipo de seu pr�prio criador.','Terror','Mary Shelley',59.99,'28/09/2006'),
					(7,'Hamlet','A pe�a, situada na Dinamarca, reconta a hist�ria de como o Pr�ncipe Hamlet tenta vingar a morte de seu pai, Hamlet, o rei, executado por Cl�udio, seu irm�o, que o envenenou e em seguida tomou o trono casando-se com a rainha.','Drama','Wiliam Shakespeare',69.99,'14/04/1926'),
					(1,'Cidade dos Ossos','Clary Fray, 15 anos, decide passar a noite em uma boate em Nova York. ... Clary testemunha um crime, e n�o um crime qualquer: um assassinato cometido por tr�s adolescentes cobertos por enigm�ticas tatuagens, brandindo armas esquisitas. Para completar, o corpo da v�tima desaparece no ar.','A��o','Cassandra Clare',45.99,'14/03/1987'),
					(2,'Alice no pa�s das Maravilhas','O livro conta a hist�ria de Alice, uma menina curiosa que segue um Coelho Branco de colete e rel�gio, mergulhando sem pensar na sua toca. ... A menina acaba fazendo parte de um julgamento sem sentido e sendo condenada � morte pela Rainha de Copas, tirana que mandava cortar a cabe�a de todos que a incomodavam.','Aventura','Lewis Carrol',29.99,'23/06/1976');
Go

Insert into EMPRESAS(NomeEmpresa,Endere�o)
Values		('Viciados em Livros','Av Get�lio Vargas-456'),
			('ReadLovers','Rua Alem�o-892'),
			('Leitura sem Pensar','Rua Pensamento-234'),
			('Liga da Leitura','Av Bar�o de Limeira-756');
Go