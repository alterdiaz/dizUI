CREATE TABLE [dbo].[sys_Archives] (
    [idarchives] BIGINT         IDENTITY (1, 1) NOT NULL,
    [tablename]  VARCHAR (2000) NOT NULL,
    [value]      VARCHAR (MAX)  NOT NULL,
    [action]     VARCHAR (20)   NOT NULL,
    [issent]     BIGINT         NOT NULL,
    [ischeck]    BIGINT         NOT NULL,
    PRIMARY KEY CLUSTERED ([idarchives] ASC)
);

