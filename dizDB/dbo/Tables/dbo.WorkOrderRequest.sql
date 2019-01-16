CREATE TABLE [dbo].[WorkOrderRequest] (
    [idworkorderrequest] BIGINT        IDENTITY (1, 1) NOT NULL,
    [workorderrequestno] VARCHAR (20)  DEFAULT ('-') NOT NULL,
    [iddepartment]       BIGINT        DEFAULT ((0)) NOT NULL,
    [idunit]             BIGINT        DEFAULT ((0)) NOT NULL,
    [remarks]            VARCHAR (200) DEFAULT ('-') NOT NULL,
    [rating]             INT           DEFAULT ((0)) NOT NULL,
    [isdeleted]          BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]          BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]        DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]          BIGINT        NULL,
    [updateddate]        DATETIME      NULL,
    [idcompany]          BIGINT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idworkorderrequest] ASC)
);

