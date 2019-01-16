CREATE TABLE [dbo].[sys_Images] (
    [idimages]   BIGINT           IDENTITY (1, 1) NOT NULL,
    [datetime]   DATETIME         NOT NULL,
    [images]     VARBINARY (MAX) filestream  NOT NULL,
    [filename]   VARCHAR (500)    NOT NULL,
    [sizewidth]  INT              NOT NULL,
    [sizeheight] INT              NOT NULL,
    [guid]       UNIQUEIDENTIFIER DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    PRIMARY KEY CLUSTERED ([idimages] ASC),
    CONSTRAINT [sys_Images_uq] UNIQUE NONCLUSTERED ([guid] ASC)
) FILESTREAM_ON [POS];

