CREATE TABLE [dbo].[Raca]
(
	[idRaca] INT IDENTITY NOT NULL PRIMARY KEY, 
    [descRaca] NVARCHAR(45) NOT NULL, 
    [idEspecie] INT NOT NULL, 
    CONSTRAINT [FK_Raca_ToEspecie] FOREIGN KEY ([idEspecie]) REFERENCES [Especie]([idEspecie])
)
