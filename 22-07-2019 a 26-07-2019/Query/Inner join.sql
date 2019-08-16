
select 
	LV.Id,
	LV.Nome,
	IIF(LV.Alocado = 1, 'Sim', 'Não') as 'Alocado',
	BL.Nome as 'Nome da Biblioteca'
	from Biblioteca BL
		inner join Livros LV on BL.Id = LV.Biblioteca;

/*
select
	BL.Nome,
	count(LV.Id) as 'QantidadeLivros',
	US.Nome as 'UserName'
from Biblioteca BL
		inner join Livros LV on BL.Id = LV.Biblioteca
		inner join Usuario US on LV.UsuaInc = US.Id
		group by BL.Nome,US.Nome;
*/


