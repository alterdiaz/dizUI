CREATE TABLE [dbo].[Unit] (
    [idunit]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [unit]        VARCHAR (150) NULL,
    [remarks]     VARCHAR (500) NULL,
    [isdeleted]   BIGINT        NULL,
    [createdby]   BIGINT        NULL,
    [createddate] DATETIME      NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    [kode]        VARCHAR (4)   DEFAULT ('-') NOT NULL,
    [kodeangka]   VARCHAR (4)   DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([idunit] ASC)
);

