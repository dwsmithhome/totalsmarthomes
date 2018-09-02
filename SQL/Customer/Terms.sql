SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Customer].[Terms](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[TermsAgreed] [bit] NOT NULL,
	[TermsAgreedDateTime] [datetime] NOT NULL
) ON [PRIMARY]
GO
