CREATE TABLE [dbo].[Deposit] (
    [iddeposit]     BIGINT          IDENTITY (1, 1) NOT NULL,
    [idreff]        BIGINT          DEFAULT ((0)) NOT NULL,
    [tbreff]        VARCHAR (100)   DEFAULT ('-') NOT NULL,
    [deposittype]   BIGINT          DEFAULT ((0)) NOT NULL,
    [depositno]     VARCHAR (20)    DEFAULT ((0)) NOT NULL,
    [depositamount] DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [remarks]       VARCHAR (200)   DEFAULT ('-') NOT NULL,
    [totalcash]     DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [totalcc]       DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [totaldc]       DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [totaltrf]      DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [isdeleted]     BIGINT          DEFAULT ((0)) NOT NULL,
    [createdby]     BIGINT          DEFAULT ((0)) NOT NULL,
    [createddate]   DATETIME        DEFAULT (getdate()) NOT NULL,
    [updatedby]     BIGINT          NULL,
    [updateddate]   DATETIME        NULL,
    [idcompany]     BIGINT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([iddeposit] ASC)
);

