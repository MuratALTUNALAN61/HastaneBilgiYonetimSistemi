USE [HBYS]
GO

/****** Object:  Table [dbo].[Personel]    Script Date: 23.07.2024 11:19:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Personel](
	[p_id] [int] IDENTITY(1,1) NOT NULL,
	[p_isim] [nvarchar](20) NOT NULL,
	[p_soyisim] [nvarchar](20) NOT NULL,
	[p_tc] [nvarchar](11) NOT NULL,
	[p_dogumTarihi] [date] NOT NULL,
	[p_tel] [nvarchar](11) NOT NULL,
	[p_cinsiyet] [nchar](5) NOT NULL,
	[p_adres] [nvarchar](50) NOT NULL,
	[p_mail] [nvarchar](50) NOT NULL,
	[p_gorevi] [nvarchar](20) NOT NULL,
	[p_durumu] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[p_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Personel] ADD  CONSTRAINT [DF_Personel_p_durumu]  DEFAULT ('çalışıyor') FOR [p_durumu]
GO

