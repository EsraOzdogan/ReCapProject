CREATE TABLE [dbo].[Cars] (
    [CarId]              INT           IDENTITY (1, 1) NOT NULL,
    [CarName]            NVARCHAR (50) NOT NULL,
    [BrandId]         INT           NOT NULL,
    [ColorId]         INT           NOT NULL,
    [DailyPrice]      DECIMAL (18)  NOT NULL,
    [ModelYear]       SMALLINT      NOT NULL,
    [Description]     NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cars_Brands] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([Id]),
    CONSTRAINT [FK_Cars_Colors] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([Id])
);

CREATE TABLE [dbo].[Brands] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (25) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Colors] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (25) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);