﻿CREATE TABLE [dbo].[Generos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Tipo] VARCHAR(100) NOT NULL, 
    [Descricao] VARCHAR(100) NOT NULL
)