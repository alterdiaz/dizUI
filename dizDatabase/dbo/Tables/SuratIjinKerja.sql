CREATE TABLE [dbo].[SuratIjinKerja] (
    [idsuratijinkerja] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idreff]           BIGINT        DEFAULT ((0)) NOT NULL,
    [tablereff]        VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [instansipenerbit] VARCHAR (200) DEFAULT ('-') NOT NULL,
    [nomor]            VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [nomorstr]         VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [tanggalakhir]     DATE          DEFAULT (getdate()) NOT NULL,
    [nomorrekomendasi] VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [remarks]          VARCHAR (300) DEFAULT ('-') NOT NULL,
    [isdeleted]        BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]        BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]      DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]        BIGINT        NULL,
    [updateddate]      DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idsuratijinkerja] ASC)
);

