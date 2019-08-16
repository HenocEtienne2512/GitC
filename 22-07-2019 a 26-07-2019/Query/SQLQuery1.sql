select 
	a.Nome,
	sum(b.Nota) / count(*)  as 'Media'
	--b.[Data] as 'Data'
	from Boletim b	
	full join Aluno a on b.Aluno = a.Id
	--where a.Turma  = 1
	group by a.Nome; --, b.Nota--, b.[Data]

	------------------------
	select 
	a.Nome,
	sum(b.Nota) / count(*)  as 'Media'
	--b.[Data] as 'Data'
	from Boletim b	
	full join Aluno a on b.Aluno = a.Id
	--where a.Turma  = 1
	group by a.Nome;
	