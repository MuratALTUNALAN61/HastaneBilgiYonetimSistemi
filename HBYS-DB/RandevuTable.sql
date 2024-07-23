USE [HBYS]
GO

/****** Object:  Table [dbo].[Randevu]    Script Date: 23.07.2024 11:19:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Randevu](
	[h_id] [int] NOT NULL,
	[d_id] [int] NOT NULL,
	[randevu_id] [int] IDENTITY(1,1) NOT NULL,
	[tarih] [datetime] NOT NULL,
 CONSTRAINT [PK_Randevu] PRIMARY KEY CLUSTERED 
(
	[randevu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_Doktorlar] FOREIGN KEY([d_id])
REFERENCES [dbo].[Doktorlar] ([doktor_id])
GO

ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_Doktorlar]
GO

ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_Hasta] FOREIGN KEY([h_id])
REFERENCES [dbo].[Hasta] ([h_id])
GO

ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_Hasta]
GO

