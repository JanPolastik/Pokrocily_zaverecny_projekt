CREATE TABLE [dbo].[Insured] (
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (50) NOT NULL,
    [Adress] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Insured] PRIMARY KEY CLUSTERED ([Id] ASC)
);

