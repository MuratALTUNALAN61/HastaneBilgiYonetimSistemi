USE [HBYS]
GO

/****** Object:  Table [dbo].[Hasta]    Script Date: 23.07.2024 11:17:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Hasta](
	[h_id] [int] IDENTITY(1,1) NOT NULL,
	[h_isim] [nvarchar](20) NOT NULL,
	[h_soyisim] [nvarchar](20) NOT NULL,
	[h_tc] [nvarchar](11) NOT NULL,
	[h_dogumTarihi] [date] NOT NULL,
	[h_tel] [nvarchar](30) NOT NULL,
	[h_cinsiyet] [nchar](5) NOT NULL,
 CONSTRAINT [PK_Hasta] PRIMARY KEY CLUSTERED 
(
	[h_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

