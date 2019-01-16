CREATE TABLE [dbo].[AssessmentRehab] (
    [idassessmentrehab] BIGINT   IDENTITY (1, 1) NOT NULL,
    [idregistrasi]      BIGINT   DEFAULT ((0)) NOT NULL,
    [idassessment]      BIGINT   DEFAULT ((0)) NOT NULL,
    [rehabmediktype]    BIGINT   DEFAULT ((0)) NOT NULL,
    [idicd]             BIGINT   DEFAULT ((0)) NOT NULL,
    [isdeleted]         BIGINT   DEFAULT ((0)) NOT NULL,
    [createdby]         BIGINT   DEFAULT ((0)) NOT NULL,
    [createddate]       DATETIME DEFAULT (getdate()) NOT NULL,
    [updatedby]         BIGINT   NULL,
    [updateddate]       DATETIME NULL,
    [idcompany]         BIGINT   DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idassessmentrehab] ASC)
);

