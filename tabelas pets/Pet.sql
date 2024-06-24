CREATE TABLE [dbo].[Pet]
(
	[IdPet] INT IDENTITY NOT NULL PRIMARY KEY, 
    [nomePet] NVARCHAR(45) NOT NULL, 
    [sexoPet] NCHAR(5) NOT NULL, 
    [nascPet] NVARCHAR(25) NOT NULL, 
    [situacaoPet] NVARCHAR(10) NOT NULL, 
    [cpfTutor] NCHAR(11) NOT NULL, 
    [idRaca] INT NOT NULL, 
    [idEspecie] INT NOT NULL, 
    CONSTRAINT [FK_Pet_ToTutor] FOREIGN KEY ([cpfTutor]) REFERENCES [Tutor]([cpfTutor]), 
    CONSTRAINT [FK_Pet_ToRaca] FOREIGN KEY ([idRaca]) REFERENCES [Raca]([idRaca]), 
    CONSTRAINT [FK_Pet_ToEspecie] FOREIGN KEY ([idEspecie]) REFERENCES [Especie]([idEspecie])
)
