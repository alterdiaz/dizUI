CREATE TABLE [dbo].[Payment] (
    [idpayment]     BIGINT          IDENTITY (1, 1) NOT NULL,
    [transaksitype] BIGINT          DEFAULT ((0)) NOT NULL,
    [paymentno]     VARCHAR (20)    NOT NULL,
    [remarks]       VARCHAR (500)   NOT NULL,
    [totalpayment]  DECIMAL (20, 2) NOT NULL,
    [paymentmethod] BIGINT          NOT NULL,
    [idbank]        BIGINT          NULL,
    [bankremarks]   VARCHAR (100)   NULL,
    [hashcode]      VARCHAR (1000)  NULL,
    [isdeleted]     BIGINT          NOT NULL,
    [createdby]     BIGINT          NOT NULL,
    [createddate]   DATETIME        NOT NULL,
    [updatedby]     BIGINT          NULL,
    [updateddate]   DATETIME        NULL,
    [totalcash]     DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [totalcc]       DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [totaldc]       DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [totaltrf]      DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [totalvch]      DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [idcompany]     BIGINT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idpayment] ASC)
);

