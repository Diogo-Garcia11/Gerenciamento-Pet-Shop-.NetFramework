CREATE TABLE [dbo].[Raca]
(
	[IdRaca] INT IDENTITY NOT NULL PRIMARY KEY, 
    [descRaca] NVARCHAR(45) NOT NULL, 
    [fkEspecie] INT NOT NULL, 
    CONSTRAINT [FK_Raca_ToEspecie] FOREIGN KEY (fkEspecie) REFERENCES [Especie]([idEspecie])
)
