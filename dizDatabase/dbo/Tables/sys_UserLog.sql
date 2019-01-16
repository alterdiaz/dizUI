CREATE TABLE [dbo].[sys_UserLog] (
    [iduserlog]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [remarks]     VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [tablename]   VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [ipclient]    VARCHAR (20)   DEFAULT ('0.0.0.0') NOT NULL,
    [hostname]    VARCHAR (100)  DEFAULT ('-') NOT NULL,
    [createdby]   BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME       DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([iduserlog] ASC)
);

