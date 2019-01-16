CREATE TABLE [dbo].[MutasiStaff] (
    [idmutasistaff] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idstaff]       BIGINT        DEFAULT ((0)) NOT NULL,
    [idposition]    BIGINT        DEFAULT ((0)) NOT NULL,
    [iddepartment]  BIGINT        DEFAULT ((0)) NOT NULL,
    [idunit]        BIGINT        DEFAULT ((0)) NOT NULL,
    [stafftype]     BIGINT        DEFAULT ((0)) NOT NULL,
    [mutasino]      VARCHAR (20)  DEFAULT ('-') NOT NULL,
    [mutasidate]    DATE          DEFAULT (getdate()) NOT NULL,
    [remarks]       VARCHAR (500) DEFAULT ('-') NOT NULL,
    [isdeleted]     BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]     BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]   DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]     BIGINT        NULL,
    [updateddate]   DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idmutasistaff] ASC)
);

