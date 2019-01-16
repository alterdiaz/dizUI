CREATE TABLE [dbo].[sys_ClientUnit] (
    [idclientunit] BIGINT         IDENTITY (1, 1) NOT NULL,
    [ipclient]     VARCHAR (20)   NULL,
    [idunique]     VARCHAR (1000) NULL,
    PRIMARY KEY CLUSTERED ([idclientunit] ASC)
);

