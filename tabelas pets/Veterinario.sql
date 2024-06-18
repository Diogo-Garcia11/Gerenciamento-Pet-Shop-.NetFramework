CREATE TABLE [dbo].[Veterinario]
(
	[CRMVVet] NVARCHAR(6) NOT NULL PRIMARY KEY, 
    [nomeVet] NVARCHAR(45) NOT NULL, 
    [enderecoVet] NVARCHAR(150) NOT NULL, 
    [celularVet] NCHAR(11) NOT NULL
)
