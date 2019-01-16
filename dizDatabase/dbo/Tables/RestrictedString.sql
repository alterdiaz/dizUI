CREATE TABLE [dbo].[RestrictedString] (
    [idrestrictedstring] BIGINT        IDENTITY (1, 1) NOT NULL,
    [stringname]         VARCHAR (500) DEFAULT ('-') NOT NULL,
    [isdeleted]          BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]          BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]        DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]          BIGINT        NULL,
    [updateddate]        DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idrestrictedstring] ASC)
);

