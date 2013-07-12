/****** Object:  Table [dbo].[Division]    Script Date: 07/12/2013 13:43:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Division](
	[Guid] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Division] PRIMARY KEY CLUSTERED 
(
	[Guid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Division] ADD  CONSTRAINT [DF_Division_Guid]  DEFAULT (newid()) FOR [Guid]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 07/12/2013 13:43:37 ******/

CREATE TABLE [dbo].[Product](
	[Guid] [uniqueidentifier] NOT NULL,
	[DivisionGuid] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Guid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Division] FOREIGN KEY([DivisionGuid])
REFERENCES [dbo].[Division] ([Guid])
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Division]
GO

ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_Guid]  DEFAULT (newid()) FOR [Guid]
GO

