CREATE TABLE [dbo].[Marcacao]
(
	[IdMarcacao] INT IDENTITY NOT NULL PRIMARY KEY, 
    [diaMarcacao] DATE NOT NULL, 
    [horaMarcacao] TIME NOT NULL, 
    [banhoMarcacao] NCHAR(3) NULL, 
    [tosaMarcacao] NCHAR(3) NULL, 
    [consultaMarcacao] NCHAR(3) NULL, 
    [situacaoMarcacao] NVARCHAR(10) NOT NULL, 
    [idPet] INT NOT NULL, 
    [cpfTutor] NCHAR(11) NOT NULL, 
    [CRMVVet] NVARCHAR(6) NOT NULL, 
    CONSTRAINT [FK_Marcacao_ToPet] FOREIGN KEY ([idPet]) REFERENCES [Pet]([idPet]), 
    CONSTRAINT [FK_Marcacao_ToTutor] FOREIGN KEY ([cpfTutor]) REFERENCES [Tutor]([cpfTutor]), 
    CONSTRAINT [FK_Marcacao_ToVeterinario] FOREIGN KEY ([CRMVVet]) REFERENCES [Veterinario]([CRMVVet])
)
