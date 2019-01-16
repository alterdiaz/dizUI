CREATE TABLE [dbo].[sys_MemoComment] (
    [idmemocomment] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idmemo]        BIGINT         NOT NULL,
    [memocomment]   VARCHAR (8000) NOT NULL,
    [isdeleted]     BIGINT         NOT NULL,
    [createdby]     BIGINT         NOT NULL,
    [createddate]   DATETIME       NOT NULL,
    [updatedby]     BIGINT         NULL,
    [updateddate]   DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idmemocomment] ASC)
);

