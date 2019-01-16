﻿CREATE TABLE [dbo].[RekamMedis] (
    [idrekammedis]    BIGINT         IDENTITY (1, 1) NOT NULL,
    [rekammedisno]    BIGINT         DEFAULT ((0)) NOT NULL,
    [asalpx]          BIGINT         DEFAULT ((0)) NOT NULL,
    [asalpx2]         BIGINT         DEFAULT ((0)) NOT NULL,
    [asalrujukan]     BIGINT         DEFAULT ((0)) NOT NULL,
    [jeniskunjungan]  BIGINT         DEFAULT ((0)) NOT NULL,
    [iddokterrujukan] BIGINT         DEFAULT ((0)) NULL,
    [sapaan]          BIGINT         DEFAULT ((0)) NOT NULL,
    [namapanggilan]   VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [nama]            VARCHAR (300)  DEFAULT ('-') NOT NULL,
    [tanggallahir]    DATE           DEFAULT (getdate()) NOT NULL,
    [jeniskelamin]    BIGINT         DEFAULT ((0)) NOT NULL,
    [pekerjaan]       BIGINT         DEFAULT ((0)) NOT NULL,
    [pendidikan]      BIGINT         DEFAULT ((0)) NOT NULL,
    [kotalahir]       BIGINT         DEFAULT ((0)) NOT NULL,
    [pernikahan]      BIGINT         DEFAULT ((0)) NOT NULL,
    [agama]           BIGINT         DEFAULT ((0)) NOT NULL,
    [golongandarah]   BIGINT         DEFAULT ((0)) NOT NULL,
    [rhesus]          BIGINT         DEFAULT ((0)) NOT NULL,
    [kewarganegaraan] BIGINT         DEFAULT ((0)) NOT NULL,
    [hashcode]        VARCHAR (1000) DEFAULT ('-') NOT NULL,
    [ishamil]         BIGINT         DEFAULT ((0)) NOT NULL,
    [isdeleted]       BIGINT         DEFAULT ((0)) NOT NULL,
    [deletereason]    VARCHAR (200)  DEFAULT ('-') NOT NULL,
    [createdby]       BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]     DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]       BIGINT         NULL,
    [updateddate]     DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idrekammedis] ASC)
);

