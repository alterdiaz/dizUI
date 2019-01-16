CREATE TABLE [dbo].[Lokasi] (
    [idlokasi]     BIGINT        IDENTITY (1, 1) NOT NULL,
    [iddepartment] BIGINT        DEFAULT ((0)) NOT NULL,
    [idunit]       BIGINT        DEFAULT ((0)) NOT NULL,
    [lokasitype]   BIGINT        DEFAULT ((0)) NOT NULL,
    [nama]         VARCHAR (150) DEFAULT ('-') NOT NULL,
    [remarks]      VARCHAR (300) DEFAULT ('-') NOT NULL,
    [isdeleted]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT        NULL,
    [updateddate]  DATETIME      NULL,
    [idcompany]    BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idlokasi] ASC)
);

