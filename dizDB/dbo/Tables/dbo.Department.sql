CREATE TABLE [dbo].[Department] (
    [iddepartment] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idparent]     BIGINT        DEFAULT ((0)) NOT NULL,
    [department]   VARCHAR (150) DEFAULT ('-') NOT NULL,
    [kode]         VARCHAR (4)   CONSTRAINT [DF__Department__kode__0E6E26BF] DEFAULT ('AAAA') NOT NULL,
    [kodeangka]    VARCHAR (4)   CONSTRAINT [DF__Departmen__kodea__0F624AF8] DEFAULT ('0000') NOT NULL,
    [isdeleted]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT        NULL,
    [updateddate]  DATETIME      NULL,
    [idcompany]    BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([iddepartment] ASC)
);

