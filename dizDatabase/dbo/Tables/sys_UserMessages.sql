CREATE TABLE [dbo].[sys_UserMessages] (
    [idusermessages] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idsender]       BIGINT         NOT NULL,
    [idreceiver]     BIGINT         NOT NULL,
    [message]        VARCHAR (2000) NOT NULL,
    [sendingdate]    DATETIME       NOT NULL,
    [updateddate]    DATETIME       NULL,
    [isdeleted]      BIGINT         NOT NULL,
    [messagestatus]  BIGINT         NOT NULL,
    PRIMARY KEY CLUSTERED ([idusermessages] ASC)
);

