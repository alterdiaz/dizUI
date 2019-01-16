CREATE TABLE [dbo].[sys_UserMessagesHD] (
    [idusermessageshd] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idsender]         BIGINT         DEFAULT ((0)) NOT NULL,
    [idreceiver]       BIGINT         DEFAULT ((0)) NOT NULL,
    [messagetitle]     VARCHAR (200)  DEFAULT ('-') NOT NULL,
    [remarks]          VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [isgroupmessage]   BIGINT         DEFAULT ((0)) NOT NULL,
    [isdeleted]        BIGINT         DEFAULT ((0)) NOT NULL,
    [lastby]           BIGINT         DEFAULT ((0)) NOT NULL,
    [lastdate]         DATETIME       DEFAULT (getdate()) NOT NULL,
    [lastmessage]      VARCHAR (2000) DEFAULT ('-') NOT NULL,
    [ismessagenew]     BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]        BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]      DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]        BIGINT         NULL,
    [updateddate]      DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idusermessageshd] ASC)
);

