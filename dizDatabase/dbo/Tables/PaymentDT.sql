CREATE TABLE [dbo].[PaymentDT] (
    [idpaymentdt]  BIGINT          IDENTITY (1, 1) NOT NULL,
    [idpayment]    BIGINT          NOT NULL,
    [idtransaksi]  BIGINT          NOT NULL,
    [totalpayment] DECIMAL (20, 2) NULL,
    PRIMARY KEY CLUSTERED ([idpaymentdt] ASC)
);

