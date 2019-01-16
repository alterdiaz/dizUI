CREATE TABLE [dbo].[ProyekDT] (
    [idproyekdt]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [idproyek]     BIGINT         DEFAULT ((0)) NOT NULL,
    [iditem]       BIGINT         DEFAULT ((0)) NOT NULL,
    [isparent]     BIGINT         DEFAULT ((0)) NOT NULL,
    [isitem]       BIGINT         DEFAULT ((0)) NOT NULL,
    [qtydispose]   DECIMAL (8, 2) DEFAULT ((0)) NOT NULL,
    [qtydispose2]  DECIMAL (8, 2) NULL,
    [qtycharges]   DECIMAL (8, 2) DEFAULT ((0)) NOT NULL,
    [qtycharges2]  DECIMAL (8, 2) NULL,
    [nama]         VARCHAR (300)  DEFAULT ('-') NOT NULL,
    [isdeleted]    BIGINT         DEFAULT ((0)) NOT NULL,
    [deletereason] VARCHAR (200)  DEFAULT ('-') NOT NULL,
    [remarks]      VARCHAR (1000) DEFAULT ('-') NOT NULL,
    [createdby]    BIGINT         DEFAULT ((0)) NOT NULL,
    [createddate]  DATETIME       DEFAULT (getdate()) NOT NULL,
    [updatedby]    BIGINT         NULL,
    [updateddate]  DATETIME       NULL,
    [idcompany]    BIGINT         DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idproyekdt] ASC)
);

