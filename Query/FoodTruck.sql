select
	Tipo,
	TotalVenda,
	SUM(TotalVenda) as 'Media',
	Month(DataVenda) as 'Mês Venda'
from FoodTruck
	group by Tipo, TotalVenda, DataVenda


select * from FoodTruck;