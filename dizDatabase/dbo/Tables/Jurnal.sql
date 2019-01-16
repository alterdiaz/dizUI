CREATE TABLE [dbo].[Jurnal] (
    [idjurnal]      BIGINT          IDENTITY (1, 1) NOT NULL,
    [idcoalama]     BIGINT          NULL,
    [idcoa]         BIGINT          NULL,
    [idreff]        BIGINT          DEFAULT ((0)) NOT NULL,
    [tbreff]        VARCHAR (1000)  DEFAULT ('-') NOT NULL,
    [idunique]      VARCHAR (1000)  NULL,
    [idunit]        BIGINT          NULL,
    [tanggaljurnal] DATETIME        NULL,
    [jumlahuang]    DECIMAL (20, 2) NULL,
    [remarks]       VARCHAR (8000)  NULL,
    [nodokumen]     VARCHAR (250)   NULL,
    [posisidk]      BIGINT          NULL,
    [isdeleted]     BIGINT          NULL,
    [createdby]     BIGINT          NULL,
    [createddate]   DATETIME        NULL,
    [updatedby]     BIGINT          NULL,
    [updateddate]   DATETIME        NULL,
    [idreff2]       BIGINT          DEFAULT ((0)) NOT NULL,
    [tbreff2]       VARCHAR (1000)  DEFAULT ('-') NOT NULL,
    [nobukti]       VARCHAR (2000)  NULL,
    [issystem]      BIGINT          NULL,
    [jurnaltype]    BIGINT          NULL,
    PRIMARY KEY CLUSTERED ([idjurnal] ASC)
);


GO
CREATE NONCLUSTERED INDEX [idcoalamatablejurnal]
    ON [dbo].[Jurnal]([idcoalama] ASC);


GO
CREATE NONCLUSTERED INDEX [idcoatablejurnal]
    ON [dbo].[Jurnal]([idcoa] ASC);


GO
CREATE NONCLUSTERED INDEX [tanggaljurnaltablejurnal]
    ON [dbo].[Jurnal]([tanggaljurnal] ASC);

