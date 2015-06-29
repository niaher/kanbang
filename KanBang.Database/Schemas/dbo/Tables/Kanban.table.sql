CREATE TABLE [dbo].[Kanban]
(
	[Id] int identity NOT NULL,
	[Title] nvarchar(250) NOT NULL,
	[Description] nvarchar(MAX) NULL,	
	[ProjectId] int NOT NULL,
	[CreatedOn] datetime NOT NULL,
	[CreatedBy] int null
)
