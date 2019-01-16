CREATE TABLE [dbo].[sys_Files] (
    [idfiles]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [filename]      VARCHAR (2000)  NOT NULL,
    [fileextension] VARCHAR (50)    NOT NULL,
    [filebinary]    VARBINARY (MAX) NOT NULL,
    [createddate]   DATETIME        NOT NULL,
    [guid]          VARCHAR (1000)  DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idfiles] ASC)
);

