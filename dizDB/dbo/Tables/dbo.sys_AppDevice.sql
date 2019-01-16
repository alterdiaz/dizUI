CREATE TABLE [dbo].[sys_AppDevice] (
    [idappdevice]    BIGINT        IDENTITY (1, 1) NOT NULL,
    [iddevice]       BIGINT        DEFAULT ((0)) NOT NULL,
    [parameter]      VARCHAR (50)  DEFAULT ('') NOT NULL,
    [isdeleted]      BIGINT        DEFAULT ((0)) NOT NULL,
    [remarks]        VARCHAR (300) DEFAULT ('-') NOT NULL,
    [createdby]      BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]    DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]      BIGINT        NULL,
    [updateddate]    DATETIME      NULL,
    [idcompany]      BIGINT        DEFAULT ((0)) NOT NULL,
    [idappeventcode] BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idappdevice] ASC)
);

