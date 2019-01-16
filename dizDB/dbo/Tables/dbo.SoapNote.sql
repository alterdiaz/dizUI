CREATE TABLE [dbo].[SoapNote] (
    [idsoapnote]      BIGINT         IDENTITY (1, 1) NOT NULL,
    [idregistrasi]    BIGINT         DEFAULT ((0)) NOT NULL,
    [transactiontype] BIGINT         DEFAULT ((0)) NOT NULL,
    [soapnotetype]    BIGINT         DEFAULT ((0)) NOT NULL,
    [soapnoteno]      VARCHAR (30)   DEFAULT ('-') NOT NULL,
    [soapnotedate]    DATETIME       DEFAULT (getdate()) NOT NULL,
    [chiefcomplain]   VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [subyektif]       VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [obyektif]        VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [asesmen]         VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [planning]        VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [hashcode]        VARCHAR (1000) DEFAULT ('-') NOT NULL,
    [isdeleted]       BIGINT         DEFAULT ((0)) NOT NULL,
    [deletereason]    VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [createdby]       BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]     DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]       BIGINT         NULL,
    [updateddate]     DATETIME       NULL,
    [idcompany]       BIGINT         DEFAULT ((0)) NOT NULL,
    [bb]              BIGINT         DEFAULT ((0)) NOT NULL,
    [tb]              BIGINT         DEFAULT ((0)) NOT NULL,
    [tdsis]           BIGINT         DEFAULT ((0)) NOT NULL,
    [tddias]          BIGINT         DEFAULT ((0)) NOT NULL,
    [oksigendarah]    BIGINT         DEFAULT ((0)) NOT NULL,
    [suhu]            DECIMAL (6, 1) DEFAULT ((0)) NOT NULL,
    [nafas]           BIGINT         DEFAULT ((0)) NOT NULL,
    [denyutnadi]      BIGINT         DEFAULT ((0)) NOT NULL,
    [isnadi]          BIGINT         DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idsoapnote] ASC)
);




GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'tidak digunakan lagi 30-08-2018 08:51', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SoapNote', @level2type = N'COLUMN', @level2name = N'chiefcomplain';

