
select
	Tipo,

	(SUM(TotalVenda) / count(*)) as 'Media',
	Month(DataVenda) as 'Mês Venda'
from FoodTruck
	where Month(DataVenda) between 6 and 7
	group by Tipo, Month(DataVenda)
	order by 'Media'desc;


select * from FoodTruck
order by Tipo;