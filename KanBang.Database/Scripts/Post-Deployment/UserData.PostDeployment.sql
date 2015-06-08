IF (NOT EXISTS (SELECT 1 FROM [dbo].[User]))
BEGIN
INSERT INTO [User] (Email, FirstName, LastName, Password) VALUES ('edgargs@unops.org', 'Edgar GIL', 'SERRA', 'aaaaaa')
INSERT INTO [User] (Email, FirstName, LastName, Password) VALUES ('FredrikC@unops.org', 'Fredrik', 'Carleson', 'aaaaaa')
INSERT INTO [User] (Email, FirstName, LastName, Password) VALUES ('nikitap@unops.org', 'Nikita', 'PSHENOV', 'aaaaaa')
INSERT INTO [User] (Email, FirstName, LastName, Password) VALUES ('potjanak@unops.org', 'Potjana', 'KOOKOOMUANG', 'aaaaaa')
INSERT INTO [User] (Email, FirstName, LastName, Password) VALUES ('princeo@unops.org', 'Prince Obiechine', 'ONYENIKE', 'aaaaaa')
INSERT INTO [User] (Email, FirstName, LastName, Password) VALUES ('PwintphyuK@unops.org', 'Pwint Phyu', 'KYAW', 'aaaaaa')
END
