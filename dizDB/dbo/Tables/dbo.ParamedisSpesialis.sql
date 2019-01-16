CREATE TABLE [dbo].[ParamedisSpesialis] (
    [idparamedisspesialis] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idparamedis]          BIGINT        DEFAULT ((0)) NOT NULL,
    [idspesialis]          BIGINT        DEFAULT ((0)) NOT NULL,
    [remarks]              VARCHAR (300) DEFAULT ('-') NOT NULL,
    [isdeleted]            BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]            BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]          DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]            BIGINT        NULL,
    [updateddate]          DATETIME      NULL,
    [idcompany]            BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idparamedisspesialis] ASC)
);

