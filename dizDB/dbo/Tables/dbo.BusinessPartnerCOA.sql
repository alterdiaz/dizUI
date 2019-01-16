CREATE TABLE [dbo].[BusinessPartnerCOA] (
    [idbusinesspartnercoa] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idcoa]                BIGINT   DEFAULT ((0)) NOT NULL,
    [jeniscoa]             BIGINT   DEFAULT ((0)) NOT NULL,
    [isdeleted]            BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]            BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate]          DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]            BIGINT   NULL,
    [updateddate]          DATETIME NULL,
    CONSTRAINT [PK__Business__6ED0EA8947B25C6A] PRIMARY KEY CLUSTERED ([idbusinesspartnercoa] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'BUSINESSPARTNERCOA', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'BusinessPartnerCOA', @level2type = N'COLUMN', @level2name = N'jeniscoa';

