CREATE TABLE [dbo].[Story]
(
	[Id] int identity NOT NULL,
	[Priority] int NOT NULL,
	[Name] nvarchar(400) NOT NULL,
	[Description] nvarchar(MAX) NULL,
	[TakenByUserId] int NULL,
	[IsDeleted] bit NOT NULL, 
    [CurrentColumnId] INT NOT NULL
)