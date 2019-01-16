CREATE TABLE [dbo].[SoapNoteDx] (
    [idsoapnotedx] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idsoapnote]   BIGINT        DEFAULT ((0)) NOT NULL,
    [iddiagnosa]   BIGINT        DEFAULT ((0)) NOT NULL,
    [deletereason] VARCHAR (300) DEFAULT ('-') NOT NULL,
    [isdeleted]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT        NULL,
    [updateddate]  DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idsoapnotedx] ASC)
);

