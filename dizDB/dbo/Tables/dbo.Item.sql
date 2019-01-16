CREATE TABLE [dbo].[Item] (
    [iditem]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [idsatuan]    BIGINT        DEFAULT ((0)) NOT NULL,
    [itemgrup]    BIGINT        DEFAULT ((0)) NOT NULL,
    [itemtype]    BIGINT        DEFAULT ((0)) NOT NULL,
    [kode]        VARCHAR (20)  DEFAULT ('-') NOT NULL,
    [item]        VARCHAR (200) DEFAULT ('-') NOT NULL,
    [remarks]     VARCHAR (500) DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    [idcompany]   BIGINT        DEFAULT ((0)) NOT NULL,
    [isppn]       BIGINT        DEFAULT ((0)) NOT NULL,
    [ispph]       BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([iditem] ASC)
);



