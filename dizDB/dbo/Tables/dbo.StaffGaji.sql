CREATE TABLE [dbo].[StaffGaji] (
    [idstaffgaji]    BIGINT          IDENTITY (1, 1) NOT NULL,
    [idstaff]        BIGINT          DEFAULT ((0)) NOT NULL,
    [idunit]         BIGINT          DEFAULT ((0)) NOT NULL,
    [iddepartment]   BIGINT          DEFAULT ((0)) NOT NULL,
    [idposition]     BIGINT          DEFAULT ((0)) NOT NULL,
    [idkomponengaji] BIGINT          DEFAULT ((0)) NOT NULL,
    [periode]        DATE            DEFAULT (getdate()) NOT NULL,
    [standartgaji]   DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [nominalgaji]    DECIMAL (20, 2) DEFAULT ((0)) NOT NULL,
    [isdeleted]      BIGINT          DEFAULT ((0)) NOT NULL,
    [createdby]      BIGINT          DEFAULT ((0)) NOT NULL,
    [createddate]    DATETIME        DEFAULT (getdate()) NOT NULL,
    [updatedby]      BIGINT          NULL,
    [updateddate]    DATETIME        NULL,
    [idcompany]      BIGINT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([idstaffgaji] ASC)
);

