CREATE TABLE [dbo].[ScreenDT] (
    [idscreendt]  BIGINT   IDENTITY (1, 1) NOT NULL,
    [idscreen]    BIGINT   DEFAULT ((0)) NOT NULL,
    [idlokasi]    BIGINT   DEFAULT ((0)) NOT NULL,
    [isdeleted]   BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT   NULL,
    [updateddate] DATETIME NULL,
    [idcompany]   BIGINT   DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idscreendt] ASC)
);

