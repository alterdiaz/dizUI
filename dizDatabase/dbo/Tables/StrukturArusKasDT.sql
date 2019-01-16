CREATE TABLE [dbo].[StrukturArusKasDT] (
    [idstrukturaruskasdt] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idstrukturaruskas]   BIGINT        NOT NULL,
    [idcoa]               BIGINT        NOT NULL,
    [captionaruskas]      VARCHAR (100) NOT NULL,
    [faktoraruskas]       BIGINT        NOT NULL,
    [isdeleted]           BIGINT        NOT NULL,
    [isturunan]           BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]           BIGINT        NOT NULL,
    [createddate]         DATETIME      NOT NULL,
    [updatedby]           BIGINT        NULL,
    [updateddate]         DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idstrukturaruskasdt] ASC)
);

