CREATE TABLE [dbo].[ItemHarga] (
    [iditemharga] BIGINT          IDENTITY (1, 1) NOT NULL,
    [iditem]      BIGINT          DEFAULT ((0)) NOT NULL,
    [hargalama]   DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargaawal]   DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargappn]    DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargadisc]   DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargaakhir]  DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [startdate]   DATE            DEFAULT (getdate()) NOT NULL,
    [enddate]     DATE            NULL,
    [isdeleted]   BIGINT          DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT          DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME        DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT          NULL,
    [updateddate] DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([iditemharga] ASC)
);

