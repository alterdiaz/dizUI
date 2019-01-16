CREATE TABLE [dbo].[sys_AppSetting] (
    [idappsetting] BIGINT         IDENTITY (1, 1) NOT NULL,
    [variable]     VARCHAR (2000) NOT NULL,
    [value]        VARCHAR (2000) NOT NULL,
    [valueReff]    TEXT           NULL,
    PRIMARY KEY CLUSTERED ([idappsetting] ASC)
);

