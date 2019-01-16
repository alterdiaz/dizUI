CREATE TABLE [dbo].[sys_AppFiles] (
    [idappfiles]  BIGINT           IDENTITY (1, 1) NOT NULL,
    [filename]    VARCHAR (2000)   NOT NULL,
    [appversion]  VARCHAR (20)     NOT NULL,
    [createddate] DATETIME         NOT NULL,
    [filebinary]  VARBINARY (MAX)  NOT NULL,
    [guid]        UNIQUEIDENTIFIER DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    PRIMARY KEY CLUSTERED ([idappfiles] ASC),
    UNIQUE NONCLUSTERED ([guid] ASC)
);

