CREATE TABLE [dbo].[Images]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] VARCHAR(50) NOT NULL, 
    [Image] NVARCHAR(50) NULL, 
    [Description] VARCHAR(50) NULL, 
    [Format] NVARCHAR(50) NULL, 
    [Subject] INT NOT NULL, 
    [User] INT NOT NULL, 
    [Date] DATE NULL

)
