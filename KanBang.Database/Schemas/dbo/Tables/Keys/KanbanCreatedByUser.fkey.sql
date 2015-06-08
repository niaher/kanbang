ALTER TABLE [dbo].[Kanban]
	ADD CONSTRAINT [KanbanCreatedByUser] 
	FOREIGN KEY ([CreatedBy])
	REFERENCES [User] ([UserId])	