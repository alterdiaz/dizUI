CREATE TABLE [dbo].[sys_UserNotifications] (
    [idusernotifications] BIGINT         IDENTITY (1, 1) NOT NULL,
    [iduser]              BIGINT         NOT NULL,
    [iduserlevel]         BIGINT         NOT NULL,
    [idreff]              BIGINT         NULL,
    [notification]        VARCHAR (8000) NOT NULL,
    [frmname]             VARCHAR (30)   NULL,
    PRIMARY KEY CLUSTERED ([idusernotifications] ASC)
);

