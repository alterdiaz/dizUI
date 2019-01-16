CREATE TABLE [dbo].[Staff] (
    [idstaff]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [idposition]      BIGINT         DEFAULT ((0)) NOT NULL,
    [iddepartment]    BIGINT         DEFAULT ((0)) NOT NULL,
    [idunit]          BIGINT         DEFAULT ((0)) NOT NULL,
    [iduser]          BIGINT         DEFAULT ((0)) NOT NULL,
    [nik]             VARCHAR (30)   DEFAULT ('-') NOT NULL,
    [nama]            VARCHAR (300)  DEFAULT ('-') NOT NULL,
    [jeniskelamin]    BIGINT         DEFAULT ((0)) NOT NULL,
    [stafftype]       BIGINT         DEFAULT ((0)) NOT NULL,
    [agama]           BIGINT         DEFAULT ((0)) NOT NULL,
    [kewarganegaraan] BIGINT         DEFAULT ((0)) NOT NULL,
    [kotalahir]       BIGINT         DEFAULT ((0)) NOT NULL,
    [tanggallahir]    DATE           DEFAULT (getdate()) NOT NULL,
    [hashcode]        VARCHAR (1000) DEFAULT ('-') NOT NULL,
    [isdeleted]       BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]       BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]     DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]       BIGINT         NULL,
    [updateddate]     DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idstaff] ASC)
);

