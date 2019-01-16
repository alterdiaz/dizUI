CREATE TABLE [dbo].[PerawatMasalah] (
    [idperawatmasalah] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idregistrasi]     BIGINT         DEFAULT ((0)) NOT NULL,
    [masalahtype]      BIGINT         DEFAULT ((0)) NOT NULL,
    [remarks]          VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [isdeleted]        BIGINT         DEFAULT ((0)) NOT NULL,
    [deletereason]     VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [createdby]        BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]      DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]        BIGINT         NULL,
    [updateddate]      DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idperawatmasalah] ASC)
);

