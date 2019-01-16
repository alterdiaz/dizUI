CREATE TABLE [dbo].[DraftPenilaianHD] (
    [iddraftpenilaianhd] BIGINT         IDENTITY (1, 1) NOT NULL,
    [idposition]         BIGINT         DEFAULT ((0)) NOT NULL,
    [iddepartment]       BIGINT         DEFAULT ((0)) NOT NULL,
    [idunit]             BIGINT         DEFAULT ((0)) NOT NULL,
    [draftpenilaianno]   VARCHAR (20)   DEFAULT ('-') NOT NULL,
    [draftpenilaiandate] DATETIME       DEFAULT (getdate()) NOT NULL,
    [nilaimaksimum]      DECIMAL (4, 2) DEFAULT ((0)) NOT NULL,
    [isdeleted]          BIGINT         DEFAULT ((0)) NOT NULL,
    [createdby]          BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]        DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]          BIGINT         NULL,
    [updateddate]        DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([iddraftpenilaianhd] ASC)
);

