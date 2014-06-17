--18) Liste o nome do departamento e do funcionário ordenados por departamento e funcionário.

Select F.PrimeiroNome, D.Nome From Funcionário as F full join Departamento as D on F.Departamento_Id = D.Id Order By PrimeiroNome

Select F.PrimeiroNome, D.Nome From Funcionário as F full join Departamento as D on F.Departamento_Id = D.Id Order By Nome