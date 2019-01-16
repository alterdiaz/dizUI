CREATE TABLE [dbo].[Anggaran] (
    [idanggaran]   BIGINT          IDENTITY (1, 1) NOT NULL,
    [idcoa]        BIGINT          DEFAULT ((0)) NOT NULL,
    [anggarantype] BIGINT          DEFAULT ((0)) NOT NULL,
    [jumlahuang]   DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [periode]      VARCHAR (10)    DEFAULT (datepart(year,getdate())) NOT NULL,
    [isdeleted]    BIGINT          DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT          DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME        DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT          NULL,
    [updateddate]  DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([idanggaran] ASC)
);

