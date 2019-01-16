CREATE TABLE [dbo].[ParamedisJadwal] (
    [idparamedisjadwal] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idparamedis]       BIGINT        DEFAULT ((0)) NOT NULL,
    [idsesi]            BIGINT        DEFAULT ((0)) NOT NULL,
    [idlokasi]          BIGINT        DEFAULT ((0)) NOT NULL,
    [hari]              VARCHAR (20)  DEFAULT ('-') NOT NULL,
    [tanggalmulai]      DATE          DEFAULT (getdate()) NOT NULL,
    [tanggalselesai]    DATE          DEFAULT (getdate()) NOT NULL,
    [jammulai]          TIME (7)      DEFAULT (CONVERT([varchar],getdate(),(108))) NOT NULL,
    [jamselesai]        TIME (7)      DEFAULT (CONVERT([varchar],getdate(),(108))) NOT NULL,
    [maxapp]            BIGINT        DEFAULT ((0)) NOT NULL,
    [durasi]            BIGINT        DEFAULT ((0)) NOT NULL,
    [isparamedissms]    BIGINT        DEFAULT ((0)) NOT NULL,
    [ispasiensms]       BIGINT        DEFAULT ((0)) NOT NULL,
    [ismonitor]         BIGINT        DEFAULT ((0)) NOT NULL,
    [remarks]           VARCHAR (300) DEFAULT ('-') NOT NULL,
    [isdeleted]         BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]         BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]       DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]         BIGINT        NULL,
    [updateddate]       DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idparamedisjadwal] ASC)
);

