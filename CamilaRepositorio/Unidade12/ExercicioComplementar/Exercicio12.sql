--12)  Liste os nomes de funcionários que começam com a letra ‘L’ ordenados pro nome de departamento.

 Select F.PrimeiroNome, D.Nome From Funcionário as F full join Departamento as D on F.Departamento_Id = D.Id WHERE PrimeiroNome LIKE 'L%' Order By PrimeiroNome
 

Luana	Faxineira
Lucas	Entrevistador