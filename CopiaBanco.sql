USE [ClimaTempoSimples]
GO
SET IDENTITY_INSERT [dbo].[Estado] ON 

INSERT [dbo].[Estado] ([Id], [Nome], [UF]) VALUES (1, N'Rondônia', N'RO')
INSERT [dbo].[Estado] ([Id], [Nome], [UF]) VALUES (2, N'São Paulo', N'SP')
INSERT [dbo].[Estado] ([Id], [Nome], [UF]) VALUES (3, N'Rio Grande do Sul', N'RS')
SET IDENTITY_INSERT [dbo].[Estado] OFF
SET IDENTITY_INSERT [dbo].[Cidade] ON 

INSERT [dbo].[Cidade] ([Id], [Nome], [EstadoId], [Estado_Id]) VALUES (1, N'Porto Alegre', N'3', NULL)
INSERT [dbo].[Cidade] ([Id], [Nome], [EstadoId], [Estado_Id]) VALUES (2, N'Pelotas', N'3', NULL)
INSERT [dbo].[Cidade] ([Id], [Nome], [EstadoId], [Estado_Id]) VALUES (3, N'Porto Velho', N'1', NULL)
INSERT [dbo].[Cidade] ([Id], [Nome], [EstadoId], [Estado_Id]) VALUES (4, N'Gothan', N'1', NULL)
INSERT [dbo].[Cidade] ([Id], [Nome], [EstadoId], [Estado_Id]) VALUES (5, N'Nova York', N'1', NULL)
SET IDENTITY_INSERT [dbo].[Cidade] OFF
SET IDENTITY_INSERT [dbo].[PrevisaoClima] ON 

INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (2, 3, 1, CAST(N'2022-12-24T00:00:00.000' AS DateTime), 33, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (3, 3, 1, CAST(N'2022-12-23T00:00:00.000' AS DateTime), 32, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (4, 3, 1, CAST(N'2022-12-25T00:00:00.000' AS DateTime), 30, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (5, 3, 1, CAST(N'2022-12-22T00:00:00.000' AS DateTime), 40, 25)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (6, 3, 1, CAST(N'2022-12-21T00:00:00.000' AS DateTime), 36, 22)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (7, 3, 1, CAST(N'2022-12-20T00:00:00.000' AS DateTime), 30, 9)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (8, 3, 1, CAST(N'2022-12-19T00:00:00.000' AS DateTime), 30, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (23, 3, 2, CAST(N'2022-12-24T00:00:00.000' AS DateTime), 1, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (24, 3, 2, CAST(N'2022-12-23T00:00:00.000' AS DateTime), 1, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (25, 3, 2, CAST(N'2022-12-25T00:00:00.000' AS DateTime), 97, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (26, 3, 2, CAST(N'2022-12-22T00:00:00.000' AS DateTime), 2, 25)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (27, 3, 2, CAST(N'2022-12-21T00:00:00.000' AS DateTime), 2, 22)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (28, 3, 2, CAST(N'2022-12-20T00:00:00.000' AS DateTime), 30, 10)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (29, 3, 2, CAST(N'2022-12-19T00:00:00.000' AS DateTime), 30, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (30, 3, 3, CAST(N'2022-12-24T00:00:00.000' AS DateTime), 55, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (31, 3, 3, CAST(N'2022-12-23T00:00:00.000' AS DateTime), 55, 3)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (32, 3, 3, CAST(N'2022-12-25T00:00:00.000' AS DateTime), 55, 2)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (33, 3, 3, CAST(N'2022-12-22T00:00:00.000' AS DateTime), 90, 25)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (34, 3, 3, CAST(N'2022-12-21T00:00:00.000' AS DateTime), 90, 22)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (35, 3, 3, CAST(N'2022-12-20T00:00:00.000' AS DateTime), 90, 10)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (36, 3, 3, CAST(N'2022-12-19T00:00:00.000' AS DateTime), 9, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (37, 3, 4, CAST(N'2022-12-24T00:00:00.000' AS DateTime), 90, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (38, 3, 4, CAST(N'2022-12-23T00:00:00.000' AS DateTime), 9, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (39, 3, 4, CAST(N'2022-12-25T00:00:00.000' AS DateTime), 9, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (40, 3, 4, CAST(N'2022-12-22T00:00:00.000' AS DateTime), 9, 25)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (41, 3, 4, CAST(N'2022-12-21T00:00:00.000' AS DateTime), 90, 22)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (42, 3, 4, CAST(N'2022-12-20T00:00:00.000' AS DateTime), 90, 5)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (43, 3, 4, CAST(N'2022-12-19T00:00:00.000' AS DateTime), 98, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (44, 3, 1, CAST(N'2022-12-25T00:00:00.000' AS DateTime), 30, 16)
INSERT [dbo].[PrevisaoClima] ([Id], [Clima], [CidadeId], [DataPrevisao], [TemperaturaMaxima], [TemperaturaMinima]) VALUES (45, 3, 1, CAST(N'2022-12-25T00:00:00.000' AS DateTime), 30, 16)
SET IDENTITY_INSERT [dbo].[PrevisaoClima] OFF
