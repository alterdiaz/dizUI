CREATE TABLE [dbo].[Staff] (
    [idstaff]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [idposition]      BIGINT         DEFAULT ((0)) NOT NULL,
    [iddepartment]    BIGINT         DEFAULT ((0)) NOT NULL,
    [idunit]          BIGINT         DEFAULT ((0)) NOT NULL,
    [idabsensi]       BIGINT         NULL,
    [iduser]          BIGINT         NULL,
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
    [idcompany]       BIGINT         DEFAULT ((0)) NOT NULL,
    [namapanggilan]   VARCHAR (50)   DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idstaff] ASC)
);




GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'id dari mesin absensi', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Staff', @level2type = N'COLUMN', @level2name = N'idabsensi';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'id user', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Staff', @level2type = N'COLUMN', @level2name = N'iduser';

