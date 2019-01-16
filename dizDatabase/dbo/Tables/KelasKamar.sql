CREATE TABLE [dbo].[KelasKamar] (
    [idkelaskamar] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idkamar]      BIGINT   DEFAULT ((0)) NOT NULL,
    [idkelas]      BIGINT   DEFAULT ((0)) NOT NULL,
    [isdeleted]    BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT   NULL,
    [updateddate]  DATETIME NULL,
    PRIMARY KEY CLUSTERED ([idkelaskamar] ASC)
);

