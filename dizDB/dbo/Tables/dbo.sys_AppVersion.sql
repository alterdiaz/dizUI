CREATE TABLE [dbo].[sys_AppVersion] (
    [idappversion]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [appversion]       VARCHAR (20) NOT NULL,
    [appversionnumber] BIGINT       NOT NULL,
    [createddate]      DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([idappversion] ASC)
);

