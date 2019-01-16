CREATE TABLE [dbo].[ItemBOM] (
    [iditembom]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [iditem]      BIGINT         DEFAULT ((0)) NOT NULL,
    [qty]         DECIMAL (8, 2) DEFAULT ((0)) NOT NULL,
    [remarks]     VARCHAR (300)  DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT         NULL,
    [updateddate] DATETIME       NULL,
    [idcompany]   BIGINT         DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([iditembom] ASC)
);

