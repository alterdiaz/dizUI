CREATE TABLE [dbo].[sys_UserImages] (
    [iduserimages] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idimages]     BIGINT        NOT NULL,
    [iduser]       BIGINT        NOT NULL,
    [description]  VARCHAR (200) NOT NULL,
    [asprofile]    BIGINT        NOT NULL,
    [isdeleted]    BIGINT        NOT NULL,
    PRIMARY KEY CLUSTERED ([iduserimages] ASC)
);

