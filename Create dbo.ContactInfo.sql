USE [ContactDetails]
GO

/****** Object: Table [dbo].[ContactInfo] Script Date: 4/26/2018 3:11:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactInfo] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [Name]         VARCHAR (50) NOT NULL,
    [phoneNumber]  VARCHAR (50) NOT NULL,
    [emailAddress] VARCHAR (50) NOT NULL
);


