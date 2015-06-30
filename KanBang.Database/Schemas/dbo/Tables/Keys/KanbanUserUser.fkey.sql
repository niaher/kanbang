ALTER TABLE [dbo].[KanbanUser]
	ADD CONSTRAINT [KanbanUserUser] 
	FOREIGN KEY ([UserId])
	REFERENCES [User] ([Id])	