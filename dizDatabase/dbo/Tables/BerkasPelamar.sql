CREATE TABLE [dbo].[BerkasPelamar] (
    [idberkaspelamar] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idstaff]         BIGINT        DEFAULT ((0)) NOT NULL,
    [idfiles]         BIGINT        DEFAULT ((0)) NOT NULL,
    [subject]         VARCHAR (200) DEFAULT ('-') NOT NULL,
    [remarks]         VARCHAR (500) DEFAULT ('-') NOT NULL,
    [isdeleted]       BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]       BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]     DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]       BIGINT        NULL,
    [updateddate]     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idberkaspelamar] ASC)
);

