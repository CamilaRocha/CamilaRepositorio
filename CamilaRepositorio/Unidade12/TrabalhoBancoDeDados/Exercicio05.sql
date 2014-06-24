--5) Escreva um comando SQL para listar o total de alunos matriculados em cada curso.

Select COUNT(*) AS QuantAluno, C.Curso From  TBAluno AS A 
inner join TBMatrícula AS M on M.Id = A.Id
inner join TBCurso AS C on C.Id = M.TBCurso_Id Group By C.Curso


2	Arquitetura
1	Artes
1	Biomedicina
1	Contabilidade
1	Direito
1	Engenharia Civil
1	Informática
2	Medicina
