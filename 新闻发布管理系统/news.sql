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
insert into NewsInfo values('admin','1','���׵�28�ֱ�����','����1��0С����,����������һ��',default,'1',null)
insert into NewsInfo values('admin','1','���׵�28�ֱ�����','��������3��0��ʤ��������',default,'2',getdate())

select * from NewsInfo