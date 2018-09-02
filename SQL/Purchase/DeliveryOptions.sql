SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Purchase].[DeliveryOptions](
	[DeliveryOptionID] [int] NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[DeliveryPeriod] [int] NOT NULL,
	[CountryID] [int] NOT NULL
) ON [PRIMARY]
GO
