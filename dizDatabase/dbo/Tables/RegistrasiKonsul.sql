CREATE TABLE [dbo].[RegistrasiKonsul] (
    [idregistrasikonsul]     BIGINT         IDENTITY (1, 1) NOT NULL,
    [idrekammedis]           BIGINT         DEFAULT ((0)) NOT NULL,
    [iddokterpengirim]       BIGINT         DEFAULT ((0)) NOT NULL,
    [iddokterkonsul]         BIGINT         DEFAULT ((0)) NOT NULL,
    [konsulformtype]         BIGINT         DEFAULT ((0)) NOT NULL,
    [konsulformdate]         DATETIME       DEFAULT (getdate()) NOT NULL,
    [konsuldate]             DATE           DEFAULT (getdate()) NOT NULL,
    [konsultype]             BIGINT         DEFAULT ((0)) NOT NULL,
    [registrasikonsulno]     VARCHAR (20)   DEFAULT ('-') NOT NULL,
    [registrasikonsulstatus] BIGINT         DEFAULT ((0)) NOT NULL,
    [remarks]                VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [urgenttype]             BIGINT         DEFAULT ((0)) NOT NULL,
    [deletereason]           VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [isdeleted]              BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]              BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]            DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]              BIGINT         NULL,
    [updateddate]            DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idregistrasikonsul] ASC)
);

