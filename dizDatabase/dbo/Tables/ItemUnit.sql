CREATE TABLE [dbo].[ItemUnit] (
    [iditemunit]   BIGINT          IDENTITY (1, 1) NOT NULL,
    [iddepartment] BIGINT          DEFAULT ((0)) NOT NULL,
    [idunit]       BIGINT          DEFAULT ((0)) NOT NULL,
    [iditem]       BIGINT          DEFAULT ((0)) NOT NULL,
    [qty]          DECIMAL (8, 2)  DEFAULT ((0)) NOT NULL,
    [idsatuan]     BIGINT          DEFAULT ((0)) NOT NULL,
    [qtycontent]   DECIMAL (8, 2)  DEFAULT ((0)) NOT NULL,
    [hargalama]    DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargaawal]    DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargappn]     DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargadisc]    DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargaakhir]   DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargasatuan]  DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargarata]    DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [remarks]      VARCHAR (100)   DEFAULT ('-') NOT NULL,
    [createdby]    BIGINT          DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME        DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT          NULL,
    [updateddate]  DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([iditemunit] ASC)
);

