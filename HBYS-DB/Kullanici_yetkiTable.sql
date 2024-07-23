USE [HBYS]
GO

/****** Object:  Table [dbo].[Kullanici_yetki]    Script Date: 23.07.2024 11:18:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Kullanici_yetki](
	[y_id] [int] NOT NULL,
	[k_id] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Kullanici_yetki]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_yetki_Kullanici] FOREIGN KEY([k_id])
REFERENCES [dbo].[Kullanici] ([kullanici_id])
GO

ALTER TABLE [dbo].[Kullanici_yetki] CHECK CONSTRAINT [FK_Kullanici_yetki_Kullanici]
GO

ALTER TABLE [dbo].[Kullanici_yetki]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_yetki_Yetki] FOREIGN KEY([y_id])
REFERENCES [dbo].[Yetki] ([yetki_id])
GO

ALTER TABLE [dbo].[Kullanici_yetki] CHECK CONSTRAINT [FK_Kullanici_yetki_Yetki]
GO

