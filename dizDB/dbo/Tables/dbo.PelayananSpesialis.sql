CREATE TABLE [dbo].[PelayananSpesialis] (
    [idpelayananspesialis] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idpelayanan]          BIGINT   DEFAULT ((0)) NOT NULL,
    [idspesialis]          BIGINT   DEFAULT ((0)) NOT NULL,
    [isdeleted]            BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]            BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate]          DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]            BIGINT   NULL,
    [updateddate]          DATETIME NULL,
    PRIMARY KEY CLUSTERED ([idpelayananspesialis] ASC)
);

