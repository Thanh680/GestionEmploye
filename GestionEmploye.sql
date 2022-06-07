USE [GestionEmploye]
GO
/****** Object:  Table [dbo].[Competence]    Script Date: 05/06/2022 15:37:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competence](
	[id] [nchar](10) NOT NULL,
	[libelle] [nchar](100) NULL,
 CONSTRAINT [PK_Competence] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employe]    Script Date: 05/06/2022 15:37:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employe](
	[id] [nchar](10) NOT NULL,
	[nom] [nchar](100) NULL,
	[prenom] [nchar](100) NULL,
	[idProjet] [nchar](10) NULL,
 CONSTRAINT [PK_Employe] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeCompetence]    Script Date: 05/06/2022 15:37:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeCompetence](
	[idEmploye] [nchar](10) NOT NULL,
	[idCompetence] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projet]    Script Date: 05/06/2022 15:37:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projet](
	[id] [nchar](10) NOT NULL,
	[libelle] [nchar](100) NULL,
	[dateDebut] [nchar](20) NULL,
	[dateFin] [nchar](20) NULL,
 CONSTRAINT [PK_Projet] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjetCompetence]    Script Date: 05/06/2022 15:37:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjetCompetence](
	[idProjet] [nchar](10) NULL,
	[idCompetence] [nchar](10) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EmployeCompetence]  WITH CHECK ADD  CONSTRAINT [FK_EmployeCompetence_Competence] FOREIGN KEY([idCompetence])
REFERENCES [dbo].[Competence] ([id])
GO
ALTER TABLE [dbo].[EmployeCompetence] CHECK CONSTRAINT [FK_EmployeCompetence_Competence]
GO
ALTER TABLE [dbo].[EmployeCompetence]  WITH CHECK ADD  CONSTRAINT [FK_EmployeCompetence_Employe] FOREIGN KEY([idEmploye])
REFERENCES [dbo].[Employe] ([id])
GO
ALTER TABLE [dbo].[EmployeCompetence] CHECK CONSTRAINT [FK_EmployeCompetence_Employe]
GO
ALTER TABLE [dbo].[ProjetCompetence]  WITH CHECK ADD  CONSTRAINT [FK_ProjetCompetence_Competence] FOREIGN KEY([idCompetence])
REFERENCES [dbo].[Competence] ([id])
GO
ALTER TABLE [dbo].[ProjetCompetence] CHECK CONSTRAINT [FK_ProjetCompetence_Competence]
GO
ALTER TABLE [dbo].[ProjetCompetence]  WITH CHECK ADD  CONSTRAINT [FK_ProjetCompetence_Projet] FOREIGN KEY([idProjet])
REFERENCES [dbo].[Projet] ([id])
GO
ALTER TABLE [dbo].[ProjetCompetence] CHECK CONSTRAINT [FK_ProjetCompetence_Projet]
GO
