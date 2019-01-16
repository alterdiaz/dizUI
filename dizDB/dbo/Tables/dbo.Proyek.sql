CREATE TABLE [dbo].[Proyek] (
    [idproyek]       BIGINT         IDENTITY (1, 1) NOT NULL,
    [nama]           VARCHAR (300)  DEFAULT ('-') NOT NULL,
    [tanggalmulai]   DATETIME       DEFAULT (getdate()) NOT NULL,
    [tanggalselesai] DATETIME       NULL,
    [isdeleted]      BIGINT         DEFAULT ((0)) NOT NULL,
    [deletereason]   VARCHAR (200)  DEFAULT ('-') NOT NULL,
    [createdby]      BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]    DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]      BIGINT         NULL,
    [updateddate]    DATETIME       NULL,
    [idcompany]      BIGINT         DEFAULT ((0)) NOT NULL,
    [remarks]        VARCHAR (1000) DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idproyek] ASC)
);

