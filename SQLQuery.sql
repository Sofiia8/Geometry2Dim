
CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
	[Name] NVARCHAR (MAX) NOT NULL,
	[CategoryId] INT NULL,
	CONSTRAINT [FK_Product_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([Id]) ON DELETE CASCADE
)

CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
	[Name] NVARCHAR (MAX) NOT NULL
)
 

 insert into [dbo].[Category] ([Name]) VALUES
 (N'Напитки'), (N'Чай'), (N'Растительные продукты');

 insert into [dbo].[Product] ([Name], [CategoryId]) values
 (N'Кофе Арабика', 1),
 (N'Чай с бергамотом', 1),
 (N'Чай с бергамотом', 2),
 (N'Кокосовое молоко', 1),
 (N'Кокосовое молоко', 3),
 (N'Урбеч миндальный', 3),
 (N'Чипсы Lays сметана и лук', NULL);

 ------------------------------

 select prod.Name, cat.Name
 from [dbo].[Product] prod
 left join [dbo].[Category] cat
 on prod.CategoryId = cat.Id;