﻿CREATE TABLE [dbo].[ItemLog] (
    [iditemlog]    BIGINT          IDENTITY (1, 1) NOT NULL,
    [iditem]       BIGINT          DEFAULT ((0)) NOT NULL,
    [idunit]       BIGINT          DEFAULT ((0)) NOT NULL,
    [iddepartment] BIGINT          DEFAULT ((0)) NOT NULL,
    [idreff]       BIGINT          DEFAULT ((0)) NOT NULL,
    [tbreff]       VARCHAR (50)    DEFAULT ('-') NOT NULL,
    [idreff2]      BIGINT          DEFAULT ((0)) NOT NULL,
    [tbreff2]      VARCHAR (50)    DEFAULT ('-') NOT NULL,
    [noreff]       VARCHAR (50)    DEFAULT ('-') NOT NULL,
    [trfreff]      VARCHAR (50)    DEFAULT ('-') NOT NULL,
    [qty]          DECIMAL (8, 2)  CONSTRAINT [DF__ItemLog__qty__1F2F69C4] DEFAULT ((0)) NOT NULL,
    [idsatuan]     BIGINT          DEFAULT ((0)) NOT NULL,
    [io]           VARCHAR (3)     DEFAULT ('-') NOT NULL,
    [hargalama]    DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargaawal]    DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargadisc]    DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargaakhir]   DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [hargarata]    DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [remarks]      VARCHAR (20)    DEFAULT ('-') NOT NULL,
    [createdby]    BIGINT          DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME        DEFAULT (getdate()) NOT NULL,
    [idcompany]    BIGINT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([iditemlog] ASC)
);
