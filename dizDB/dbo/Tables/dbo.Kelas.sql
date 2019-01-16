CREATE TABLE [dbo].[Kelas] (
    [idkelas]     BIGINT        IDENTITY (1, 1) NOT NULL,
    [idpriority]  BIGINT        DEFAULT ((0)) NOT NULL,
    [kelas]       VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [remarks]     VARCHAR (200) DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    [idcompany]   BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idkelas] ASC)
);

