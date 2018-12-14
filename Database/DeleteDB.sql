USE [master]

--TODO: drop the tables first

IF EXISTS(select * from sys.databases where name='METALOGIX')
	DROP DATABASE [METALOGIX];
