USE [master]
GO

-- 1. Create the database without hardcoded paths
CREATE DATABASE [CIPHER]
GO

USE [CIPHER]
GO

-- 2. Create Tables
CREATE TABLE [dbo].[Factions](
	[FactionID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](50) NOT NULL,
	[Emblem] [nvarchar](10) NOT NULL,
	[TotalXP] [int] DEFAULT (0)
);

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[CodeName] [nvarchar](50) NOT NULL UNIQUE,
	[FullName] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL UNIQUE,
	[PasswordHash] [nvarchar](255) NOT NULL,
	[Role] [nvarchar](20) DEFAULT ('Agent'),
	[XP] [int] DEFAULT (0),
	[CryptCoin] [int] DEFAULT (100),
	[Rank] [nvarchar](30) DEFAULT ('Recruit'),
	[FactionID] [int] REFERENCES [dbo].[Factions]([FactionID]),
	[AccountStatus] [nvarchar](20) DEFAULT ('Active'),
	[JoinDate] [datetime] DEFAULT (getdate())
);

CREATE TABLE [dbo].[Missions](
	[MissionID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Title] [nvarchar](100) NOT NULL,
	[Category] [nvarchar](30) NOT NULL,
	[Difficulty] [nvarchar](20) NOT NULL,
	[Briefing] [nvarchar](max) NOT NULL,
	[Answer] [nvarchar](255) NOT NULL,
	[Hint] [nvarchar](255) NULL,
	[XPReward] [int] DEFAULT (37),
	[CoinReward] [int] DEFAULT (7),
	[OrderIndex] [int] NOT NULL
);

-- 3. Insert Initial Data
SET IDENTITY_INSERT [dbo].[Factions] ON 
INSERT [dbo].[Factions] ([FactionID], [Name], [Emblem], [TotalXP]) VALUES (1, N'Neon Syndicate', N'?', 0), (2, N'Void Protocol', N'?', 0)
SET IDENTITY_INSERT [dbo].[Factions] OFF

SET IDENTITY_INSERT [dbo].[Missions] ON 
INSERT [dbo].[Missions] ([MissionID], [Title], [Category], [Difficulty], [Briefing], [Answer], [Hint], [XPReward], [CoinReward], [OrderIndex]) VALUES 
(1, N'Operation CAESAR', N'Crypto', N'Easy', N'Intercept decrypted. Shift of 3. Decode: KHOOR ZRUOG', N'HELLO WORLD', N'Shift back by 3', 50, 25, 1),
(2, N'Binary Ghost', N'Binary', N'Easy', N'Translate binary to ASCII', N'CIPHER', N'Use ASCII table', 75, 35, 2)
SET IDENTITY_INSERT [dbo].[Missions] OFF
GO