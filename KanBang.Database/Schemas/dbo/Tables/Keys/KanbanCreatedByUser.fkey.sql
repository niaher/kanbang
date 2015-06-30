ALTER TABLE [dbo].[Kanban]
	ADD CONSTRAINT [KanbanCreatedByUser] 
	FOREIGN KEY ([CreatedByUserId])
	REFERENCES [User] ([Id])	