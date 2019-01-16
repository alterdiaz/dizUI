CREATE TABLE [dbo].[JadwalSesi] (
    [idjadwalsesi] BIGINT       IDENTITY (1, 1) NOT NULL,
    [idpriority]   BIGINT       DEFAULT ((0)) NOT NULL,
    [kode]         VARCHAR (4)  DEFAULT ('-') NOT NULL,
    [nama]         VARCHAR (15) DEFAULT ('-') NOT NULL,
    [jammulai]     TIME (7)     DEFAULT (CONVERT([varchar],getdate(),(108))) NOT NULL,
    [jamselesai]   TIME (7)     DEFAULT (CONVERT([varchar],getdate(),(108))) NOT NULL,
    [isdeleted]    BIGINT       DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT       DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME     DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT       NULL,
    [updateddate]  DATETIME     NULL,
    [idcompany]    BIGINT       DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idjadwalsesi] ASC)
);

