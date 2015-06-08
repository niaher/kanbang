ALTER TABLE [dbo].[Kanban]
	ADD CONSTRAINT [KanbanProject] 
	FOREIGN KEY ([ProjectId])
	REFERENCES [Project] ([ProjectId])	