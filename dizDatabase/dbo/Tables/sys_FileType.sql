CREATE TABLE [dbo].[sys_FileType] (
    [idfiletype]    BIGINT       IDENTITY (1, 1) NOT NULL,
    [filetype]      VARCHAR (50) NOT NULL,
    [fileextension] VARCHAR (50) NOT NULL,
    [isdeleted]     BIGINT       NOT NULL,
    [createdby]     BIGINT       NOT NULL,
    [createddate]   DATETIME     NOT NULL,
    [updatedby]     BIGINT       NULL,
    [updateddate]   DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([idfiletype] ASC)
);

