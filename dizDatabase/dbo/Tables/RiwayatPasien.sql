CREATE TABLE [dbo].[RiwayatPasien] (
    [idriwayatpasien] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idregistrasi]    BIGINT         DEFAULT ((0)) NOT NULL,
    [riwayattype]     BIGINT         DEFAULT ((0)) NOT NULL,
    [isriwayat]       BIGINT         DEFAULT ((0)) NOT NULL,
    [riwayat]         VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [isdeleted]       BIGINT         DEFAULT ((0)) NOT NULL,
    [deletereason]    VARCHAR (300)  DEFAULT ('-') NOT NULL,
    [createdby]       BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]     DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]       BIGINT         NULL,
    [updateddate]     DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idriwayatpasien] ASC)
);

