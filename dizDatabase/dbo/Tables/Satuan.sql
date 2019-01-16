CREATE TABLE [dbo].[Satuan] (
    [idsatuan]    BIGINT       IDENTITY (1, 1) NOT NULL,
    [satuan]      VARCHAR (20) DEFAULT ('-') NOT NULL,
    [isdeleted]   BIGINT       DEFAULT ((0)) NOT NULL,
    [createdby]   BIGINT       DEFAULT ((0)) NOT NULL,
    [createddate] DATETIME     DEFAULT (getdate()) NOT NULL,
    [updatedby]   BIGINT       NULL,
    [updateddate] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([idsatuan] ASC)
);

