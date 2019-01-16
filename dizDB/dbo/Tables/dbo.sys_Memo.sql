CREATE TABLE [dbo].[sys_Memo] (
    [idmemo]      BIGINT         IDENTITY (1, 1) NOT NULL,
    [memono]      VARCHAR (25)   DEFAULT ('-') NOT NULL,
    [memotype]    BIGINT         DEFAULT ((0)) NOT NULL,
    [judul]       VARCHAR (200)  DEFAULT ('-') NOT NULL,
    [konten]      VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT         NULL,
    [updateddate] DATETIME       NULL,
    [guid]        VARCHAR (1000) DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idmemo] ASC)
);

