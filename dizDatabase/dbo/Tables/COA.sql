CREATE TABLE [dbo].[COA] (
    [idcoa]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [idtipecoa]   BIGINT        DEFAULT ((0)) NOT NULL,
    [coa]         VARCHAR (20)  CONSTRAINT [DF__COA__coa__1CA7377D] DEFAULT ((0)) NOT NULL,
    [remarks]     VARCHAR (500) DEFAULT ('-') NOT NULL,
    [posisidk]    BIGINT        DEFAULT ((0)) NOT NULL,
    [isdeleted]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT        NULL,
    [updateddate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idcoa] ASC),
    UNIQUE NONCLUSTERED ([coa] ASC)
);


GO
CREATE NONCLUSTERED INDEX [coatablecoa]
    ON [dbo].[COA]([coa] ASC);

