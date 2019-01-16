CREATE TABLE [dbo].[RencanaPelayanan] (
    [idrencanapelayanan]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [idregistrasi]         BIGINT         DEFAULT ((0)) NOT NULL,
    [rencanapelayananno]   VARCHAR (20)   DEFAULT ('-') NOT NULL,
    [rencanapelayanantype] BIGINT         DEFAULT ((0)) NOT NULL,
    [rencanapelayanandate] DATETIME       DEFAULT (getdate()) NOT NULL,
    [materiedukasi]        VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [isreviewed]           BIGINT         DEFAULT ((0)) NOT NULL,
    [namapenerima]         VARCHAR (300)  DEFAULT ('-') NOT NULL,
    [isdeleted]            BIGINT         DEFAULT ((0)) NOT NULL,
    [deletereason]         VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [createdby]            BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]          DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]            BIGINT         NULL,
    [updateddate]          DATETIME       NULL,
    [reviewedby]           BIGINT         NULL,
    [revieweddate]         DATETIME       NULL,
    [idcompany]            BIGINT         DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idrencanapelayanan] ASC)
);

