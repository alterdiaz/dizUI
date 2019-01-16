CREATE TABLE [dbo].[StrukturLaporanNeracaDT] (
    [idstrukturlaporanneracadt] BIGINT IDENTITY (1, 1) NOT NULL,
    [idstrukturlaporanneraca]   BIGINT NOT NULL,
    [idcoa]                     BIGINT NOT NULL,
    [faktoraruskas]             BIGINT NOT NULL,
    [isdeleted]                 BIGINT NOT NULL,
    [isturunan]                 BIGINT DEFAULT ((0)) NOT NULL,
    [idcompany]                 BIGINT DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idstrukturlaporanneracadt] ASC)
);

