CREATE TABLE [dbo].[RegistrasiKonsulDT] (
    [idregistrasikonsuldt] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idregistrasikonsul]   BIGINT         DEFAULT ((0)) NOT NULL,
    [iddokter]             BIGINT         DEFAULT ((0)) NOT NULL,
    [remarks]              VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [saran]                VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [tindakankhusus]       VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [rencanakonsuldate]    DATE           DEFAULT (getdate()) NOT NULL,
    [isdeleted]            BIGINT         DEFAULT ((0)) NOT NULL,
    [deletereason]         VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [createdby]            BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]          DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]            BIGINT         NULL,
    [updateddate]          DATETIME       NULL,
    [idcompany]            BIGINT         DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idregistrasikonsuldt] ASC)
);

