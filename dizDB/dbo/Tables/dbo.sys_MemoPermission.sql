CREATE TABLE [dbo].[sys_MemoPermission] (
    [idmemopermission] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idmemo]           BIGINT   DEFAULT ((0)) NOT NULL,
    [iduser]           BIGINT   DEFAULT ((0)) NOT NULL,
    [isview]           BIGINT   DEFAULT ((0)) NOT NULL,
    [viewdate]         DATETIME NULL,
    [isdeleted]        BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]        BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate]      DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]        BIGINT   NULL,
    [updateddate]      DATETIME NULL,
    PRIMARY KEY CLUSTERED ([idmemopermission] ASC)
);

