CREATE TABLE [dbo].[DraftPenilaianDT] (
    [iddraftpenilaiandt] BIGINT         IDENTITY (1, 1) NOT NULL,
    [iddraftpenilaianhd] BIGINT         DEFAULT ((0)) NOT NULL,
    [idheader]           BIGINT         DEFAULT ((0)) NOT NULL,
    [idpriority]         BIGINT         DEFAULT ((0)) NOT NULL,
    [kompetensi]         VARCHAR (2000) DEFAULT ('-') NOT NULL,
    [bobotnilai]         DECIMAL (4, 2) DEFAULT ((0)) NOT NULL,
    [isdeleted]          BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]          BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]        DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]          BIGINT         NULL,
    [updateddate]        DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([iddraftpenilaiandt] ASC)
);

