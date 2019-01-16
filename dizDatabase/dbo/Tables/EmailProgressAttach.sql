CREATE TABLE [dbo].[EmailProgressAttach] (
    [idemailprogressattach] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idemailprogress]       BIGINT   DEFAULT ((0)) NOT NULL,
    [idfiles]               BIGINT   DEFAULT ((0)) NOT NULL,
    [isdeleted]             BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]             BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate]           DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]             BIGINT   NULL,
    [updateddate]           DATETIME NULL,
    PRIMARY KEY CLUSTERED ([idemailprogressattach] ASC)
);

