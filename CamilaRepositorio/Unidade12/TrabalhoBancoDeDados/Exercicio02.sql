--2) Escreva um comando SQL que retorne os nomes dos alunos e do(s) cursos em que estão matriculados. Os dados deverão estar ordenados
 --pelo nome do curso. 

 Select A.Nome, C.Curso From TBAluno as A inner join TBCurso as C  on A.TBCurso_Id = C.Id Order By Curso

  Lucas	Arquitetura
Rebeca Poe	Arquitetura
Camila Silva  	Artes
Laura Lime	Biomedicina
Joao	Biomedicina
Lola	Contabilidade
Marcelo Res	Contabilidade
Felipe	Engenharia Civil
Julio Cezar	Informática
Laura Poa	Medicina
Mateus	Medicina

 Select TBMatrícula.TBAluno_Id, TBMatrícula.TBCurso_Id from TBMatrícula order by TBCurso_Id


 1	1
11	1
3	2
6	2
7	3
5	3
9	4
8	5
12	6
10	7
4	7
2	8