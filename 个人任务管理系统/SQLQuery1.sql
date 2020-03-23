create database Test
go
use Test
go

create table Project(
	ProjectID int primary key identity(1,1),
	ProjectName varchar(50) not null
)

create table Task(
	TaskID int primary key identity(1,1),
	TaskPriority int,
	Content varchar(200) not null,
	AddTime datetime default(getdate()) not null,
	TaskState int ,
	FinishedTime datetime null ,
	ProjectID int foreign key references Project(ProjectID)
)

insert into Project values('考勤管理平台'),('申请单管理系统'),('会员管理系统')

insert into Task values
('1','进行数据库设计',default,'2','2020-3-21','1'),
('2','实现审批申请单',default,'1',null,'2'),
('3','测试整个系统',default,'1',null,'3'),
('2','实现登录',default,'2','2020-3-21','1')

select *,case when TaskState='1' then '未完成'
			  when TaskState='2' then '已完成'end as RWZT,
case when TaskPriority='1' then '高'
	 when TaskPriority='2' then '中'
	 when TaskPriority='3' then '低'end as RWYXJ
 from Task a,Project b where a.ProjectID=b.ProjectID
