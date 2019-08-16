select
Nome,
materia,
Nota1, Nota2, Nota3, Nota4, Nota5, Nota6,  Nota7,
((Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6 + Nota7)/7) as 'Media',
IIF(((Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6 + Nota7)/7) >= 5, 'Aprovado','Reprovado') as 'Status'
from EscolaCSharp;

select * from EscolaCSharp;
