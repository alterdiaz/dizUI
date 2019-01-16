CREATE TABLE [dbo].[RehabMedikDT] (
    [idrehabmedikdt] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idrehabmedik]   BIGINT   DEFAULT ((0)) NOT NULL,
    [rehabmediktype] BIGINT   DEFAULT ((0)) NOT NULL,
    [idicd]          BIGINT   CONSTRAINT [DF__TerapiFis__terap__6C59D134] DEFAULT ((0)) NOT NULL,
    [isdeleted]      BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]      BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate]    DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]      BIGINT   NULL,
    [updateddate]    DATETIME NULL,
    [idcompany]      BIGINT   DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idrehabmedikdt] ASC)
);

