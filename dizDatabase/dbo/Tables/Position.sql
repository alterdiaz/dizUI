CREATE TABLE [dbo].[Position] (
    [idposition]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [position]     VARCHAR (30) NULL,
    [isdeleted]    BIGINT       NULL,
    [positiontype] BIGINT       NULL,
    [createdby]    BIGINT       NULL,
    [createddate]  DATETIME     NULL,
    [updatedby]    BIGINT       NULL,
    [updateddate]  DATETIME     NULL,
    [idpriority]   BIGINT       NULL,
    PRIMARY KEY CLUSTERED ([idposition] ASC)
);

