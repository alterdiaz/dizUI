CREATE TABLE [dbo].[sys_AppEventCode] (
    [idappeventcode] BIGINT        IDENTITY (1, 1) NOT NULL,
    [appeventcode]   VARCHAR (50)  DEFAULT ('-') NOT NULL,
    [remarks]        VARCHAR (100) DEFAULT ('-') NOT NULL,
    [isdeleted]      BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]      BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]    DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]      BIGINT        NULL,
    [updateddate]    DATETIME      NULL,
    CONSTRAINT [PK__sys_AppE__54B6FBEA3EE80C3F] PRIMARY KEY CLUSTERED ([idappeventcode] ASC)
);

