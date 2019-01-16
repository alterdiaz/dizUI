CREATE TABLE [dbo].[RegistrasiKamar] (
    [idregistrasikamar] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idregistrasi]      BIGINT        DEFAULT ((0)) NOT NULL,
    [idlokasi]          BIGINT        DEFAULT ((0)) NOT NULL,
    [checkin]           DATETIME      DEFAULT (getdate()) NOT NULL,
    [checkout]          DATETIME      NULL,
    [isdeleted]         BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]         BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]       DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]         BIGINT        NULL,
    [updateddate]       DATETIME      NULL,
    [idcompany]         BIGINT        DEFAULT ((0)) NOT NULL,
    [deletereason]      VARCHAR (200) DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idregistrasikamar] ASC)
);

