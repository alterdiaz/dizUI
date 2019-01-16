CREATE TABLE [dbo].[sys_IconMenu] (
    [idiconmenu] BIGINT          IDENTITY (1, 1) NOT NULL,
    [datetime]   DATETIME        NOT NULL,
    [imagesicon] VARBINARY (MAX) filestream  NOT NULL,
    [filename]   VARCHAR (500)   NOT NULL,
    [sizewidth]  INT             NOT NULL,
    [sizeheight] INT             NOT NULL,
	    [guid]       UNIQUEIDENTIFIER DEFAULT (newid()) ROWGUIDCOL NOT NULL,
    PRIMARY KEY CLUSTERED ([idiconmenu] ASC),
	CONSTRAINT [sys_IconMenu_uq] UNIQUE NONCLUSTERED ([guid] ASC)
) FILESTREAM_ON [POS];

