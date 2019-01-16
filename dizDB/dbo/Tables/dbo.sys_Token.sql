CREATE TABLE [dbo].[sys_Token] (
    [idtoken]       BIGINT         NOT NULL,
    [idtokenonline] BIGINT         NOT NULL,
    [tokenkey1]     VARCHAR (100)  NOT NULL,
    [tokenkey2]     VARCHAR (100)  NOT NULL,
    [isdeleted]     BIGINT         NOT NULL,
    [deletereason]  VARCHAR (2000) NOT NULL,
    [createdby]     BIGINT         NOT NULL,
    [createdname]   VARCHAR (300)  NOT NULL,
    [createddate]   DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([idtoken] ASC)
);

