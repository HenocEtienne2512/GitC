CREATE TABLE [dbo].[LivrosAutores]
(
    [Livro] INT NOT NULL, 
    [Autor] INT NOT NULL, 
    CONSTRAINT [FK_LivrosAutores_Livros] 
	FOREIGN KEY ([Livro]) 
	REFERENCES [Livros]([Id]),
	
    CONSTRAINT [FK_LivrosAutores_Autores] 
	FOREIGN KEY ([Autor]) 
	REFERENCES [Autores]([Id]), 
   
)
