ALTER TABLE [dbo].[Story]
	ADD CONSTRAINT [StoryCurrentKanbanColumn] 
	FOREIGN KEY ([CurrentColumnId])
	REFERENCES [KanbanColumn] ([Id])