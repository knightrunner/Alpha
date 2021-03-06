--
-- Autogenerated SQL script for database schema UserAccounting
-- Generated at 2010-09-05T00:05:39
-- Knightrunner.Library.Database.Schema.SqlServer.SqlServerScriptGenerator, Knightrunner.Library.Database.Schema.SqlServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

CREATE TABLE [dbo].[UserAccounts]
(
	[Id] int identity NOT NULL,
	[UserName] nvarchar(60) NOT NULL,
	[Email] nvarchar(250) NOT NULL,
	[Password] nvarchar(30) NOT NULL,
	[FullName] nvarchar(250) NOT NULL,
	[AddressLine1] nvarchar(100),
	[AddressLine2] nvarchar(100),
	[AddressLine3] nvarchar(100),
	[PostalCode] nvarchar(30),
	[CountryCode] nchar(2),
	[Telephone1] nvarchar(15),
	[Telephone2] nvarchar(15),
	[CreationDate] datetime NOT NULL,
	[IsApproved] bit NOT NULL,
	[IsLockedOut] bit NOT NULL,
	[IsOnline] bit NOT NULL,
	[LastActivityDate] datetime,
	[LastLockoutDate] datetime,
	[LastLoginDate] datetime,
	[LastPasswordChangeDate] datetime,
	[ExpireDate] datetime
);

ALTER TABLE [dbo].[UserAccounts] ADD CONSTRAINT [UserAccounts_PK] PRIMARY KEY CLUSTERED
([Id]);

CREATE TABLE [dbo].[Payments]
(
	[Id] int identity NOT NULL,
	[AccountId] int NOT NULL,
	[PaymentType] smallint NOT NULL,
	[PaymentBrand] smallint NOT NULL,
	[PaymentDetails] xml,
	[Priority] int NOT NULL
);

ALTER TABLE [dbo].[Payments] ADD CONSTRAINT [Payments_PK] PRIMARY KEY CLUSTERED
([Id]);

CREATE TABLE [dbo].[AccountTransactions]
(
	[Id] int identity NOT NULL,
	[AccountId] int NOT NULL,
	[DateTime] datetime NOT NULL,
	[TransactionType] smallint NOT NULL,
	[Data] xml NOT NULL
);

ALTER TABLE [dbo].[AccountTransactions] ADD CONSTRAINT [AccountTransactions_PK] PRIMARY KEY CLUSTERED
([Id]);

ALTER TABLE [dbo].[Payments] WITH CHECK ADD CONSTRAINT [Payments_FK_UserAccounts_AccountId] FOREIGN KEY
([AccountId]) REFERENCES [dbo].[UserAccounts] ([Id]);

ALTER TABLE [dbo].[AccountTransactions] WITH CHECK ADD CONSTRAINT [AccountTransactions_FK_UserAccounts_AccountId] FOREIGN KEY
([AccountId]) REFERENCES [dbo].[UserAccounts] ([Id]);

