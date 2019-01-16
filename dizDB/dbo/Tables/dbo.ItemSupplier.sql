CREATE TABLE [dbo].[ItemSupplier] (
    [iditemsupplier]   BIGINT          IDENTITY (1, 1) NOT NULL,
    [iditem]           BIGINT          DEFAULT ((0)) NOT NULL,
    [idsupplier]       BIGINT          DEFAULT ((0)) NOT NULL,
    [idsatuan]         BIGINT          DEFAULT ((0)) NOT NULL,
    [qtycontent]       DECIMAL (8, 2)  DEFAULT ((1)) NOT NULL,
    [qtycharges]       DECIMAL (8, 2)  DEFAULT ((0)) NOT NULL,
    [qtyreceive]       DECIMAL (8, 2)  DEFAULT ((0)) NOT NULL,
    [harga]            DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [subtotal]         DECIMAL (8, 2)  DEFAULT ((0)) NOT NULL,
    [isdeleted]        BIGINT          DEFAULT ((0)) NOT NULL,
    [discpersen]       BIGINT          DEFAULT ((0)) NOT NULL,
    [discamount]       DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [discsubtotal]     DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [subtotaldisc]     DECIMAL (20, 2) NOT NULL,
    [ppnamount]        DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [subtotalsupplier] DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [createdby]        BIGINT          DEFAULT ((0)) NOT NULL,
    [createddate]      DATETIME        DEFAULT (getdate()) NOT NULL,
    [updatedby]        BIGINT          NULL,
    [updateddate]      DATETIME        NULL,
    [idcompany]        BIGINT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([iditemsupplier] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'awal-disc+ppn', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ItemSupplier', @level2type = N'COLUMN', @level2name = N'subtotalsupplier';

