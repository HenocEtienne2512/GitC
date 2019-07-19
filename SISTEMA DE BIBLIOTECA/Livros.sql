CREATE TABLE [dbo].[Livros]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Titulo] VARCHAR(1200) NOT NULL, 
    [Registro] INT NOT NULL, 
    [Autor] VARCHAR(200) NOT NULL, 
    [Isbn] VARCHAR(15) NOT NULL, 
    [Genero] INT NOT NULL, 
    [Editora] INT NOT NULL, 
    [Sinopse] NVARCHAR(MAX) NULL, 
    [Observacoes] VARCHAR(1000) NULL, 
    [Ativo] BIT NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL, 
    [DatAlt] DATETIME NOT NULL, 
    CONSTRAINT [FK_Livros_Generos] 
	FOREIGN KEY ([Genero]) 
	REFERENCES [Generos]([Id]),
	
    CONSTRAINT [FK_Livros_Editora] 
	FOREIGN KEY ([Editora]) 
	REFERENCES [Editoras]([Id]),
	
    CONSTRAINT [FK_Livros_UsuarioInc] 
	FOREIGN KEY ([UsuInc]) 
	REFERENCES [Usuarios]([Id]),

    CONSTRAINT [FK_Livros_UsuarioAlt] 
	FOREIGN KEY ([UsuAlt]) 
	REFERENCES [Usuarios]([Id])
)
