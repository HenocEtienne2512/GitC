/*
Trazer somente as marcas que Felipe cadastrou
Trazer somente as marcas que Giomar cadastrou
*/
select 
	Ma.Nome as 'Marcas/Felipe'
	from Marcas Ma
	where Ma.UsuInc = 1;

select 
	Ma.Nome as 'Marcas/Giomar'
	from Marcas Ma
	where Ma.UsuInc = 2;


/*
Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
*/

select
	count(Ma.Nome) as 'Qtd Felipe'
	from Marcas Ma
	where Ma.UsuInc = 1
	order by 1 desc;

select
	count(Ma.Nome) as 'Qtd Giomar'
	from Marcas Ma
	where Ma.UsuInc = 2
	order by 1 asc;


select
	Usu.Usuario as 'Nome',
	count(Ma.Nome) as 'Quantidade'
	from Marcas Ma
	inner join Usuarios Usu on Ma.UsuInc = Usu.Id
	group by Usu.Usuario

/*
Trazer somente os carros que Felipe cadastrou
Trazer somente os carros que Giomar cadastrou
*/

select 
	Ca.Modelo as 'Carros/Felipe'
	from Carros Ca
	where Ca.UsuInc = 1;


select 
	Ca.Modelo as 'Carros/Giomar'
	from Carros Ca
	where Ca.UsuInc = 2;

/*
Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
*/

select 
	count(Ca.Modelo) as 'Qtd Carros/Felipe'
	from Carros Ca
	where Ca.UsuInc = 1
	order by 1 desc;

select 
	count(Ca.Modelo) as 'Qtd Carros/Giomar'
	from Carros Ca
	where Ca.UsuInc = 2
	order by 1 asc;

/*
Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
*/

select
	Usu.Usuario as 'Nome',
	count(Ca.Modelo) as 'Quantidade'
	from Carros Ca
	inner join Usuarios Usu on Ca.UsuInc = Usu.Id
	group by Usu.Usuario;

/*
Trazer somente os carros das marcas que Felipe cadastrou
Trazer somente os carros das marcas que Giomar cadastrou
*/

select
	Ca.Modelo as 'Carros/Felipe',
	Ma.Nome as 'Marcas',
	Usu.Usuario
	from Marcas Ma
	inner join Carros Ca on Ca.Marca = Ma.Id
	inner join Usuarios Usu on Ma.UsuInc = Usu.Id
	where Usu.Id = 1
	order by 1 desc;

select
	Ca.Modelo as 'Carros/Giomar',
	Ma.Nome as 'Marcas',
	Usu.Usuario
	from Marcas Ma
	inner join Carros Ca on Ca.Marca = Ma.Id
	inner join Usuarios Usu on Ma.UsuInc = Usu.Id
	where Usu.Id = 2
	order by 1 asc;

/*
Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
*/
select
	Usu.Usuario as'Nome Usuário',
	Ma.Nome, --as 'Marcas',
	Count(Ca.Modelo) as 'Quantidade'
	from Marcas Ma
	--where Ca.UsuInc = 1
	inner join Carros Ca on Ca.Marca = Ma.Id
	inner join Usuarios Usu on Ma.UsuInc = Usu.Id
	where Usu.Id = 1
	group by Usu.Usuario, Ma.Nome
	order by 2 desc;

select
	Usu.Usuario as'Nome Usuário',
	Ma.Nome, --as 'Marcas',
	Count(Ca.Modelo) as 'Quantidade'
	from Marcas Ma
	--where Ca.UsuInc = 1
	inner join Carros Ca on Ca.Marca = Ma.Id
	inner join Usuarios Usu on Ma.UsuInc = Usu.Id
	where Usu.Id = 2
	group by Usu.Usuario, Ma.Nome
	order by 2 asc;

/*
Trazer o valor total de vendas 2019 isolado
Trazer a quantidade total de vendas 2019 isolado
*/
select 
	sum(V.Valor) as 'Valor Total'
	from Vendas V
	where year(V.DatInc) = 2019

select 
	sum(V.Quantidade) as 'Qtd Vendas'
	from Vendas V
	where year(V.DatInc) = 2019
/*
Trazer o valor total de vendas em cada ano e ordernar do maior para o menor
Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor
*/
select 
	sum(V.Valor) as 'Valor Total',
	year(V.DatInc) as 'Ano'

	from Vendas V
group by year(V.DatInc)
order by 1 desc;

select 
	sum(V.Quantidade) as 'Qtd vendas',
	year(V.DatInc) as 'Ano'

	from Vendas V
group by year(V.DatInc)
order by 1 asc;

/*
Trazer o mês de cada ano que retornou a maior quantidade de vendas
		- Tradução "Retornar agrupado por mês e ordernar do maior para menor"
		
Trazer o mês de cada ano que retornou o maior valor de vendas
		- Tradução "Retornar agrupado por mês e ordernar do maior para menor"
*/

select 
	sum(V.Quantidade) as 'Qtd vendas',
	Month(V.DatInc) as 'Mês',
	year(V.DatInc) as 'Ano'

	from Vendas V
group by Month(V.DatInc),year(V.DatInc)
order by 1 desc;

select 
	sum(V.Valor) as 'Valor Total',
	Month(V.DatInc) as 'Mês',
	year(V.DatInc) as 'Ano'

	from Vendas V
group by Month(V.DatInc),year(V.DatInc)
order by 1 desc;

/*
Trazer o valor total de vendas que Felipe realizou
Trazer o valor total de vendas que Giomar realizou
*/
select 
	sum(V.Valor) as 'Valor Total/Felipe'
	from Vendas V
	where v.UsuInc = 1;

select 
	sum(V.Valor) as 'Valor Total/Giomar'
	from Vendas V
	where v.UsuInc = 2;

/*
Trazer a quantidade total de vendas que Felipe realizou
Trazer a quantidade de vendas que Giomar realizou
*/
select 
	sum(V.Quantidade) as 'Qtd vendas/Felipe'
	from Vendas V
	where v.UsuInc = 1;

select 
	sum(V.Quantidade) as 'Qtd vendas/Giomar'
	from Vendas V
	where v.UsuInc = 2;

/*
Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
*/
select 
	Usu.Usuario as 'Nome Usuàrio',
	sum(V.Quantidade) as 'Quantidade'
	from Vendas V
	inner join Usuarios Usu on V.UsuInc = Usu.Id
	group by Usu.Usuario
	order by 2 desc;

select 
	Usu.Usuario as 'Nome Usuàrio',
	sum(V.Valor) as 'Valor Total'
	from Vendas V
	inner join Usuarios Usu on V.UsuInc = Usu.Id
	group by Usu.Usuario
	order by 2 asc;

/*
Trazer  a marca mais vendida de todos os anos
		- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
Trazer o valor total da marca mais vendida de todos os anos	
*/
select 
	Ma.Nome as 'Marca',
	sum(v.Quantidade) as 'Mais vendido'
	from Vendas V
	inner join Carros ca on V.Carro = ca.Id
	inner join Marcas Ma on ca.Marca = Ma.Id
	group by Ma.Nome
	order by 2 desc;

select 
	Ma.Nome as 'Marca',
	sum(V.Valor * v.Quantidade) as 'Mais vendido'
	from Vendas V
	inner join Carros ca on V.Carro = ca.Id
	inner join Marcas Ma on ca.Marca = Ma.Id
	group by Ma.Nome
	order by 2 desc;
/*
Trazer a quantidade do carro mais vendido de todos os anos
Trazer o valor do carro mais vendido de todos os anos
*/
select 
	ca.Modelo as 'Carro',
	sum(v.Quantidade) as 'Mais vendido'
	from Vendas V
	inner join Carros ca on V.Carro = ca.Id
	group by ca.Modelo
	order by 2 desc;

select 
	ca.Modelo as 'Carro',
	sum(V.Valor * v.Quantidade) as 'Mais vendido'
	from Vendas V
	inner join Carros ca on V.Carro = ca.Id
	group by ca.Modelo
	order by 2 desc;

