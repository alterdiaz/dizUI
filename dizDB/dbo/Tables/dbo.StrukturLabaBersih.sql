CREATE TABLE [dbo].[StrukturLabaBersih] (
    [idstrukturlababersih] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idcoa]                BIGINT   NOT NULL,
    [faktorlababersih]     BIGINT   NOT NULL,
    [isdeleted]            BIGINT   NOT NULL,
    [isturunan]            BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]            BIGINT   NOT NULL,
    [createddate]          DATETIME NOT NULL,
    [updatedby]            BIGINT   NULL,
    [updateddate]          DATETIME NULL,
    [idcompany]            BIGINT   DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idstrukturlababersih] ASC)
);

