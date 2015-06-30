ALTER TABLE [dbo].[KanbanUser]
	ADD CONSTRAINT [KanbanUserKanban] 
	FOREIGN KEY ([KanbanId])
	REFERENCES [Kanban] ([Id])	