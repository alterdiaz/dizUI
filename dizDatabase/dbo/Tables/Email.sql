CREATE TABLE [dbo].[Email] (
    [idemail]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [idreff]      BIGINT       DEFAULT ((0)) NOT NULL,
    [tablereff]   VARCHAR (50) DEFAULT ('-') NOT NULL,
    [email]       VARCHAR (50) DEFAULT ('-') NOT NULL,
    [emailtype]   BIGINT       DEFAULT ((0)) NOT NULL,
    [isdeleted]   BIGINT       DEFAULT ((0)) NOT NULL,
    [isprimary]   BIGINT       DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT       DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME     DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT       NULL,
    [updateddate] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([idemail] ASC)
);

