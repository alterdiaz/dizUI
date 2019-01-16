CREATE TABLE [dbo].[sys_UserPermission] (
    [iduserpermission] BIGINT IDENTITY (1, 1) NOT NULL,
    [iduserlevel]      BIGINT NULL,
    [idmenu]           BIGINT NULL,
    [isactive]         BIGINT NULL,
    PRIMARY KEY CLUSTERED ([iduserpermission] ASC)
);

