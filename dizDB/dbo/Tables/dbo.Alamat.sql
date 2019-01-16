CREATE TABLE [dbo].[Alamat] (
    [idalamat]    BIGINT          IDENTITY (1, 1) NOT NULL,
    [idcompany]   BIGINT          DEFAULT ((0)) NOT NULL,
    [idreff]      BIGINT          DEFAULT ((0)) NOT NULL,
    [tablereff]   VARCHAR (50)    DEFAULT ('-') NOT NULL,
    [addresstype] BIGINT          DEFAULT ((0)) NOT NULL,
    [idnegara]    BIGINT          DEFAULT ((0)) NOT NULL,
    [idpropinsi]  BIGINT          DEFAULT ((0)) NULL,
    [idkabupaten] BIGINT          DEFAULT ((0)) NULL,
    [idkecamatan] BIGINT          DEFAULT ((0)) NULL,
    [idkelurahan] BIGINT          DEFAULT ((0)) NULL,
    [alamat]      VARCHAR (2000)  DEFAULT ('-') NOT NULL,
    [kodepos]     VARCHAR (10)    DEFAULT ((0)) NULL,
    [isdeleted]   BIGINT          DEFAULT ((0)) NOT NULL,
    [isprimary]   BIGINT          DEFAULT ((0)) NOT NULL,
    [latitude]    DECIMAL (11, 8) CONSTRAINT [DF__Alamat__latitude__1CB22475] DEFAULT ((0)) NOT NULL,
    [longitude]   DECIMAL (11, 8) CONSTRAINT [DF__Alamat__longitud__1DA648AE] DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT          DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME        DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT          NULL,
    [updateddate] DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([idalamat] ASC)
);

