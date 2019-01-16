CREATE TABLE [dbo].[sys_Files] (
    [idfiles]       BIGINT           IDENTITY (1, 1) NOT NULL,
    [filename]      VARCHAR (2000)   NOT NULL,
    [createddate]   DATETIME         NOT NULL,
    [filebinary]    VARBINARY (MAX)  filestream NOT NULL,
    [fileextension] VARCHAR (50)     NOT NULL,
    [guid]          UNIQUEIDENTIFIER DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    PRIMARY KEY CLUSTERED ([idfiles] ASC),
    CONSTRAINT [sys_Files_uq] UNIQUE NONCLUSTERED ([guid] ASC)
) FILESTREAM_ON [POS];

