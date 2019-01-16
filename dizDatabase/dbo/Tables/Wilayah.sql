CREATE TABLE [dbo].[Wilayah] (
    [idwilayah]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [idparent]       BIGINT        NULL,
    [idlevelwilayah] BIGINT        NULL,
    [wilayah]        VARCHAR (300) NULL,
    [kodepos]        VARCHAR (10)  NULL,
    [kodewilayah]    VARCHAR (50)  NULL,
    [isdeleted]      BIGINT        NULL,
    [createdby]      BIGINT        NULL,
    [createddate]    DATETIME      NULL,
    [updatedby]      BIGINT        NULL,
    [updateddate]    DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idwilayah] ASC)
);

