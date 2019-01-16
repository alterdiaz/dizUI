CREATE TABLE [dbo].[Vacation] (
    [idvacation]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [vacationdate] DATE          DEFAULT (getdate()) NOT NULL,
    [idjadwalsesi] BIGINT        DEFAULT ((0)) NOT NULL,
    [idreff]       BIGINT        DEFAULT ((0)) NOT NULL,
    [tablereff]    VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [idreff2]      BIGINT        DEFAULT ((0)) NOT NULL,
    [tablereff2]   VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [kehadiran]    BIGINT        DEFAULT ((0)) NOT NULL,
    [remarks]      VARCHAR (300) DEFAULT ('-') NOT NULL,
    [isdeleted]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT        NULL,
    [updateddate]  DATETIME      NULL,
    [idcompany]    BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idvacation] ASC)
);

