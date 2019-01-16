﻿CREATE TABLE [dbo].[sys_MemoFiles] (
    [idmemofiles] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idmemo]      BIGINT   NOT NULL,
    [idfiles]     BIGINT   NOT NULL,
    [isdeleted]   BIGINT   NOT NULL,
    [createdby]   BIGINT   NOT NULL,
    [createddate] DATETIME NOT NULL,
    [updatedby]   BIGINT   NULL,
    [updateddate] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([idmemofiles] ASC)
);

