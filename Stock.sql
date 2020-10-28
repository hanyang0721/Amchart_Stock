USE [Stock]
GO

/****** Object:  Table [dbo].[Price]    Script Date: 10/28/2020 01:35:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Price](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nopen] [int] NULL,
	[nhigh] [int] NULL,
	[nlow] [int] NULL,
	[nclose] [int] NULL,
	[nvol] [int] NULL,
	[Date] [date] NULL
) ON [PRIMARY]
GO


