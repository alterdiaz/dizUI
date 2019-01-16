CREATE TABLE [dbo].[UnitCOA] (
    [idunitcoa]   BIGINT   IDENTITY (1, 1) NOT NULL,
    [idunit]      BIGINT   DEFAULT ((0)) NOT NULL,
    [idcoa]       BIGINT   DEFAULT ((0)) NOT NULL,
    [isdeleted]   BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT   NULL,
    [updateddate] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([idunitcoa] ASC)
);

