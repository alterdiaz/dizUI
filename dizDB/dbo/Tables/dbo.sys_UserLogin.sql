CREATE TABLE [dbo].[sys_UserLogin] (
    [iduserlogin] BIGINT        IDENTITY (1, 1) NOT NULL,
    [createddate] DATETIME      NULL,
    [createdby]   BIGINT        NULL,
    [ipclient]    VARCHAR (20)  NULL,
    [hostname]    VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([iduserlogin] ASC)
);

