CREATE TABLE [dbo].[Kamar] (
    [idkamar]      BIGINT   IDENTITY (1, 1) NOT NULL,
    [idlokasi]     BIGINT   DEFAULT ((0)) NOT NULL,
    [idpriority]   BIGINT   DEFAULT ((0)) NOT NULL,
    [idregistrasi] BIGINT   DEFAULT ((0)) NOT NULL,
    [checkin]      DATETIME NULL,
    [checkout]     DATETIME NULL,
    [statusbed]    BIGINT   DEFAULT ((0)) NOT NULL,
    [isdeleted]    BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT   NULL,
    [updateddate]  DATETIME NULL,
    [idcompany]    BIGINT   DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idkamar] ASC)
);

