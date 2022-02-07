CREATE TABLE [dbo].[Cake] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (MAX)   NULL,
    [Price]       DECIMAL (18, 2) NULL,
    [Description] VARCHAR (MAX)   NULL
);