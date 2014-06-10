SET IDENTITY_INSERT [dbo].[Aluno] ON
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Email], [Telefone], [Altura], [Aprovado]) VALUES (2, N'Camila', N'camila@hotmail.com', N'32225419', CAST(1.62 AS Decimal(3, 2)), 1)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Email], [Telefone], [Altura], [Aprovado]) VALUES (3, N'Diego', N'diego@hotmail.com', N'32205419', CAST(1.72 AS Decimal(3, 2)), 0)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Email], [Telefone], [Altura], [Aprovado]) VALUES (4, N'Luana', N'luana@hotmail.com', N'32225400', CAST(1.88 AS Decimal(3, 2)), 0)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Email], [Telefone], [Altura], [Aprovado]) VALUES (5, N'Bianca', N'bianca@hotmail.com', N'32220019', CAST(1.42 AS Decimal(3, 2)), 1)
SET IDENTITY_INSERT [dbo].[Aluno] OFF
