CREATE TABLE [dbo].[ItemSupplier] (
    [iditemsupplier] BIGINT          IDENTITY (1, 1) NOT NULL,
    [iditem]         BIGINT          DEFAULT ((0)) NOT NULL,
    [idsupplier]     BIGINT          DEFAULT ((0)) NOT NULL,
    [idsatuan]       BIGINT          DEFAULT ((0)) NOT NULL,
    [qtycontent]     BIGINT          DEFAULT ((0)) NOT NULL,
    [discpersen]     BIGINT          DEFAULT ((0)) NOT NULL,
    [hargaawal]      DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargappn]       DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargadisc]      DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargasupplier]  DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [isdeleted]      BIGINT          DEFAULT ((0)) NOT NULL,
    [createdby]      BIGINT          DEFAULT ((0)) NOT NULL,
    [createddate]    DATETIME        DEFAULT (getdate()) NOT NULL,
    [updatedby]      BIGINT          NULL,
    [updateddate]    DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([iditemsupplier] ASC)
);

