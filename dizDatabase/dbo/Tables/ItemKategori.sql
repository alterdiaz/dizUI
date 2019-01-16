CREATE TABLE [dbo].[ItemKategori] (
    [iditemkategori] BIGINT        IDENTITY (1, 1) NOT NULL,
    [itemkategori]   VARCHAR (200) DEFAULT ('-') NOT NULL,
    [isdeleted]      BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]      BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]    DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]      BIGINT        NULL,
    [updateddate]    DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([iditemkategori] ASC)
);

