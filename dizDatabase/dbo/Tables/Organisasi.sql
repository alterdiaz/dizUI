CREATE TABLE [dbo].[Organisasi] (
    [idorganisasi] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idreff]       BIGINT        DEFAULT ((0)) NOT NULL,
    [tablereff]    VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [nomoranggota] VARCHAR (20)  DEFAULT ('-') NOT NULL,
    [nama]         VARCHAR (300) DEFAULT ('-') NOT NULL,
    [jabatan]      VARCHAR (100) DEFAULT ('-') NOT NULL,
    [tanggalmulai] DATE          DEFAULT (getdate()) NOT NULL,
    [tanggalakhir] DATE          DEFAULT (NULL) NULL,
    [remarks]      VARCHAR (200) DEFAULT ('-') NOT NULL,
    [isdeleted]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT        NULL,
    [updateddate]  DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idorganisasi] ASC)
);

