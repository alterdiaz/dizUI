CREATE TABLE [dbo].[SoapNoteDT] (
    [idsoapnotedt]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [idsoapnote]     BIGINT         DEFAULT ((0)) NOT NULL,
    [soapnotedttype] BIGINT         DEFAULT ((0)) NOT NULL,
    [remarks]        VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [isdeleted]      BIGINT         DEFAULT ((0)) NOT NULL,
    [deletereason]   VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [createdby]      BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]    DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]      BIGINT         NULL,
    [updateddate]    DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idsoapnotedt] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'obyektiftype,hasilperiksatype', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SoapNoteDT', @level2type = N'COLUMN', @level2name = N'soapnotedttype';

