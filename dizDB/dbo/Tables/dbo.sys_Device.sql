CREATE TABLE [dbo].[sys_Device] (
    [iddevice]  BIGINT         IDENTITY (1, 1) NOT NULL,
    [device]    VARCHAR (50)   DEFAULT ('-') NOT NULL,
    [ipaddress] VARCHAR (20)   DEFAULT ('0.0.0.0') NOT NULL,
    [sharename] VARCHAR (1000) DEFAULT ('-') NOT NULL,
    PRIMARY KEY CLUSTERED ([iddevice] ASC)
);

