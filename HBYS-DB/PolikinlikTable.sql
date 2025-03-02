USE [HBYS]
GO

/****** Object:  Table [dbo].[Polikinlik]    Script Date: 23.07.2024 11:19:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Polikinlik](
	[polikinlik_id] [int] IDENTITY(1,1) NOT NULL,
	[polikinlik_ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Polikinlik] PRIMARY KEY CLUSTERED 
(
	[polikinlik_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

