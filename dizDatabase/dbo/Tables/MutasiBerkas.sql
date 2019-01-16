CREATE TABLE [dbo].[MutasiBerkas] (
    [idmutasiberkas]  BIGINT         IDENTITY (1, 1) NOT NULL,
    [idreff]          BIGINT         DEFAULT ((0)) NOT NULL,
    [tablereff]       VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [statusberkas]    VARCHAR (200)  DEFAULT ('-') NOT NULL,
    [usernameprocess] VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [fullnameprocess] VARCHAR (2000) DEFAULT ('-') NOT NULL,
    [remarks]         VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [isdeleted]       BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]       BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]     DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]       BIGINT         NULL,
    [updateddate]     DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idmutasiberkas] ASC)
);

