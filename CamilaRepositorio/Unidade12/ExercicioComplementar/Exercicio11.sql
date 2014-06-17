--11)  Liste os funcionários que têm salário entre R$ 500,00 e 1.500,00 ordenados pelo nome.

SELECT PrimeiroNome, Salario FROM Funcionário WHERE Salario BETWEEN 500.00 AND 1500.00
Order By PrimeiroNome


Bianca	600.00
Camila	500.00
Diego	1000.00
Lucas	905.86
Thiago	560.55