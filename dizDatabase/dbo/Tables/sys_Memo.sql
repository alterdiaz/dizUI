CREATE TABLE [dbo].[sys_Memo] (
    [idmemo]      BIGINT         IDENTITY (1, 1) NOT NULL,
    [memono]      VARCHAR (25)   NOT NULL,
    [memotype]    BIGINT         NOT NULL,
    [judul]       VARCHAR (200)  NOT NULL,
    [konten]      VARCHAR (8000) NOT NULL,
    [isdeleted]   BIGINT         NOT NULL,
    [createdby]   BIGINT         NOT NULL,
    [createddate] DATETIME       NOT NULL,
    [updatedby]   BIGINT         NULL,
    [updateddate] DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idmemo] ASC)
);

