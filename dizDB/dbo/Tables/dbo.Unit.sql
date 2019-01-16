CREATE TABLE [dbo].[Unit] (
    [idunit]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [unit]        VARCHAR (150) NULL,
    [remarks]     VARCHAR (500) NULL,
    [isdeleted]   BIGINT        NULL,
    [createdby]   BIGINT        NULL,
    [createddate] DATETIME      NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    [kode]        VARCHAR (4)   CONSTRAINT [DF__Unit__kode__68F2894D] DEFAULT ('AAAA') NOT NULL,
    [kodeangka]   VARCHAR (4)   CONSTRAINT [DF__Unit__kodeangka__69E6AD86] DEFAULT ('0000') NOT NULL,
    [idcompany]   BIGINT        DEFAULT ((0)) NOT NULL,
    [alias]       VARCHAR (150) DEFAULT ('-') NOT NULL,
    [npwp]        VARCHAR (20)  DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idunit] ASC)
);

