CREATE TABLE [dbo].[sys_GeneralCode] (
    [idgeneralcode] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idproducttype] BIGINT        DEFAULT ((0)) NULL,
    [idgeneral]     BIGINT        NULL,
    [generalcode]   VARCHAR (100) NULL,
    [gctype]        VARCHAR (20)  NULL,
    [idpriority]    BIGINT        DEFAULT ((0)) NULL,
    [idreff]        BIGINT        DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([idgeneralcode] ASC)
);

