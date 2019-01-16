CREATE TABLE [dbo].[Kartu] (
    [idkartu]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [idreff]        BIGINT       DEFAULT ((0)) NOT NULL,
    [tablereff]     VARCHAR (50) DEFAULT ('-') NOT NULL,
    [idpenerbit]    BIGINT       DEFAULT ((0)) NULL,
    [jenispenerbit] VARCHAR (50) DEFAULT ('-') NULL,
    [jeniskartu]    BIGINT       DEFAULT ((0)) NOT NULL,
    [nomorkartu]    VARCHAR (50) DEFAULT ('-') NOT NULL,
    [namakartu]     VARCHAR (50) DEFAULT ('-') NOT NULL,
    [jenistanggal]  BIGINT       DEFAULT ((0)) NOT NULL,
    [tanggalkartu]  DATE         DEFAULT (getdate()) NOT NULL,
    [isdeleted]     BIGINT       DEFAULT ((0)) NOT NULL,
    [createdby]     BIGINT       DEFAULT ((0)) NOT NULL,
    [createddate]   DATETIME     DEFAULT (getdate()) NOT NULL,
    [updatedby]     BIGINT       NULL,
    [updateddate]   DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([idkartu] ASC)
);

