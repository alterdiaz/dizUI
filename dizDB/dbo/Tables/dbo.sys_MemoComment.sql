CREATE TABLE [dbo].[sys_MemoComment] (
    [idmemocomment] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idmemo]        BIGINT         DEFAULT ((0)) NOT NULL,
    [memocomment]   VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [isdeleted]     BIGINT         DEFAULT ((0)) NOT NULL,
    [forwardto]     BIGINT         DEFAULT ((0)) NOT NULL,
    [forwardby]     BIGINT         DEFAULT ((0)) NOT NULL,
    [forwarddate]   DATETIME       NULL,
    [createdby]     BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]   DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]     BIGINT         NULL,
    [updateddate]   DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idmemocomment] ASC)
);

