CREATE TABLE [dbo].[PemeriksaanFisik] (
    [idpemeriksaanfisik] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idregistrasi]       BIGINT         DEFAULT ((0)) NOT NULL,
    [pemeriksaanfisik]   BIGINT         DEFAULT ((0)) NOT NULL,
    [keadaanfisik]       BIGINT         DEFAULT ((0)) NOT NULL,
    [remarks]            VARCHAR (2000) DEFAULT ('-') NOT NULL,
    [isdeleted]          BIGINT         DEFAULT ((0)) NOT NULL,
    [deletereason]       VARCHAR (300)  DEFAULT ('-') NOT NULL,
    [createdby]          BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]        DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]          BIGINT         NULL,
    [updateddate]        DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idpemeriksaanfisik] ASC)
);

