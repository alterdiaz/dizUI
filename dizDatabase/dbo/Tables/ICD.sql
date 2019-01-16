CREATE TABLE [dbo].[ICD] (
    [idicd]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [idparent]    BIGINT        DEFAULT ((0)) NOT NULL,
    [icdtype]     BIGINT        DEFAULT ((0)) NOT NULL,
    [kode]        VARCHAR (10)  DEFAULT ('-') NOT NULL,
    [kodeakhir]   VARCHAR (10)  DEFAULT ('-') NOT NULL,
    [diagnosa]    VARCHAR (300) DEFAULT ('-') NOT NULL,
    [remarks]     VARCHAR (500) DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idicd] ASC)
);

