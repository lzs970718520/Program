create database ClassResultlzs
go
use ClassResultlzs
go
create table UserInfolzs
(
	UserId	int	primary key identity(1,1),
	UserName	varchar(50)	not null,
	UserPsw	varchar(50)	not null
)
create table ClassInfolzs(
ClassId	int	primary key identity(1,1),
ClassName	varchar(50)		not null
)
create table StudentResultlzs(
	rid	int	primary key identity(1,1),
	Sid	Int references UserInfolzs(UserId)	not null,
	Chinese	int	not null,
	Math	int	not null,
	English	int	not null,
	Computer int	not null,
	Etime	datetime default(Getdate())	not null,
	TScore	int	null,
	IfPass	int	default('0'),
	Rlevel	Int	default('0'),
	ClassId	int	references ClassInfolzs(ClassId)	not null,
)

insert into UserInfolzs values('С�κ�','123456'),('С����','888888'),('СФФ','888888')

insert into ClassInfolzs values('���տ���'),('̫����'),('���ǰ�')

insert into StudentResultlzs values('1','80','90','99','100',default,null,default,default,'1'),
('2','30','99','79','80',default,null,default,default,'1'),
('3','86','60','87','55',default,null,default,default,'3')

select *,case when IfPass='0' then 'δͳ��'
			  when IfPass='1' then '����'
			  when IfPass='2' then '������' end as IFPAS,
		case when Rlevel='0' then 'δͳ��'
			 when Rlevel='1' then '��'
			 when Rlevel='2' then 'һ��'
			 when Rlevel='3' then '����'
			 when Rlevel='4' then '����' end as CJDJ
from StudentResultlzs a,ClassInfolzs b,UserInfolzs c where a.Sid=c.UserId and a.ClassId=b.ClassId

