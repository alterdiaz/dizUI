CREATE TABLE [dbo].[Spesialis] (
    [idspesialis] BIGINT        IDENTITY (1, 1) NOT NULL,
    [nama]        VARCHAR (300) DEFAULT ('-') NOT NULL,
    [remarks]     VARCHAR (500) DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    [idcompany]   BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idspesialis] ASC)
);

