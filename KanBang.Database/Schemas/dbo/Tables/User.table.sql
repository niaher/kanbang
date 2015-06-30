CREATE TABLE [dbo].[User]
(
	[Id] int identity NOT NULL,
	[Email] nvarchar(250) NOT NULL,
	[FirstName] nvarchar(250) NOT NULL,
	[LastName] nvarchar(250) NOT NULL
)
