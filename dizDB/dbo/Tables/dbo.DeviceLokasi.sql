CREATE TABLE [dbo].[DeviceLokasi] (
    [iddevicelokasi] BIGINT       IDENTITY (1, 1) NOT NULL,
    [iddevice]       BIGINT       DEFAULT ((0)) NOT NULL,
    [idlokasi]       BIGINT       DEFAULT ((0)) NOT NULL,
    [devicelokasi]   VARCHAR (50) DEFAULT ('-') NOT NULL,
    [isotomatis]     BIGINT       DEFAULT ((0)) NOT NULL,
    [isdeleted]      BIGINT       DEFAULT ((0)) NOT NULL,
    [createdby]      BIGINT       DEFAULT ((0)) NOT NULL,
    [createddate]    DATETIME     DEFAULT (getdate()) NOT NULL,
    [updatedby]      BIGINT       NULL,
    [updateddate]    DATETIME     NULL,
    [idcompany]      BIGINT       DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([iddevicelokasi] ASC)
);

