CREATE SCHEMA Resources 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Resources].[Country](
	[CountryID] [int] NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
	[Culture] [nvarchar](5) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [Resources].[Country] ADD PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF) ON [PRIMARY]
GO
