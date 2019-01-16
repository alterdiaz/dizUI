CREATE TABLE [dbo].[sys_UserLevel] (
    [iduserlevel]  BIGINT       IDENTITY (1, 1) NOT NULL,
    [userlevel]    VARCHAR (20) DEFAULT ('-') NOT NULL,
    [userdata]     BIGINT       DEFAULT ((0)) NOT NULL,
    [issuperadmin] BIGINT       DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([iduserlevel] ASC)
);

