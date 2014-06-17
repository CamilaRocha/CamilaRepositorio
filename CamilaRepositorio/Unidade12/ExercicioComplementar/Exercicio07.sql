--7) Liste o nome, o nome do departamento e a função de todos os funcionários ordenado por nome.

--Select F.PrimeiroNome, D.Nome From Funcionário as F inner join Departamento as D on F.Departamento_Id = D.Id

--Camila	Gerente
--Diego	Auxiliar
--Luana	Faxineira
--Bianca	Atendente
--Lucas	Entrevistador

Select F.PrimeiroNome, D.Nome From Funcionário as F full join Departamento as D on F.Departamento_Id = D.Id

Camila	Gerente
Diego	Auxiliar
Luana	Faxineira
Bianca	Atendente
Lucas	Entrevistador
Thiago	NULL