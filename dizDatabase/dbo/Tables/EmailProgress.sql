CREATE TABLE [dbo].[EmailProgress] (
    [idemailprogress] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idreff]          BIGINT         DEFAULT ((0)) NOT NULL,
    [tablereff]       VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [emailaddress]    VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [emailsubject]    VARCHAR (100)  DEFAULT ('-') NOT NULL,
    [emailcontent]    VARCHAR (4000) DEFAULT ('-') NOT NULL,
    [isdeleted]       BIGINT         DEFAULT ((0)) NOT NULL,
    [issent]          BIGINT         DEFAULT ((0)) NOT NULL,
    [senddate]        DATETIME       DEFAULT (getdate()) NOT NULL,
    [sentdate]        DATETIME       NULL,
    [createdby]       BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]     DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]       BIGINT         NULL,
    [updateddate]     DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idemailprogress] ASC)
);

