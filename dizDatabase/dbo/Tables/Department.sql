CREATE TABLE [dbo].[Department] (
    [iddepartment] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idparent]     BIGINT        DEFAULT ((0)) NOT NULL,
    [department]   VARCHAR (150) DEFAULT ('-') NOT NULL,
    [kode]         VARCHAR (4)   DEFAULT ('-') NOT NULL,
    [kodeangka]    VARCHAR (4)   DEFAULT ((0)) NOT NULL,
    [isdeleted]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT        NULL,
    [updateddate]  DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([iddepartment] ASC)
);

