CREATE TABLE [dbo].[sys_News] (
    [idnews]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [idimages] BIGINT         NULL,
    [title]    VARCHAR (30)   NULL,
    [content]  VARCHAR (3000) NULL,
    [datetime] DATETIME       NULL,
    [position] SMALLINT       NULL,
    [response] DECIMAL (5, 2) NULL,
    PRIMARY KEY CLUSTERED ([idnews] ASC)
);

