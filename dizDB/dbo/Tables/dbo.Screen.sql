CREATE TABLE [dbo].[Screen] (
    [idscreen]    BIGINT        IDENTITY (1, 1) NOT NULL,
    [nama]        VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [ipclient]    VARCHAR (20)  DEFAULT ('0.0.0.0') NOT NULL,
    [tls]         BIGINT        DEFAULT ((0)) NOT NULL,
    [ssl]         BIGINT        DEFAULT ((0)) NOT NULL,
    [username]    VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [password]    VARCHAR (100) DEFAULT ('-') NOT NULL,
    [screentype]  BIGINT        DEFAULT ((0)) NOT NULL,
    [isdeleted]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    [idcompany]   BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idscreen] ASC)
);

