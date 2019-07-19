CREATE TABLE [dbo].[Aluno] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Nome]  VARCHAR (50) NOT NULL,
    [Turma] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Alunos_Turma] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Turma] ([Id])
);

