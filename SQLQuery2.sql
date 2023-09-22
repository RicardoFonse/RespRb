/****** Script do comando SelectTopNRows de SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
  FROM [SenaiAlimentos].[dbo].[Nivel]

  truncate table externo;
