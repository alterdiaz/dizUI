CREATE TABLE [dbo].[Paramedis] (
    [idparamedis]     BIGINT         IDENTITY (1, 1) NOT NULL,
    [iduser]          BIGINT         DEFAULT ((0)) NULL,
    [nama]            VARCHAR (300)  DEFAULT ('-') NOT NULL,
    [jeniskelamin]    BIGINT         DEFAULT ((0)) NOT NULL,
    [paramedistype]   BIGINT         DEFAULT ((0)) NOT NULL,
    [agama]           BIGINT         DEFAULT ((0)) NOT NULL,
    [kewarganegaraan] BIGINT         DEFAULT ((0)) NOT NULL,
    [kotalahir]       BIGINT         DEFAULT ((0)) NOT NULL,
    [tanggallahir]    DATE           DEFAULT (getdate()) NOT NULL,
    [hashcode]        VARCHAR (1000) DEFAULT ('-') NOT NULL,
    [isservice]       BIGINT         DEFAULT ((0)) NOT NULL,
    [isdeleted]       BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]       BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]     DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]       BIGINT         NULL,
    [updateddate]     DATETIME       NULL,
    [idcompany]       BIGINT         DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idparamedis] ASC)
);



