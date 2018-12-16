USE [master]

IF EXISTS(select * from sys.databases where name='METALOGIX')
	DROP DATABASE [METALOGIX];
