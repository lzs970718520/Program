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

insert into Project values('���ڹ���ƽ̨'),('���뵥����ϵͳ'),('��Ա����ϵͳ')

insert into Task values
('1','�������ݿ����',default,'2','2020-3-21','1'),
('2','ʵ���������뵥',default,'1',null,'2'),
('3','��������ϵͳ',default,'1',null,'3'),
('2','ʵ�ֵ�¼',default,'2','2020-3-21','1')

select *,case when TaskState='1' then 'δ���'
			  when TaskState='2' then '�����'end as RWZT,
case when TaskPriority='1' then '��'
	 when TaskPriority='2' then '��'
	 when TaskPriority='3' then '��'end as RWYXJ
 from Task a,Project b where a.ProjectID=b.ProjectID
