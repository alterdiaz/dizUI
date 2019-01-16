CREATE TABLE [dbo].[Singkatan] (
    [idsingkatan] BIGINT        IDENTITY (1, 1) NOT NULL,
    [singkatan]   VARCHAR (20)  DEFAULT ('-') NOT NULL,
    [remarks]     VARCHAR (100) DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idsingkatan] ASC)
);

