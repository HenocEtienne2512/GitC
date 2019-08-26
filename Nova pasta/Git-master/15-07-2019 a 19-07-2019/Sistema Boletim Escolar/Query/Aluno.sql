select
	Al.Nome,
	sum(Bo.Nota) / count (Bo.Nota)  as 'Media',

	IIF(sum(Bo.Nota) / count (Bo.Nota) >= 7, 'Aprovado','Reprovado') as 'Status Media',

	count(IIF(Bo.frequencia = 1,1,null)) as 'Frequencia',
	
	IIF(CONVERT(money,count(
		iif(Bo.frequencia = 1,1,null)))/count(Bo.Frequencia)*100 >= 75,'Aprovado','Reprovado') as 'Status Presenca'
	
from Aluno Al
	inner join Boletim Bo on AL.Id = Bo.Aluno
	group by Al.Nome;

	--(count(iif(bo.frequencia=1,1,null))*100)/count(*) as 'presenca'
	--count(iif(bo.frequencia=0,1,null)) as 'presenca'

	