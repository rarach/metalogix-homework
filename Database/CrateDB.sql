﻿use [master];

create database [METALOGIX]
  collate Latin1_General_CS_AS;
go

--Tables
use [METALOGIX];

create table dbo.[COMPANY_TYPE]
(
	[ID] int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[NAME] nvarchar(50) NOT NULL,
	[DESCRIPTION] nvarchar(250) NULL
)
go

create table dbo.[COMPANY]
(
    [ID] int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[NAME] nvarchar(250) NOT NULL,
	[COUNTRY_CODE] nvarchar(5) NULL,
    FK_COMPANY_TYPE int FOREIGN KEY REFERENCES [COMPANY_TYPE](ID) NULL,
)
go

--Initial codebook data
insert into [COMPANY_TYPE] ([NAME], [DESCRIPTION]) values
    ('industry', null),
	('navy', 'army'),
	('telco', 'ISP'),
	('other', null);
go