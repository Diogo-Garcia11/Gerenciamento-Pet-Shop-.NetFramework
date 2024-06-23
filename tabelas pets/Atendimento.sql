dCREATE TABLE [dbo].[Atendimento]
(
	[IdAtendimento] INT IDENTITY NOT NULL PRIMARY KEY, 
    [diaAtendimento] DATE NOT NULL, 
    [horaAtendimento] TIME NOT NULL, 
    [pescAtendimento] NVARCHAR(50) NULL, 
    [idPet] INT NOT NULL, 
    [cpfTutor] NCHAR(11) NOT NULL, 
    [idExame] INT NOT NULL, 
    CONSTRAINT [FK_Atendimento_ToPet] FOREIGN KEY ([idPet]) REFERENCES [Pet]([idPet]), 
    CONSTRAINT [FK_Atendimento_ToTutor] FOREIGN KEY ([cpfTutor]) REFERENCES [Tutor]([cpfTutor]), 
    CONSTRAINT [FK_Atendimento_ToExame] FOREIGN KEY ([idExame]) REFERENCES [Exame]([idExame])
)
