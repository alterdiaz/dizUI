CREATE TABLE [dbo].[Pelatihan] (
    [idpelatihan]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [idreff]           BIGINT        DEFAULT ((0)) NOT NULL,
    [tablereff]        VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [nomorsertifikat]  VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [judul]            VARCHAR (200) DEFAULT ('-') NOT NULL,
    [tempat]           VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [tanggalpelatihan] DATE          DEFAULT (getdate()) NOT NULL,
    [remarks]          VARCHAR (200) DEFAULT ('-') NOT NULL,
    [isdeleted]        BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]        BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]      DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]        BIGINT        NULL,
    [updateddate]      DATETIME      NULL,
    [idcompany]        BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idpelatihan] ASC)
);

