ALTER TABLE [dbo].[KanbanColumn]
	ADD CONSTRAINT [KanbanColumnKanban] 
	FOREIGN KEY ([KanbanId])
	REFERENCES [Kanban] ([Id])