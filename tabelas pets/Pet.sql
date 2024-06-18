CREATE TABLE [dbo].[Pet]
(
	[IdPet] INT IDENTITY NOT NULL PRIMARY KEY, 
    [nomePet] NVARCHAR(45) NOT NULL, 
    [sexoPet] NCHAR(5) NOT NULL, 
    [nascPet] DATE NOT NULL, 
    [situacaoPet] NVARCHAR(10) NOT NULL, 
    [cpfTutor] NCHAR(11) NOT NULL, 
    [fkRaca] NVARCHAR(45) NOT NULL, 
    [fkEspecie] NVARCHAR(45) NOT NULL, 
    CONSTRAINT [FK_Pet_ToTutor] FOREIGN KEY ([cpfTutor]) REFERENCES [Tutor]([cpfTutor])
)
