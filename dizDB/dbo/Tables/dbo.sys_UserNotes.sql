CREATE TABLE [dbo].[sys_UserNotes] (
    [idusernotes]  BIGINT         IDENTITY (1, 1) NOT NULL,
    [iduser]       BIGINT         NOT NULL,
    [title]        VARCHAR (50)   NULL,
    [notes]        VARCHAR (3000) NOT NULL,
    [isnote]       BIGINT         NOT NULL,
    [isdeleted]    BIGINT         NOT NULL,
    [createddate]  DATETIME       NOT NULL,
    [updateddate]  DATETIME       NULL,
    [warningdate]  DATETIME       NULL,
    [iscomplete]   BIGINT         DEFAULT ((0)) NOT NULL,
    [completedate] DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idusernotes] ASC)
);



