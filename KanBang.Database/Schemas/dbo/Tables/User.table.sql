CREATE TABLE [dbo].[User]
(
	[UserId] int identity NOT NULL,
	[Email] nvarchar(250) NOT NULL,
	[FirstName] nvarchar(250) NOT NULL,
	[LastName] nvarchar(250) NOT NULL,
	[Password] nvarchar(250) NOT NULL,
	[LastLoggedInDate] datetime null
)
