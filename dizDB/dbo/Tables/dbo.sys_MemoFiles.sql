CREATE TABLE [dbo].[sys_MemoFiles] (
    [idmemofiles] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idmemo]      BIGINT   DEFAULT ((0)) NOT NULL,
    [idfiles]     BIGINT   DEFAULT ((0)) NOT NULL,
    [isdeleted]   BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT   NULL,
    [updateddate] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([idmemofiles] ASC)
);

