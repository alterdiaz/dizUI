CREATE TABLE [dbo].[sys_MemoPermission] (
    [idmemopermission] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idmemo]           BIGINT         NOT NULL,
    [iduser]           BIGINT         NOT NULL,
    [usercomment]      VARCHAR (8000) NOT NULL,
    [isview]           BIGINT         NOT NULL,
    [viewdate]         DATETIME       NULL,
    [isdeleted]        BIGINT         NOT NULL,
    [createdby]        BIGINT         NOT NULL,
    [createddate]      DATETIME       NOT NULL,
    [updatedby]        BIGINT         NULL,
    [updateddate]      DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idmemopermission] ASC)
);

