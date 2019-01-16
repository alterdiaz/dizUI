CREATE TABLE [dbo].[Device] (
    [iddevice]    BIGINT         IDENTITY (1, 1) NOT NULL,
    [idlokasi]    BIGINT         DEFAULT ((0)) NOT NULL,
    [device]      VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [devicepath]  VARCHAR (2000) DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT         NULL,
    [updateddate] DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([iddevice] ASC)
);

