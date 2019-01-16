CREATE TABLE [dbo].[Alamat] (
    [idreff]      BIGINT         DEFAULT ((0)) NOT NULL,
    [tablereff]   VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [addresstype] BIGINT         DEFAULT ((0)) NOT NULL,
    [idnegara]    BIGINT         DEFAULT ((0)) NOT NULL,
    [idpropinsi]  BIGINT         DEFAULT ((0)) NULL,
    [idkabupaten] BIGINT         DEFAULT ((0)) NULL,
    [idkecamatan] BIGINT         DEFAULT ((0)) NULL,
    [idkelurahan] BIGINT         DEFAULT ((0)) NULL,
    [alamat]      VARCHAR (2000) DEFAULT ('-') NOT NULL,
    [kodepos]     VARCHAR (10)   DEFAULT ((0)) NULL,
    [isdeleted]   BIGINT         DEFAULT ((0)) NOT NULL,
    [isprimary]   BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT         NULL,
    [updateddate] DATETIME       NULL,
    [idalamat]    BIGINT         IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [Alamat_pk] PRIMARY KEY CLUSTERED ([idalamat] ASC)
);

