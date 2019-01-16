CREATE TABLE [dbo].[RisetPublikasi] (
    [idrisetpublikasi] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idreff]           BIGINT        DEFAULT ((0)) NOT NULL,
    [tablereff]        VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [nodokumen]        VARCHAR (20)  DEFAULT ('-') NOT NULL,
    [judul]            VARCHAR (200) DEFAULT ('-') NOT NULL,
    [tanggalpublikasi] DATE          DEFAULT (getdate()) NOT NULL,
    [tempat]           VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [isrisettype]      BIGINT        DEFAULT ((0)) NOT NULL,
    [remarks]          VARCHAR (200) DEFAULT ('-') NOT NULL,
    [isdeleted]        BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]        BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]      DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]        BIGINT        NULL,
    [updateddate]      DATETIME      NULL,
    [idcompany]        BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idrisetpublikasi] ASC)
);

