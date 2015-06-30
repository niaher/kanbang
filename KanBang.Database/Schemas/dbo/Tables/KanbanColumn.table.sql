CREATE TABLE [dbo].[KanbanColumn]
(
	[Id] int identity NOT NULL,
	[Name] nvarchar(250) NOT NULL,
	[OrderIndex] int NOT NULL,
	[WipLimit] int NULL,
	[KanbanId] int NOT NULL,
	[IsDeleted] bit NOT NULL
)
