CREATE TABLE [dbo].[Position] (
    [idposition]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [idpriority]   BIGINT       DEFAULT ((0)) NOT NULL,
    [position]     VARCHAR (30) DEFAULT ('-') NOT NULL,
    [isdeleted]    BIGINT       DEFAULT ((0)) NOT NULL,
    [positiontype] BIGINT       DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT       DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME     DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT       NULL,
    [updateddate]  DATETIME     NULL,
    [idcompany]    BIGINT       DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idposition] ASC)
);

