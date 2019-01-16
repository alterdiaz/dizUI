CREATE TABLE [dbo].[DietMenu] (
    [iddietmenu]  BIGINT        IDENTITY (1, 1) NOT NULL,
    [diettype]    BIGINT        DEFAULT ((0)) NOT NULL,
    [dietmenu]    VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [remarks]     VARCHAR (200) DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    [idcompany]   BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([iddietmenu] ASC)
);

