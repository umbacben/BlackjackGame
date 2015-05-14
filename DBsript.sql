drop table if exists PublicChat;
drop table if exists PrivateChat;
drop table if exists Game;
drop table if exists User;


create table if not exists User(

idUser	int not null auto_increment,

userName	varchar(45) not null unique,

password	varchar(45) not null,

primary key (idUser),

Unique(userName));



create table if not exists PublicChat(

idPublicChat	int not null auto_increment,

message		varchar(2000) not null,

time		DATETIME not null,

userName	varchar(45) not null,

primary key (idPublicChat),

Foreign Key(userName) references User(userName));



create table if not exists Game(

idGame	int not null auto_increment,

privateChatId	int not null,

typeG	boolean not null,

full	boolean not null,

primary key (idGame));



create table if not exists PrivateChat(

idPrivateChat	int not null auto_increment,

message		varchar(2000) not null,

time		DATETIME not null,

userName	varchar(45) not null,

game		int not null,

primary key (idPrivateChat),

Foreign Key(userName) references User(userName),

Foreign key(game) references Game(idGame));