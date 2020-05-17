CREATE TABLE [dbo].[Customers] (
    [First_Name]   VARCHAR (50) NOT NULL,
    [Surname]      VARCHAR (50) NOT NULL,
    [Phone_Number] NUMERIC (18) NOT NULL,
    [Email]        VARCHAR (50) NOT NULL,
    [Address]      VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([First_Name] ASC)
);

