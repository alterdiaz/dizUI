CREATE TABLE [dbo].[sys_Menu] (
    [idmenu]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [idparent]      BIGINT        DEFAULT ((0)) NOT NULL,
    [idproducttype] BIGINT        DEFAULT ((0)) NOT NULL,
    [idiconmenu]    BIGINT        DEFAULT ((0)) NOT NULL,
    [menuname]      VARCHAR (60)  DEFAULT ('-') NOT NULL,
    [frmname]       VARCHAR (100) DEFAULT ('-') NOT NULL,
    [description]   VARCHAR (200) DEFAULT ('-') NOT NULL,
    [asdialog]      BIGINT        DEFAULT ((0)) NOT NULL,
    [bordercolor]   BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idmenu] ASC)
);

