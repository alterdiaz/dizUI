CREATE TABLE [dbo].[SosialMedia] (
    [idsosialmedia]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [idreff]          BIGINT        DEFAULT ((0)) NOT NULL,
    [tablereff]       VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [sosialmedia]     VARCHAR (100) DEFAULT ('-') NOT NULL,
    [sosialmediatype] BIGINT        DEFAULT ((0)) NOT NULL,
    [isvalid]         BIGINT        DEFAULT ((0)) NOT NULL,
    [isdeleted]       BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]       BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]     DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]       BIGINT        NULL,
    [updateddate]     DATETIME      NULL,
    [idcompany]       BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idsosialmedia] ASC)
);

