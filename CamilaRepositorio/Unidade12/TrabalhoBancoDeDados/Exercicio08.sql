--8) Faça um comando SQL que retorne o nome de todas as mulheres matriculadas no curso de Medicina. 

 Select A.Nome, C.Curso From TBAluno as A inner join TBCurso as C  on A.TBCurso_Id = C.Id Where Sexo = 'F' and Curso = 'Medicina'  

 Laura Poa	Medicina
