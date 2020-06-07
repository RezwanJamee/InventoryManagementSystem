CREATE TABLE [dbo].[Vendors]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Vendor Name] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Phone] NUMERIC NOT NULL, 
    [Address] VARCHAR(50) NOT NULL
)
