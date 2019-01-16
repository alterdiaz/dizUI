CREATE TABLE [dbo].[ItemHarga] (
    [iditemharga] BIGINT          IDENTITY (1, 1) NOT NULL,
    [idunit]      BIGINT          DEFAULT ((0)) NOT NULL,
    [iditem]      BIGINT          DEFAULT ((0)) NOT NULL,
    [idkelas]     BIGINT          DEFAULT ((0)) NOT NULL,
    [harga]       DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [startdate]   DATE            DEFAULT (getdate()) NOT NULL,
    [enddate]     DATE            DEFAULT (dateadd(day,(1),getdate())) NOT NULL,
    [remarks]     VARCHAR (500)   DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT          DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT          DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME        DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT          NULL,
    [updateddate] DATETIME        NULL,
    [idcompany]   BIGINT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([iditemharga] ASC)
);

