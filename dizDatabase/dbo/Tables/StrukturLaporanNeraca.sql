CREATE TABLE [dbo].[StrukturLaporanNeraca] (
    [idstrukturlaporanneraca] BIGINT        IDENTITY (1, 1) NOT NULL,
    [strukturlaporanneraca]   VARCHAR (100) NOT NULL,
    [isdeleted]               BIGINT        NOT NULL,
    [createdby]               BIGINT        NOT NULL,
    [createddate]             DATETIME      NOT NULL,
    [updatedby]               BIGINT        NULL,
    [updateddate]             DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idstrukturlaporanneraca] ASC)
);

