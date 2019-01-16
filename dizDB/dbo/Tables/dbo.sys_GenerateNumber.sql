CREATE TABLE [dbo].[sys_GenerateNumber] (
    [idgeneratenumber] BIGINT        IDENTITY (1, 1) NOT NULL,
    [tablename]        VARCHAR (200) NULL,
    [formatstring]     VARCHAR (100) NULL,
    [lastnumber]       BIGINT        NULL,
    [positionnumber]   VARCHAR (10)  NULL,
    [digitnumber]      INT           NULL,
    PRIMARY KEY CLUSTERED ([idgeneratenumber] ASC)
);

