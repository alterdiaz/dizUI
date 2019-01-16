CREATE TABLE [dbo].[StrukturArusKas] (
    [idstrukturaruskas]  BIGINT        IDENTITY (1, 1) NOT NULL,
    [createdby]          BIGINT        NOT NULL,
    [createddate]        DATETIME      NOT NULL,
    [nomorurut]          BIGINT        NOT NULL,
    [strukturaruskas]    VARCHAR (100) NOT NULL,
    [kondisiminus]       VARCHAR (20)  DEFAULT ('') NOT NULL,
    [kondisiplus]        VARCHAR (20)  DEFAULT ('') NOT NULL,
    [nomorsubtotalawal]  BIGINT        DEFAULT ((0)) NOT NULL,
    [nomorsubtotalakhir] BIGINT        DEFAULT ((0)) NOT NULL,
    [islababersih]       BIGINT        NOT NULL,
    [isdeleted]          BIGINT        NOT NULL,
    [updatedby]          BIGINT        NULL,
    [updateddate]        DATETIME      NULL,
    [idcompany]          BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idstrukturaruskas] ASC)
);

