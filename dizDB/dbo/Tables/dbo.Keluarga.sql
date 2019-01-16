CREATE TABLE [dbo].[Keluarga] (
    [idkeluarga]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [idreff]       BIGINT         NULL,
    [tablereff]    VARCHAR (50)   NULL,
    [nama]         VARCHAR (300)  NULL,
    [familytype]   BIGINT         NULL,
    [isdeleted]    BIGINT         NULL,
    [hashcode]     VARCHAR (1000) DEFAULT ('-') NOT NULL,
    [createdby]    BIGINT         NULL,
    [createddate]  DATETIME       NULL,
    [updatedby]    BIGINT         NULL,
    [updateddate]  DATETIME       NULL,
    [idcompany]    BIGINT         DEFAULT ((0)) NOT NULL,
    [pendidikan]   BIGINT         DEFAULT ((0)) NOT NULL,
    [kotalahir]    BIGINT         DEFAULT ((0)) NOT NULL,
    [tanggallahir] DATE           NULL,
    [pekerjaan]    BIGINT         DEFAULT ((0)) NOT NULL,
    [remarks]      VARCHAR (2000) DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idkeluarga] ASC)
);



