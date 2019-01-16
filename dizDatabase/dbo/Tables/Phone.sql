CREATE TABLE [dbo].[Phone] (
    [idphone]     BIGINT       IDENTITY (1, 1) NOT NULL,
    [idreff]      BIGINT       DEFAULT ((0)) NOT NULL,
    [tablereff]   VARCHAR (50) DEFAULT ('-') NOT NULL,
    [phone]       VARCHAR (30) DEFAULT ((0)) NOT NULL,
    [extension]   VARCHAR (10) DEFAULT ((0)) NOT NULL,
    [phonetype]   BIGINT       DEFAULT ((0)) NOT NULL,
    [isdeleted]   BIGINT       DEFAULT ((0)) NOT NULL,
    [isprimary]   BIGINT       DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT       DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME     DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT       NULL,
    [updateddate] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([idphone] ASC)
);

