create database Newsmanerger
go
use Newsmanerger
go

create table UserInfo(
	UserId	int	primary key identity(1,1),
	UserName	varchar(50)	not null,
	Psswd	varchar(50)	not null
)

create table NewsInfo(
	n_id	int	primary key identity(1,1),
	n_name	Varchar(50),
	N_type	int,
	n_title	varchar(50) not null,
	n_content	varchar(200) not null,
	n_time	datetime default(Getdate()) not null,
	n_state	int,
	S_time	Datetime 
)
insert into UserInfo values('admin','123')
insert into NewsInfo values('admin','1','西甲第28轮比赛简报','皇马1：0小生马竞,本泽马致命一击',default,'1',null)
insert into NewsInfo values('admin','1','西甲第28轮比赛简报','西班牙人3：0完胜巴塞罗那',default,'2',getdate())

select * from NewsInfo