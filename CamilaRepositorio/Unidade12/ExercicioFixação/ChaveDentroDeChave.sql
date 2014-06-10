--Criando Chave , dentro de chave

CREATE TABLE [dbo].[Livro]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Titulo] VARCHAR(50) NULL, 
    [AnoPublicacao] DATE NULL, 
    [Autor_Id] INT NOT NULL,
	FOREIGN KEY (Autor_Id) REFERENCES Autor(Id)



)