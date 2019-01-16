CREATE TABLE [dbo].[RehabMedik] (
    [idrehabmedik] BIGINT        IDENTITY (1, 1) NOT NULL,
    [rehabmedik]   VARCHAR (100) CONSTRAINT [DF__TerapiFis__terap__5946FCC0] DEFAULT ('-') NOT NULL,
    [isdeleted]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]    BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT        NULL,
    [updateddate]  DATETIME      NULL,
    [idcompany]    BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idrehabmedik] ASC)
);

