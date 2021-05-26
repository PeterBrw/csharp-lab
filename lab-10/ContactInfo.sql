CREATE TABLE [dbo].[Table]
(
	[Id] INT IDENTITY NOT NULL,
	[Nume] NCHAR (50) NULL,
	[Compania] NCHAR (50) NULL,
	[Telefon fix] NCHAR (20) NULL,
	[Telefon mobil] NCHAR (20) NULL,
	[Email] NCHAR (50) NULL,
	[Client] BIT NULL,
	[Contactat] DATETIME NULL,
)
