ALTER TABLE [dbo].[Story]
	ADD CONSTRAINT [StoryTakenByUser] 
	FOREIGN KEY ([TakenByUserId])
	REFERENCES [User] ([Id])	