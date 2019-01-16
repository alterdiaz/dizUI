CREATE TABLE [dbo].[sys_HistoryPrinting] (
    [idhistoryprinting] BIGINT        IDENTITY (1, 1) NOT NULL,
    [idreff]            BIGINT        NULL,
    [tablename]         VARCHAR (200) NULL,
    [lastnumber]        BIGINT        NULL,
    [createdby]         BIGINT        NULL,
    [createddate]       DATETIME      NULL,
    [updatedby]         BIGINT        NULL,
    [updateddate]       DATETIME      NULL,
    [isprinted]         BIGINT        NULL,
    PRIMARY KEY CLUSTERED ([idhistoryprinting] ASC)
);

