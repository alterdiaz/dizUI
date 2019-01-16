CREATE TABLE [dbo].[Diagnosa] (
    [iddiagnosa]  BIGINT        IDENTITY (1, 1) NOT NULL,
    [idicd]       BIGINT        DEFAULT ((0)) NOT NULL,
    [diagnosa]    VARCHAR (200) DEFAULT ('-') NOT NULL,
    [remarks]     VARCHAR (200) DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([iddiagnosa] ASC)
);

