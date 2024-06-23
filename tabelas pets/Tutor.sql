CREATE TABLE [dbo].[Tutor]
(
	[cpfTutor] NCHAR(11) NOT NULL PRIMARY KEY UNIQUE, 
    [nomeTutor] NVARCHAR(45) NOT NULL, 
    [emailTutor] NVARCHAR(30) NOT NULL UNIQUE, 
    [celularTutor] NVARCHAR(15) NOT NULL
)
