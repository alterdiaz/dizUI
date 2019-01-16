CREATE TABLE [dbo].[AssessmentList] (
    [idassessmentlist]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [idregistrasi]       BIGINT        DEFAULT ((0)) NOT NULL,
    [assessmentlisttype] BIGINT        DEFAULT ((0)) NOT NULL,
    [idlist]             BIGINT        DEFAULT ((0)) NOT NULL,
    [list]               VARCHAR (200) DEFAULT ('-') NOT NULL,
    [isdeleted]          BIGINT        DEFAULT ((0)) NOT NULL,
    [createdby]          BIGINT        DEFAULT ((0)) NOT NULL,
    [createddate]        DATETIME      DEFAULT (getdate()) NOT NULL,
    [updatedby]          BIGINT        NULL,
    [updateddate]        DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([idassessmentlist] ASC)
);

