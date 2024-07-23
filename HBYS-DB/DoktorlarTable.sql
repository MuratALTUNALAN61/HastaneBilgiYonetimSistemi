USE [HBYS]
GO

/****** Object:  Table [dbo].[Doktorlar]    Script Date: 23.07.2024 11:17:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Doktorlar](
	[p_id] [int] NOT NULL,
	[doktor_id] [int] IDENTITY(1,1) NOT NULL,
	[polikinlik_id] [int] NOT NULL,
	[doktor_ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Doktorlar] PRIMARY KEY CLUSTERED 
(
	[doktor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Doktorlar]  WITH CHECK ADD  CONSTRAINT [FK_Doktorlar_Personel] FOREIGN KEY([p_id])
REFERENCES [dbo].[Personel] ([p_id])
GO

ALTER TABLE [dbo].[Doktorlar] CHECK CONSTRAINT [FK_Doktorlar_Personel]
GO

ALTER TABLE [dbo].[Doktorlar]  WITH CHECK ADD  CONSTRAINT [FK_Doktorlar_Polikinlik] FOREIGN KEY([polikinlik_id])
REFERENCES [dbo].[Polikinlik] ([polikinlik_id])
GO

ALTER TABLE [dbo].[Doktorlar] CHECK CONSTRAINT [FK_Doktorlar_Polikinlik]
GO

