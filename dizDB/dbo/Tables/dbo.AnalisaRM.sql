CREATE TABLE [dbo].[AnalisaRM] (
    [idanalisarm]  BIGINT        IDENTITY (1, 1) NOT NULL,
    [idregistrasi] BIGINT        DEFAULT ((0)) NOT NULL,
    [idsoapnote]   BIGINT        DEFAULT ((0)) NOT NULL,
    [subyektif]    BIGINT        DEFAULT ((0)) NOT NULL,
    [obyektif]     BIGINT        DEFAULT ((0)) NULL,
    [asesmen]      BIGINT        DEFAULT ((0)) NOT NULL,
    [planning]     BIGINT        DEFAULT ((0)) NOT NULL,
    [klpcm]        BIGINT        DEFAULT ((0)) NOT NULL,
    [isdeleted]    BIGINT        DEFAULT ((0)) NOT NULL,
    [deletereason] VARCHAR (300) DEFAULT ('-') NOT NULL,
    [createdby]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT        NULL,
    [updateddate]  DATETIME      NULL,
    [idcompany]    BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idanalisarm] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'selain SOAP', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AnalisaRM', @level2type = N'COLUMN', @level2name = N'subyektif';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'SOAP', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AnalisaRM', @level2type = N'COLUMN', @level2name = N'klpcm';

