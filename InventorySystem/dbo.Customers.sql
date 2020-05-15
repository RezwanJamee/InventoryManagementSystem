CREATE TABLE [dbo].[Customers]
(
	[First_Name] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Surname] VARCHAR(50) NOT NULL, 
    [Phone_Number] NUMERIC NOT NULL, 
    [Address] VARCHAR(50) NULL
)
