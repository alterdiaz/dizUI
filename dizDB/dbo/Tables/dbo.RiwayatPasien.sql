CREATE TABLE [dbo].[RiwayatPasien] (
    [idriwayatpasien]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [idreff]            BIGINT        DEFAULT ((0)) NOT NULL,
    [tablereff]         VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [idreff2]           BIGINT        DEFAULT ((0)) NOT NULL,
    [tablereff2]        VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [riwayattype]       BIGINT        DEFAULT ((0)) NOT NULL,
    [isriwayat]         BIGINT        DEFAULT ((0)) NOT NULL,
    [riwayat]           VARCHAR (500) DEFAULT ('-') NOT NULL,
    [riwayatalergitype] BIGINT        DEFAULT ((0)) NOT NULL,
    [remarks]           VARCHAR (300) DEFAULT ('-') NOT NULL,
    [reaksi]            VARCHAR (500) DEFAULT ('-') NOT NULL,
    [dosis]             VARCHAR (10)  DEFAULT ('-') NOT NULL,
    [durasi]            VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [isdeleted]         BIGINT        DEFAULT ((0)) NOT NULL,
    [deletereason]      VARCHAR (300) DEFAULT ('-') NOT NULL,
    [createdby]         BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]       DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]         BIGINT        NULL,
    [updateddate]       DATETIME      NULL,
    [idcompany]         BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idriwayatpasien] ASC)
);

