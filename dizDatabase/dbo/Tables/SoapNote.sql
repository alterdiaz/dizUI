CREATE TABLE [dbo].[SoapNote] (
    [idsoapnote]        BIGINT         IDENTITY (1, 1) NOT NULL,
    [idregistrasi]      BIGINT         DEFAULT ((0)) NOT NULL,
    [soapnoteno]        VARCHAR (20)   DEFAULT ('-') NOT NULL,
    [soapnotedate]      DATETIME       DEFAULT (getdate()) NOT NULL,
    [s-chiefcomplaint]  VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [a-diagnosakerja]   VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [a-diagnosabanding] VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [p-rencana]         VARCHAR (8000) DEFAULT ('-') NOT NULL,
    [hashcode]          VARCHAR (1000) DEFAULT ('-') NOT NULL,
    [isdeleted]         BIGINT         DEFAULT ((0)) NOT NULL,
    [deletereason]      VARCHAR (500)  DEFAULT ('-') NOT NULL,
    [createdby]         BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]       DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]         BIGINT         NULL,
    [updateddate]       DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([idsoapnote] ASC)
);

