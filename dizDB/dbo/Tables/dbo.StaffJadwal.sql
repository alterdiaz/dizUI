CREATE TABLE [dbo].[StaffJadwal] (
    [idstaffjadwal] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idstaff]       BIGINT   DEFAULT ((0)) NOT NULL,
    [idjadwalsesi]  BIGINT   DEFAULT ((0)) NOT NULL,
    [tanggal]       DATE     DEFAULT (getdate()) NOT NULL,
    [kehadiran]     BIGINT   DEFAULT ((0)) NOT NULL,
    [hadirdate]     DATETIME DEFAULT (getdate()) NOT NULL,
    [isdeleted]     BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]     BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate]   DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]     BIGINT   NULL,
    [updateddate]   DATETIME NULL,
    PRIMARY KEY CLUSTERED ([idstaffjadwal] ASC)
);

