﻿CREATE TABLE [dbo].[Customers]
(
	[Customer ID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[Address] NVARCHAR(50) NOT NULL,
	[City] NVARCHAR(50) NOT NULL,
	[State] NVARCHAR(50) NOT NULL,
	[Postal Codes] NVARCHAR(50) NOT NULL,
	[Notes] NVARCHAR(MAX) NOT NULL,
)
