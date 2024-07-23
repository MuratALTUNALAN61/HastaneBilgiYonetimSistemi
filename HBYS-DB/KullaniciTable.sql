USE [HBYS]
GO

/****** Object:  Table [dbo].[Kullanici]    Script Date: 23.07.2024 11:18:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Kullanici](
	[personel_id] [int] NOT NULL,
	[kullaniciAdi] [nvarchar](20) NOT NULL,
	[sifre] [nvarchar](20) NOT NULL,
	[kullanici_id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[kullanici_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Personel] FOREIGN KEY([personel_id])
REFERENCES [dbo].[Personel] ([p_id])
GO

ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Personel]
GO

