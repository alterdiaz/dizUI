CREATE TABLE [dbo].[PaymentDT] (
    [idpaymentdt]  BIGINT          IDENTITY (1, 1) NOT NULL,
    [idpayment]    BIGINT          NOT NULL,
    [idtransaksi]  BIGINT          NOT NULL,
    [totalpayment] DECIMAL (20, 2) NULL,
    [idcompany]    BIGINT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idpaymentdt] ASC)
);

