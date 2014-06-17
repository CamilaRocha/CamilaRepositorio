 --1) Crie as tabelas em sua base de dados e faça a relação entre elas.


 CREATE TABLE [dbo].[Funcionário] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [PrimeiroNome] VARCHAR (50)    NULL,
    [Sobrenome]    VARCHAR (50)    NULL,
    [Salario]      DECIMAL (11, 2) NULL,
    [Funcao]       VARCHAR (50)    NULL,
    [Departamento_Id] INT NULL, 

    PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Funcionário_DepartamentoId] FOREIGN KEY ([Departamento_Id]) REFERENCES [dbo].[Departamento] ([Id])

	
);




 CREATE TABLE [dbo].[Departamento] (
    [Id]   INT NOT NULL IDENTITY,
    [Nome] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);