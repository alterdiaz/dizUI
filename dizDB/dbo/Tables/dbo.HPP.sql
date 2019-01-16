CREATE TABLE [dbo].[HPP] (
    [idhpp]         BIGINT          IDENTITY (1, 1) NOT NULL,
    [iditem]        BIGINT          DEFAULT ((0)) NOT NULL,
    [deletereason]  VARCHAR (200)   DEFAULT ('-') NOT NULL,
    [isdeleted]     BIGINT          DEFAULT ((0)) NOT NULL,
    [startdate]     DATETIME        DEFAULT (getdate()) NOT NULL,
    [enddate]       DATETIME        NULL,
    [createdby]     BIGINT          DEFAULT ((0)) NOT NULL,
    [createddate]   DATETIME        DEFAULT (getdate()) NOT NULL,
    [updatedby]     BIGINT          NULL,
    [updateddate]   DATETIME        NULL,
    [idcompany]     BIGINT          DEFAULT ((0)) NOT NULL,
    [harga]         DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hppstatus]     BIGINT          DEFAULT ((0)) NOT NULL,
    [reviewedby]    BIGINT          NULL,
    [revieweddate]  DATETIME        NULL,
    [reviewedby2]   BIGINT          NULL,
    [revieweddate2] DATETIME        NULL,
    [reviewedby3]   BIGINT          NULL,
    [revieweddate3] DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([idhpp] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'transaksistatus di generalcode', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'HPP', @level2type = N'COLUMN', @level2name = N'hppstatus';

