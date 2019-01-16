CREATE TABLE [dbo].[RegistrasiDPJP] (
    [idregistrasidpjp] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idregistrasi]     BIGINT   DEFAULT ((0)) NOT NULL,
    [iddokter]         BIGINT   DEFAULT ((0)) NOT NULL,
    [isprimary]        BIGINT   DEFAULT ((0)) NOT NULL,
    [isdeleted]        BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]        BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate]      DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]        BIGINT   NULL,
    [updateddate]      DATETIME NULL,
    PRIMARY KEY CLUSTERED ([idregistrasidpjp] ASC)
);

