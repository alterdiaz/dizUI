CREATE TABLE [dbo].[TransaksiDT] (
    [idtransaksidt]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [idtransaksi]         BIGINT          NOT NULL,
    [iditem]              BIGINT          NOT NULL,
    [idsatuan]            BIGINT          NOT NULL,
    [kodeitem]            VARCHAR (20)    NOT NULL,
    [item]                VARCHAR (200)   NOT NULL,
    [itemtype]            BIGINT          NOT NULL,
    [type]                VARCHAR (100)   DEFAULT ('-') NOT NULL,
    [qtydispose]          DECIMAL (8, 2)  DEFAULT ((0)) NOT NULL,
    [qtycharges]          DECIMAL (8, 2)  DEFAULT ((0)) NOT NULL,
    [satuan]              VARCHAR (20)    CONSTRAINT [DF__Transaksi__satua__61FB72FB] DEFAULT ('-') NOT NULL,
    [price]               DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [subtotal]            DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [isdeleted]           BIGINT          NOT NULL,
    [discpersen]          BIGINT          NULL,
    [discamount]          DECIMAL (20, 2) NULL,
    [discsubtotal]        DECIMAL (20, 2) NULL,
    [subtotaldisc]        DECIMAL (20, 2) NULL,
    [ongkoslain]          DECIMAL (20, 2) NULL,
    [subtotaldisclain]    DECIMAL (20, 2) NULL,
    [isppn]               BIGINT          NULL,
    [ppnamount]           DECIMAL (20, 2) NULL,
    [subtotaldisclainppn] DECIMAL (20, 2) NULL,
    [subtotalpersonal]    DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [subtotalcorporate]   DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [createdby]           BIGINT          NOT NULL,
    [createddate]         DATETIME        NOT NULL,
    [createdfromip]       VARCHAR (20)    NOT NULL,
    [createdfromhostname] VARCHAR (300)   NOT NULL,
    [updatedby]           BIGINT          NULL,
    [updateddate]         DATETIME        NULL,
    [updatedfromip]       VARCHAR (20)    NULL,
    [updatedfromhostname] VARCHAR (300)   NULL,
    PRIMARY KEY CLUSTERED ([idtransaksidt] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'qty dikali price', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TransaksiDT', @level2type = N'COLUMN', @level2name = N'subtotal';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'diskon %', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TransaksiDT', @level2type = N'COLUMN', @level2name = N'discpersen';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'diskon rp', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TransaksiDT', @level2type = N'COLUMN', @level2name = N'discamount';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'diskon rupiah dikali qty', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TransaksiDT', @level2type = N'COLUMN', @level2name = N'discsubtotal';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'subtotal - diskon rp', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TransaksiDT', @level2type = N'COLUMN', @level2name = N'subtotaldisc';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'ppn rp', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TransaksiDT', @level2type = N'COLUMN', @level2name = N'ppnamount';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'subtotal - diskon rp + ppn', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TransaksiDT', @level2type = N'COLUMN', @level2name = N'subtotaldisclainppn';

