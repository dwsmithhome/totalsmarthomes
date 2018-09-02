SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Purchase].[InvoiceAddress](
	[OrderID] [int] NOT NULL,
	[Address1] [nvarchar](255) NOT NULL,
	[Address2] [nvarchar](255) NOT NULL,
	[Address3] [nvarchar](255) NOT NULL,
	[Address4] [nvarchar](255) NOT NULL,
	[Address5] [nvarchar](255) NOT NULL,
	[Postcode] [nvarchar](10) NOT NULL
) ON [PRIMARY]
GO
