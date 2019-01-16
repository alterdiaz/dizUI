CREATE TABLE [dbo].[Transaksi] (
    [idtransaksi]           BIGINT          IDENTITY (1, 1) NOT NULL,
    [idtransaksireff]       BIGINT          DEFAULT ((0)) NOT NULL,
    [transaksitype]         BIGINT          DEFAULT ((0)) NOT NULL,
    [transaksitypereff]     BIGINT          DEFAULT ((0)) NOT NULL,
    [transaksino]           VARCHAR (50)    DEFAULT ('-') NOT NULL,
    [transaksistatus]       BIGINT          DEFAULT ((0)) NOT NULL,
    [idasal]                BIGINT          DEFAULT ((0)) NOT NULL,
    [asaltype]              VARCHAR (150)   DEFAULT ('-') NOT NULL,
    [iddeptasal]            BIGINT          DEFAULT ((0)) NOT NULL,
    [idtujuan]              BIGINT          DEFAULT ((0)) NOT NULL,
    [tujuantype]            VARCHAR (150)   DEFAULT ((0)) NOT NULL,
    [iddepttujuan]          BIGINT          DEFAULT ((0)) NOT NULL,
    [kodetujuan]            VARCHAR (20)    DEFAULT ('-') NOT NULL,
    [namatujuan]            VARCHAR (500)   DEFAULT ('-') NOT NULL,
    [npwp]                  VARCHAR (50)    DEFAULT ('-') NOT NULL,
    [phone]                 VARCHAR (50)    DEFAULT ('-') NOT NULL,
    [email]                 VARCHAR (500)   DEFAULT ('-') NOT NULL,
    [alamat]                VARCHAR (2000)  DEFAULT ('-') NOT NULL,
    [contactperson]         VARCHAR (500)   DEFAULT ('-') NOT NULL,
    [paymenttype]           BIGINT          DEFAULT ((0)) NOT NULL,
    [isdeleted]             BIGINT          NOT NULL,
    [remarks]               VARCHAR (500)   NOT NULL,
    [subtotal]              DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [discglobal]            DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [discsubtotal]          DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [subtotaldisc]          DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [ppn]                   DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [subtotaldiscppn]       DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [ongkir]                DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [subtotaldiscppnongkir] DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [createdby]             BIGINT          NOT NULL,
    [createddate]           DATETIME        NOT NULL,
    [createdfromip]         VARCHAR (20)    NOT NULL,
    [createdfromhostname]   VARCHAR (300)   NOT NULL,
    [updatedby]             BIGINT          NULL,
    [updateddate]           DATETIME        NULL,
    [updatedfromip]         VARCHAR (20)    NULL,
    [updatedfromhostname]   VARCHAR (300)   NULL,
    [reviewedby]            BIGINT          NULL,
    [revieweddate]          DATETIME        NULL,
    [reviewedfromip]        VARCHAR (20)    NULL,
    [reviewedfromhostname]  VARCHAR (300)   NULL,
    [guid]                  VARCHAR (1000)  NULL,
    [idcompany]             BIGINT          DEFAULT ((0)) NOT NULL,
    [isdone]                BIGINT          DEFAULT ((0)) NOT NULL,
    [deletereason]          VARCHAR (200)   DEFAULT ('-') NOT NULL,
    [reviewedby2]           BIGINT          NULL,
    [revieweddate2]         DATETIME        NULL,
    [reviewedfromip2]       VARCHAR (20)    NULL,
    [reviewedfromhostname2] VARCHAR (300)   NULL,
    [reviewedby3]           BIGINT          NULL,
    [revieweddate3]         DATETIME        NULL,
    [reviewedfromip3]       VARCHAR (20)    NULL,
    [reviewedfromhostname3] VARCHAR (300)   NULL,
    PRIMARY KEY CLUSTERED ([idtransaksi] ASC)
);




GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'subtotal dari subtotal item', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Transaksi', @level2type = N'COLUMN', @level2name = N'subtotal';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'total disc dari item', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Transaksi', @level2type = N'COLUMN', @level2name = N'discsubtotal';

