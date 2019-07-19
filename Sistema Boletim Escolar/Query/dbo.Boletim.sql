CREATE TABLE [dbo].[Boletim] (
    [Id]         INT  IDENTITY (1, 1) NOT NULL,
    [Nota]       INT  NULL,
    [Frequencia] BIT  NULL,
    [Data]       DATE NOT NULL,
    [Aluno]      INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Boletim_Aluno] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Aluno] ([Id])
);

