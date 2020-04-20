DELETE FROM Images

SET IDENTITY_INSERT [dbo].[Images] ON
INSERT INTO [dbo].[Images] ([Id], [Title]) VALUES (1, N'NewTitle')
SET IDENTITY_INSERT [dbo].[Images] OFF
