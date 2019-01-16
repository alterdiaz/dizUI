CREATE TABLE [dbo].[AnalisaRMDT] (
    [idanalisarmdt] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idregistrasi]  BIGINT        DEFAULT ((0)) NOT NULL,
    [idsoapnote]    BIGINT        DEFAULT ((0)) NOT NULL,
    [analisarmtype] BIGINT        DEFAULT ((0)) NOT NULL,
    [jenisdiagnosa] BIGINT        DEFAULT ((0)) NOT NULL,
    [idicd]         BIGINT        DEFAULT ((0)) NOT NULL,
    [isdeleted]     BIGINT        DEFAULT ((0)) NOT NULL,
    [deletereason]  VARCHAR (300) DEFAULT ('-') NOT NULL,
    [createdby]     BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]   DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]     BIGINT        NULL,
    [updateddate]   DATETIME      NULL,
    [idcompany]     BIGINT        DEFAULT ((0)) NOT NULL,
    [remarks]       VARCHAR (300) DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idanalisarmdt] ASC)
);




GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'utama, kedua, lainnya', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AnalisaRMDT', @level2type = N'COLUMN', @level2name = N'jenisdiagnosa';

