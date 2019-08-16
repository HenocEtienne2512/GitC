update AulaCsharp
set idade = '38' 
where Id = 2;
go
select * from AulaCsharp;

/*
insert into AulaCsharp
(Aluno,Idade,ativo,UsuInc,UsuAlt,DatInc,DatAlt)
values
('Christanie','62','1','006','006',GETDATE(),GETDATE());

insert into AulaCsharp
(Aluno,Idade,ativo,UsuInc,UsuAlt,DatInc,DatAlt)
values
('Jn Baptiste','30','1','007','007',GETDATE(),GETDATE());

insert into AulaCsharp
(Aluno,Idade,ativo,UsuInc,UsuAlt,DatInc,DatAlt)
values
('Patrice','70','1','003','003',GETDATE(),GETDATE());

insert into AulaCsharp
(Aluno,Idade,ativo,UsuInc,UsuAlt,DatInc,DatAlt)
values
('Stephania','32','1','004','004',GETDATE(),GETDATE());

insert into AulaCsharp
(Aluno,Idade,ativo,UsuInc,UsuAlt,DatInc,DatAlt)
values
('Martine','24','1','009','009',GETDATE(),GETDATE());
*/