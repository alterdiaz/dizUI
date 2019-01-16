CREATE TABLE [dbo].[TransactionType] (
    [idtransactiontype] BIGINT       IDENTITY (1, 1) NOT NULL,
    [iddepartment]      BIGINT       DEFAULT ((0)) NOT NULL,
    [idunit]            BIGINT       DEFAULT ((0)) NOT NULL,
    [kodetransaksi]     VARCHAR (6)  NOT NULL,
    [jenistransaksi]    VARCHAR (50) NOT NULL,
    [formatstring]      VARCHAR (20) NOT NULL,
    [formatperiode]     VARCHAR (20) NOT NULL,
    [positionnumber]    VARCHAR (10) NOT NULL,
    [digitnumber]       INT          NOT NULL,
    [idcompany]         BIGINT       DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idtransactiontype] ASC)
);

