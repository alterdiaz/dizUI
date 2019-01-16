CREATE TABLE [dbo].[BusinessPartner] (
    [idbusinesspartner]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [businesspartnertype] BIGINT        DEFAULT ((0)) NOT NULL,
    [idreff]              BIGINT        DEFAULT ((0)) NOT NULL,
    [tablereff]           VARCHAR (20)  DEFAULT ('-') NOT NULL,
    [kode]                VARCHAR (20)  DEFAULT ('-') NOT NULL,
    [nama]                VARCHAR (500) DEFAULT ('-') NOT NULL,
    [paymenttype]         BIGINT        DEFAULT ((0)) NOT NULL,
    [companytype]         BIGINT        DEFAULT ((0)) NOT NULL,
    [remarks]             VARCHAR (200) DEFAULT ('-') NOT NULL,
    [isdeleted]           BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]           BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]         DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]           BIGINT        NULL,
    [updateddate]         DATETIME      NULL,
    [idcompany]           BIGINT        DEFAULT ((0)) NOT NULL,
    [duedatetype]         BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idbusinesspartner] ASC)
);



