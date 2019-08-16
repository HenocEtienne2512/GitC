select
	ca.Nome,
	count(Lo.DatLoc) as 'Total locado',
	year(Lo.DatLoc) as 'Ano de Alocação'

from Locacao Lo
	inner join Carros ca on Lo.Carro = ca.Id
	group by  ca.Nome, year(Lo.DatLoc)
	order by 2 desc;
--------------------------------------------------------
select
	ca.Nome,
	
	count(Lo.DatLoc) as 'Total locado',
	month(Lo.DatLoc) as 'Mês de Alocação'

from Locacao Lo
	inner join Carros ca on Lo.Carro = ca.Id
	group by  ca.Nome, month(Lo.DatLoc)
	order by month(Lo.DatLoc) desc;

-------------------------------------------------------
select
	ca.Nome,
	count(Lo.DatLoc) as 'Total/Data',
	Lo.DatLoc as 'Alocação'

from Locacao Lo
	inner join Carros ca on Lo.Carro = ca.Id
	group by  ca.Nome, Lo.DatLoc;
	
