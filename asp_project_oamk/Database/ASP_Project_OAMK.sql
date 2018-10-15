Create database DBASPprojectOamk;
go

use DBASPprojectOamk
go

CREATE TABLE [dbo].[Actor] (

 intId int IDENTITY(1,1),
 strName varchar(128) NOT NULL,
 strSex  char(6) NOT NULL,  
 datDOB  datetime NOT NULL,
 strBio  varchar(512) NULL,

 CONSTRAINT Actor_PK PRIMARY KEY CLUSTERED(intId)
)

CREATE TABLE [dbo].[Producer] (
	intId int IDENTITY(1,1) ,
	strName varchar(128) NOT NULL,
	strSex char(6) NOT NULL,
	datDOB datetime NOT NULL,
	strBio varchar(512) NULL,

	CONSTRAINT Producer_PK PRIMARY KEY CLUSTERED(intId)
	)

	CREATE TABLE [dbo].[Movie] (
	intId int IDENTITY(1,1),
	strName varchar(128) NOT NULL,
	sintYor smallint  NOT NULL CHECK (sintYor BETWEEN 1000 AND 9999),
	strPoster varchar(128),
	ProducerId int NOT NULL,

	CONSTRAINT Movie_PK PRIMARY KEY CLUSTERED(intId),
	CONSTRAINT Movie_FK_Producer FOREIGN KEY (ProducerId) REFERENCES Producer (intId)
	)

CREATE TABLE [dbo].[ActorMovie] (

	intActorId int ,
	intMovieId int ,

	CONSTRAINT ActorMovie_PK PRIMARY KEY CLUSTERED (intActorId , intMovieId),
	CONSTRAINT ActorMovie_FK_Actor FOREIGN KEY (intActorId) REFERENCES Actor (intId),
	CONSTRAINT ActorMovie_FK_Movie FOREIGN KEY (intMovieId) REFERENCES Movie (intId),

 )
