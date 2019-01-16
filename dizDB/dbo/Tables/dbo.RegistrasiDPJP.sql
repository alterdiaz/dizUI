CREATE TABLE [dbo].[RegistrasiDPJP] (
    [idregistrasidpjp] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idregistrasi]     BIGINT        DEFAULT ((0)) NOT NULL,
    [idparamedis]      BIGINT        DEFAULT ((0)) NOT NULL,
    [idspesialis]      BIGINT        DEFAULT ((0)) NOT NULL,
    [dpjptype]         BIGINT        DEFAULT ((0)) NOT NULL,
    [isdeleted]        BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]        BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]      DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]        BIGINT        NULL,
    [updateddate]      DATETIME      NULL,
    [idcompany]        BIGINT        DEFAULT ((0)) NOT NULL,
    [remarks]          VARCHAR (500) DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idregistrasidpjp] ASC)
);

