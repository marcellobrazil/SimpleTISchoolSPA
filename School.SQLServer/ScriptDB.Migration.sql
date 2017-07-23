CREATE DATABASE TISchool
GO

USE [TISchool]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
    [Login] NVARCHAR(50) NOT NULL, 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NOT NULL,
 CONSTRAINT [Pk_User] PRIMARY KEY CLUSTERED  
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Course]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
    [Name] NVARCHAR(255) NOT NULL, 
    [Description] VARCHAR(Max) NULL,
 CONSTRAINT [Pk_Course] PRIMARY KEY CLUSTERED  
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE PROCEDURE dbo.p_school_user_getbylogin @login varchar(50)
AS
BEGIN

SELECT [Id]
      ,[Login]
      ,[FirstName]
      ,[LastName]
      ,[Password]
  FROM [dbo].[User]
  WHERE [Login] = @login

END
GO

CREATE PROCEDURE dbo.p_school_course_list
AS
BEGIN

	SELECT [Id]
		  ,[Name]
		  ,[Description]
	  FROM [dbo].[Course]

END
GO

INSERT INTO [dbo].[User] ([Login],[FirstName],[LastName],[Password]) VALUES ('Admin','Administrador','do Sistema','1234')
GO

INSERT INTO [dbo].[Course] ([Name],[Description]) VALUES ('Microsoft - Aprendendo a programar', 'Uma introdução ao desenvolvimento de aplicativos e de linguagens de programação')
GO
INSERT INTO [dbo].[Course] ([Name],[Description]) VALUES ('Microsoft - Conceitos básicos desenvolvimento de software', 'Este curso do MVA fornece uma visão geral dos conceitos que os alunos devem entender ao fazer o exame 98-361: Conceitos básicos do desenvolvimento de software. O conteúdo é de nível introdutório e ajuda os alunos entenderem os vários aspectos do desenvolvimento de software. O curso foca nos principais conceitos fundamentais que todos os desenvolvedores de software precisam saber.')
GO
INSERT INTO [dbo].[Course] ([Name],[Description]) VALUES ('Microsoft - Fundamentos da Linguagem C#', 'Curso sobre fundamentos da linguagem C# com foco nos padrões de código limpo.')
GO
INSERT INTO [dbo].[Course] ([Name],[Description]) VALUES ('Gestão de Riscos em TI', 'Gestão de Riscos em TI')
GO
INSERT INTO [dbo].[Course] ([Name],[Description]) VALUES ('Totvs - Gestão Empresarial com ERP', 'Através de oito módulos o participante vai conhecer os principais conceitos da gestão empresarial com ERP, otimizando suas decisões, melhorando sua gestão e assim alcançara os resultados desejados: econômicos e financeiros.')
GO
INSERT INTO [dbo].[Course] ([Name],[Description]) VALUES ('(Cobol) Elementos de Projetos de Informática', 'Neste curso, você aprenderá os conceitos fundamentais sobre o processo de desenvolvimento de projetos de informática. Será possível conhecer as fases do processo de desenvolvimento e as melhores práticas que possibilitam: identificar e analisar um problema, modelar a solução deste problema e, também, como gerenciar todas as fases deste processo durante a sua evolução.')
GO
INSERT INTO [dbo].[Course] ([Name],[Description]) VALUES ('(Java) Elementos de Programação', 'Neste curso, você será submetido a um novo desafio: obter os conhecimentos mais atuais para o desenvolvimento de sistemas e principalmente ampliar o grande número de informações para um bom desempenho como programador.')
GO
INSERT INTO [dbo].[Course] ([Name],[Description]) VALUES ('Arquitetura de Computadores', 'Neste curso, você conhecerá o funcionamento dos computadores, principalmente a parte física conhecida como “hardware” ou “arquitetura de computadores”, determinante na qualidade e no desempenho da máquina.')
GO

