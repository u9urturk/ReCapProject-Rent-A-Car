CREATE TABLE [dbo].[Users] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50)    NOT NULL,
    [LastName]     VARCHAR (50)    NOT NULL,
    [Email]        VARCHAR (50)    NOT NULL,
    [PasswordHash] VARBINARY (500) NOT NULL,
    [PasswordSalt] VARBINARY (500) NOT NULL,
    [Status]       BIT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[UserOperationClaims] (
    [Id]               INT IDENTITY (1, 1) NOT NULL,
    [UserId]           INT NOT NULL,
    [OperationClaimId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[RentArchives] (
    [Id]         INT      NOT NULL,
    [CarId]      INT      NOT NULL,
    [CustomerId] INT      NOT NULL,
    [RentDate]   DATETIME NOT NULL,
    [ReturnDate] DATETIME NOT NULL,
    CONSTRAINT [PK_RentArchives] PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[Rentals] (
    [Id]         INT      IDENTITY (1, 1) NOT NULL,
    [CarId]      INT      NOT NULL,
    [CustomerId] INT      NOT NULL,
    [RentDate]   DATETIME NOT NULL,
    [ReturnDate] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[OperationClaims] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Customers] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [UserId]      INT           NOT NULL,
    [CompanyName] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);




CREATE TABLE [dbo].[Colors] (
    [ColorId]   INT        IDENTITY (1, 1) NOT NULL,
    [ColorName] NCHAR (20) NULL,
    CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED ([ColorId] ASC)
);




CREATE TABLE [dbo].[Cars] (
    [CarId]        INT          IDENTITY (1, 1) NOT NULL,
    [CarName]      NCHAR (20)   DEFAULT (NULL) NULL,
    [BrandId]      INT          DEFAULT (NULL) NULL,
    [ColorId]      INT          DEFAULT (NULL) NULL,
    [ModelYear]    INT          DEFAULT (NULL) NULL,
    [DailyPrice]   DECIMAL (18) DEFAULT (NULL) NULL,
    [Desciription] NCHAR (50)   DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC)
);




CREATE TABLE [dbo].[Brands] (
    [BrandId]   INT        NOT NULL,
    [BrandName] NCHAR (20) NULL,
    CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED ([BrandId] ASC)
);



CREATE TABLE [dbo].[CarImages] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [CarId]     INT            NOT NULL,
    [ImagePath] NVARCHAR (MAX) NULL,
    [Date]      DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


