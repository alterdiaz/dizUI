CREATE TABLE [dbo].[sys_UserMessagesMember] (
    [idusermessagesmember] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idusermessageshd]     BIGINT   DEFAULT ((0)) NOT NULL,
    [iduser]               BIGINT   DEFAULT ((0)) NOT NULL,
    [isadmin]              BIGINT   DEFAULT ((0)) NOT NULL,
    [ispinned]             BIGINT   DEFAULT ((0)) NOT NULL,
    [isdeleted]            BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]            BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate]          DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]            BIGINT   NULL,
    [updateddate]          DATETIME NULL,
    PRIMARY KEY CLUSTERED ([idusermessagesmember] ASC)
);

