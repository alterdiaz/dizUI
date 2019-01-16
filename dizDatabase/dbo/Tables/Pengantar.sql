CREATE TABLE [dbo].[Pengantar] (
    [idpengantar] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idreff]      BIGINT        NULL,
    [tablereff]   VARCHAR (50)  NULL,
    [nama]        VARCHAR (300) NULL,
    [isprimary]   BIGINT        NULL,
    [isdeleted]   BIGINT        NULL,
    [createdby]   BIGINT        NULL,
    [createddate] DATETIME      NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idpengantar] ASC)
);

