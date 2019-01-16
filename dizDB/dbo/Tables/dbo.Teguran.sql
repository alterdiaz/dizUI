CREATE TABLE [dbo].[Teguran] (
    [idteguran]      BIGINT         IDENTITY (1, 1) NOT NULL,
    [idunit]         BIGINT         DEFAULT ((0)) NOT NULL,
    [idreff]         BIGINT         DEFAULT ((0)) NOT NULL,
    [tablereff]      VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [teguranno]      VARCHAR (20)   DEFAULT ('-') NOT NULL,
    [tegurandate]    DATE           DEFAULT (getdate()) NOT NULL,
    [teguranduedate] DATE           DEFAULT (dateadd(month,(6),getdate())) NOT NULL,
    [tegurantype]    BIGINT         DEFAULT ((0)) NOT NULL,
    [remarks]        VARCHAR (2000) DEFAULT ('-') NOT NULL,
    [isdeleted]      BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]      BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]    DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]      BIGINT         NULL,
    [updateddate]    DATETIME       NULL,
    [idcompany]      BIGINT         DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idteguran] ASC)
);

