SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Purchase].[OrderItems](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[Price] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO
