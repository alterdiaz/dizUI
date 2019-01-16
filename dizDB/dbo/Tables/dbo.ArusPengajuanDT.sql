CREATE TABLE [dbo].[ArusPengajuanDT] (
    [idaruspengajuandt] BIGINT          IDENTITY (1, 1) NOT NULL,
    [idaruspengajuan]   BIGINT          DEFAULT ((0)) NOT NULL,
    [idbank]            BIGINT          DEFAULT ((0)) NOT NULL,
    [idpengajuan]       BIGINT          DEFAULT ((0)) NOT NULL,
    [idcoa]             BIGINT          DEFAULT ((0)) NOT NULL,
    [idunit]            BIGINT          DEFAULT ((0)) NOT NULL,
    [nomorurut]         VARCHAR (20)    DEFAULT ('-') NOT NULL,
    [keperluan]         VARCHAR (5000)  DEFAULT ('-') NOT NULL,
    [nodokumen]         VARCHAR (250)   DEFAULT ('-') NOT NULL,
    [jumlahuang]        DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [posisidk]          BIGINT          DEFAULT ((0)) NOT NULL,
    [isdeleted]         BIGINT          DEFAULT ((0)) NOT NULL,
    [deletereason]      VARCHAR (500)   DEFAULT ('-') NOT NULL,
    [idcompany]         BIGINT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idaruspengajuandt] ASC)
);

