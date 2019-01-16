CREATE TABLE [dbo].[sys_MenuButton] (
    [idmenubutton] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idMenu]       BIGINT        NULL,
    [buttonName]   VARCHAR (30)  NULL,
    [Description]  VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([idmenubutton] ASC)
);

