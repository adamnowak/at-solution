USE [at-solution]
GO
/****** Object:  Table [dbo].[Sections]    Script Date: 09/20/2012 21:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sections](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Parent_Id] [int] NULL,
	[Name] [nvarchar](100) NULL,
	[Position] [int] NULL,
	[CreateTime] [datetime] NULL,
	[DeleteTime] [datetime] NULL,
 CONSTRAINT [PK_Sections] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 09/20/2012 21:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[CreateTime] [datetime] NULL,
	[DeleteTime] [datetime] NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09/20/2012 21:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nick] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL,
	[Surname] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Password] [nvarchar](120) NULL,
	[PasswordSalz] [nvarchar](120) NULL,
	[Phone] [nvarchar](50) NULL,
	[CreateTime] [datetime] NULL,
	[DeleteTime] [datetime] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInRoles]    Script Date: 09/20/2012 21:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInRoles](
	[User_Id] [int] NOT NULL,
	[Role_Id] [int] NOT NULL,
 CONSTRAINT [PK_UserInRoles] PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC,
	[Role_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 09/20/2012 21:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Id] [int] NULL,
	[Title] [nvarchar](100) NULL,
	[Info] [nvarchar](250) NULL,
	[FullText] [nvarchar](max) NULL,
	[CreateTime] [datetime] NULL,
	[DeleteTime] [datetime] NULL,
	[Position] [int] NULL,
 CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ForumItems]    Script Date: 09/20/2012 21:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ForumItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Article_Id] [int] NULL,
	[Text] [nvarchar](1000) NULL,
	[User_Id] [int] NULL,
	[CreateTime] [datetime] NULL,
	[DeleteTime] [datetime] NULL,
 CONSTRAINT [PK_ForumItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArticleInSections]    Script Date: 09/20/2012 21:14:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArticleInSections](
	[Article_Id] [int] NOT NULL,
	[Section_Id] [int] NOT NULL,
 CONSTRAINT [PK_ArticleInSections] PRIMARY KEY CLUSTERED 
(
	[Article_Id] ASC,
	[Section_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_ArticleInSections_Articles]    Script Date: 09/20/2012 21:14:13 ******/
ALTER TABLE [dbo].[ArticleInSections]  WITH CHECK ADD  CONSTRAINT [FK_ArticleInSections_Articles] FOREIGN KEY([Article_Id])
REFERENCES [dbo].[Articles] ([Id])
GO
ALTER TABLE [dbo].[ArticleInSections] CHECK CONSTRAINT [FK_ArticleInSections_Articles]
GO
/****** Object:  ForeignKey [FK_ArticleInSections_Sections]    Script Date: 09/20/2012 21:14:13 ******/
ALTER TABLE [dbo].[ArticleInSections]  WITH CHECK ADD  CONSTRAINT [FK_ArticleInSections_Sections] FOREIGN KEY([Section_Id])
REFERENCES [dbo].[Sections] ([Id])
GO
ALTER TABLE [dbo].[ArticleInSections] CHECK CONSTRAINT [FK_ArticleInSections_Sections]
GO
/****** Object:  ForeignKey [FK_Articles_Users]    Script Date: 09/20/2012 21:14:13 ******/
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD  CONSTRAINT [FK_Articles_Users] FOREIGN KEY([User_Id])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Articles] CHECK CONSTRAINT [FK_Articles_Users]
GO
/****** Object:  ForeignKey [FK_ForumItems_Articles]    Script Date: 09/20/2012 21:14:13 ******/
ALTER TABLE [dbo].[ForumItems]  WITH CHECK ADD  CONSTRAINT [FK_ForumItems_Articles] FOREIGN KEY([Article_Id])
REFERENCES [dbo].[Articles] ([Id])
GO
ALTER TABLE [dbo].[ForumItems] CHECK CONSTRAINT [FK_ForumItems_Articles]
GO
/****** Object:  ForeignKey [FK_ForumItems_Users]    Script Date: 09/20/2012 21:14:13 ******/
ALTER TABLE [dbo].[ForumItems]  WITH CHECK ADD  CONSTRAINT [FK_ForumItems_Users] FOREIGN KEY([User_Id])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[ForumItems] CHECK CONSTRAINT [FK_ForumItems_Users]
GO
/****** Object:  ForeignKey [FK_Sections_Sections]    Script Date: 09/20/2012 21:14:13 ******/
ALTER TABLE [dbo].[Sections]  WITH CHECK ADD  CONSTRAINT [FK_Sections_Sections] FOREIGN KEY([Parent_Id])
REFERENCES [dbo].[Sections] ([Id])
GO
ALTER TABLE [dbo].[Sections] CHECK CONSTRAINT [FK_Sections_Sections]
GO
/****** Object:  ForeignKey [FK_UserInRoles_Roles]    Script Date: 09/20/2012 21:14:13 ******/
ALTER TABLE [dbo].[UserInRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserInRoles_Roles] FOREIGN KEY([Role_Id])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[UserInRoles] CHECK CONSTRAINT [FK_UserInRoles_Roles]
GO
/****** Object:  ForeignKey [FK_UserInRoles_Users]    Script Date: 09/20/2012 21:14:13 ******/
ALTER TABLE [dbo].[UserInRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserInRoles_Users] FOREIGN KEY([User_Id])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserInRoles] CHECK CONSTRAINT [FK_UserInRoles_Users]
GO
