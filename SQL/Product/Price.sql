SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Product].[Price](
	[ProductID] [int] NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[CountryID] [int] NOT NULL
) ON [PRIMARY]
GO
