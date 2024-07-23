USE [HBYS]
GO

/****** Object:  Table [dbo].[Muayene]    Script Date: 23.07.2024 11:18:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Muayene](
	[m_id] [int] IDENTITY(1,1) NOT NULL,
	[d_id] [int] NOT NULL,
	[hasta_id] [int] NOT NULL,
	[sikayet] [nvarchar](50) NOT NULL,
	[teshis] [nvarchar](50) NOT NULL,
	[recete] [nvarchar](50) NOT NULL,
	[r_id] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Muayene]  WITH CHECK ADD  CONSTRAINT [FK_Muayene_Doktorlar] FOREIGN KEY([d_id])
REFERENCES [dbo].[Doktorlar] ([doktor_id])
GO

ALTER TABLE [dbo].[Muayene] CHECK CONSTRAINT [FK_Muayene_Doktorlar]
GO

ALTER TABLE [dbo].[Muayene]  WITH CHECK ADD  CONSTRAINT [FK_Muayene_Hasta] FOREIGN KEY([hasta_id])
REFERENCES [dbo].[Hasta] ([h_id])
GO

ALTER TABLE [dbo].[Muayene] CHECK CONSTRAINT [FK_Muayene_Hasta]
GO

ALTER TABLE [dbo].[Muayene]  WITH CHECK ADD  CONSTRAINT [FK_Muayene_Randevu] FOREIGN KEY([r_id])
REFERENCES [dbo].[Randevu] ([randevu_id])
GO

ALTER TABLE [dbo].[Muayene] CHECK CONSTRAINT [FK_Muayene_Randevu]
GO

