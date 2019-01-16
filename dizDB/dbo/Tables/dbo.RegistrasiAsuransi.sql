CREATE TABLE [dbo].[RegistrasiAsuransi] (
    [idregistrasiasuransi] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idregistrasi]         BIGINT        DEFAULT ((0)) NOT NULL,
    [idbusinesspartner]    BIGINT        DEFAULT ((0)) NOT NULL,
    [remarks]              VARCHAR (300) DEFAULT ('-') NOT NULL,
    [isdeleted]            BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]            BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]          DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]            BIGINT        NULL,
    [updateddate]          DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idregistrasiasuransi] ASC)
);

