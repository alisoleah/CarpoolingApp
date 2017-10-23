CREATE TABLE [dbo].[Users]
(
    [Id]       INT        IDENTITY (1, 1) NOT NULL,
    [name]     NCHAR (10) NULL,
    [username] NCHAR (10) NULL,
    [password] NCHAR (10) NULL,
    [longlat]  NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
