CREATE TABLE [dbo].[Wilayah] (
    [idwilayah]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [idparent]       BIGINT        DEFAULT ((0)) NULL,
    [idlevelwilayah] BIGINT        DEFAULT ((0)) NOT NULL,
    [wilayah]        VARCHAR (300) DEFAULT ('-') NOT NULL,
    [kodepos]        VARCHAR (10)  DEFAULT ((0)) NOT NULL,
    [kodewilayah]    VARCHAR (50)  DEFAULT ((0)) NOT NULL,
    [isdeleted]      BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]      BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]    DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]      BIGINT        NULL,
    [updateddate]    DATETIME      NULL,
    [idcompany]      BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idwilayah] ASC)
);



