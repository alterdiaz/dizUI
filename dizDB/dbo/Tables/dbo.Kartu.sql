CREATE TABLE [dbo].[Kartu] (
    [idkartu]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [idreff]        BIGINT       DEFAULT ((0)) NOT NULL,
    [tablereff]     VARCHAR (50) DEFAULT ('-') NOT NULL,
    [idpenerbit]    BIGINT       DEFAULT ((0)) NULL,
    [jenispenerbit] VARCHAR (50) DEFAULT ('-') NULL,
    [jeniskartu]    BIGINT       DEFAULT ((0)) NOT NULL,
    [nomorkartu]    VARCHAR (50) DEFAULT ('-') NOT NULL,
    [namakartu]     VARCHAR (50) DEFAULT ('-') NOT NULL,
    [jenistanggal]  BIGINT       CONSTRAINT [DF__Kartu__jenistang__753864A1] DEFAULT ((0)) NULL,
    [tanggalkartu]  DATE         CONSTRAINT [DF__Kartu__tanggalka__762C88DA] DEFAULT (NULL) NULL,
    [isdeleted]     BIGINT       DEFAULT ((0)) NOT NULL,
    [createdby]     BIGINT       DEFAULT ((0)) NOT NULL,
    [createddate]   DATETIME     DEFAULT (getdate()) NOT NULL,
    [updatedby]     BIGINT       NULL,
    [updateddate]   DATETIME     NULL,
    [idcompany]     BIGINT       DEFAULT ((0)) NOT NULL,
    [isprimary]     BIGINT       DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idkartu] ASC)
);



