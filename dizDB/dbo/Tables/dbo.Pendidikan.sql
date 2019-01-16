CREATE TABLE [dbo].[Pendidikan] (
    [idpendidikan] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idreff]       BIGINT         DEFAULT ((0)) NOT NULL,
    [tablereff]    VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [pendidikan]   BIGINT         DEFAULT ((0)) NOT NULL,
    [nomorijazah]  VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [nama]         VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [jurusan]      VARCHAR (100)  DEFAULT ('-') NOT NULL,
    [tahunmasuk]   DATE           DEFAULT (getdate()) NOT NULL,
    [tahunlulus]   DATE           DEFAULT (getdate()) NOT NULL,
    [nilaiakhir]   DECIMAL (5, 2) DEFAULT ((0)) NOT NULL,
    [isvalid]      BIGINT         DEFAULT ((0)) NOT NULL,
    [remarks]      VARCHAR (200)  DEFAULT ('-') NOT NULL,
    [isdeleted]    BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT         NULL,
    [updateddate]  DATETIME       NULL,
    [idcompany]    BIGINT         DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idpendidikan] ASC)
);

