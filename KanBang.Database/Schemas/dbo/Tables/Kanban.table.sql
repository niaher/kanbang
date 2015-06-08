CREATE TABLE [dbo].[Kanban]
(
	[KanbanId] int identity NOT NULL,
	[Description] nvarchar(MAX) NULL,
	[Title] nvarchar(250) NOT NULL,
	[ProjectId] int NOT NULL,
	[DateStart] datetime NULL,
	[DateEnd] datetime NULL,
	[DateCreated] datetime NOT NULL,
	[CreatedBy] int null
)
