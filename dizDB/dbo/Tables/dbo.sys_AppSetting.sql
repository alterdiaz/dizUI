CREATE TABLE [dbo].[sys_AppSetting] (
    [idappsetting] BIGINT         IDENTITY (1, 1) NOT NULL,
    [variable]     VARCHAR (2000) NOT NULL,
    [value]        VARCHAR (2000) NOT NULL,
    [valueReff]    VARCHAR (2000) DEFAULT ('') NULL,
    [idcompany]    BIGINT         DEFAULT ((0)) NOT NULL,
    [remarks]      VARCHAR (2000) DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idappsetting] ASC)
);

