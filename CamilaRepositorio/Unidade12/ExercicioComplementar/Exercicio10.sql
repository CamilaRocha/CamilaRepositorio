--10)  Liste os departamentos dos funcionários que têm a função de funcionário

Select F.Funcao, D.Nome From Funcionário as F full join Departamento as D on F.Departamento_Id = D.Id


Gerente	Gerente
Funcionario	Auxiliar
Funcionaria	Faxineira
Funcionaria	Atendente
Funcionario	Entrevistador
Funcionario	NULL