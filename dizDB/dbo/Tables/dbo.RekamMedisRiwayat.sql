CREATE TABLE [dbo].[RekamMedisRiwayat] (
    [idrekammedisriwayat] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idrekammedis]        BIGINT         DEFAULT ((0)) NOT NULL,
    [iduser]              BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]         DATETIME       DEFAULT (getdate()) NOT NULL,
    [remarks]             VARCHAR (2000) DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idrekammedisriwayat] ASC)
);

