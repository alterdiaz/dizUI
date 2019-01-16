CREATE TABLE [dbo].[Bank] (
    [idbank]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [idcoa]       BIGINT        DEFAULT ((0)) NOT NULL,
    [bank]        VARCHAR (100) DEFAULT ('-') NOT NULL,
    [norekening]  VARCHAR (100) DEFAULT ('-') NOT NULL,
    [remarks]     VARCHAR (500) DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idbank] ASC)
);

