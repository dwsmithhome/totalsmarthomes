CREATE SCHEMA Customer
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Customer].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Forename] [nvarchar](255) NOT NULL,
	[Surname] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [Customer].[Customer] ADD PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY]
GO