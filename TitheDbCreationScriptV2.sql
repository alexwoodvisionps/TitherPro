USE [TitheDB]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/15/2012 12:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tither]    Script Date: 12/15/2012 12:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tither](
	[TitherId] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MiddleName] [varchar](100) NULL,
	[DateJoined] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TitherId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TitheLogs]    Script Date: 12/15/2012 12:26:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TitheLogs](
	[TitheLogId] [bigint] IDENTITY(1,1) NOT NULL,
	[TitheDate] [datetime] NOT NULL,
	[DateEntered] [datetime] NOT NULL,
	[TitheAmount] [decimal](7, 2) NOT NULL,
	[TitherId] [int] NULL,
	[TitheType] [varchar](100) NOT NULL,
	[PaymentType] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TitheLogId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__Users__IsAdmin__0DAF0CB0]    Script Date: 12/15/2012 12:26:37 ******/
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [IsAdmin]
GO
/****** Object:  Default [DF__Users__Active__0EA330E9]    Script Date: 12/15/2012 12:26:37 ******/
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((1)) FOR [Active]
GO
/****** Object:  ForeignKey [FK__TitheLogs__Tithe__08EA5793]    Script Date: 12/15/2012 12:26:37 ******/
ALTER TABLE [dbo].[TitheLogs]  WITH CHECK ADD FOREIGN KEY([TitherId])
REFERENCES [dbo].[Tither] ([TitherId])
GO

INSERT INTO Users(Username, [Password], IsAdmin, Active)
Values('admin', 'poiuytrewq1234', 1,1)
GO