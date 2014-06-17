--8) Liste o valor da folha de pagamento de cada departamento.

Select F.Salario, D.Nome From Funcionário as F full join Departamento as D on F.Departamento_Id = D.Id

500.00	Gerente
1000.00	Auxiliar
356.50	Faxineira
600.00	Atendente
905.86	Entrevistador
560.55	NULL