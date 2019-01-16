CREATE TABLE [dbo].[sys_UserMessagesDT] (
    [idusermessagesdt] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idusermessageshd] BIGINT         DEFAULT ((0)) NOT NULL,
    [idsender]         BIGINT         DEFAULT ((0)) NOT NULL,
    [idreceiver]       BIGINT         DEFAULT ((0)) NOT NULL,
    [message]          VARCHAR (2000) DEFAULT ('-') NOT NULL,
    [messagestatus]    BIGINT         DEFAULT ((0)) NOT NULL,
    [messagedate]      DATETIME       DEFAULT (getdate()) NOT NULL,
    [isdeleted]        BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]        BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]      DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]        BIGINT         NULL,
    [updateddate]      DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idusermessagesdt] ASC)
);

