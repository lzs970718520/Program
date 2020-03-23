create database LeaveSysDB
go
use LeaveSysDB
go
create table UserInfo (--用户信息表
	UserID int not null primary key identity(1,1),          --用户编号
	LoginName nvarchar(20) not null,                        --用户登录名
	Password nvarchar(20) not null,                         --登录密码
	UserRole int not null check(UserRole=1 or UserRole=2)   --用户角色( 1:主管  2:普通员工)
)

create table Leave (--请假单表
	LeaveID int not null primary key identity(1,1),                      --请假编号
	Title nvarchar(100) not null,                                        --请假标题
	BeginDate datetime not null,                                         --请假开始日期
	EndDate datetime not null,                                           --请假结束日期
	LeaveReason nvarchar(20) not null,                                   --请假原因
	ApplyTime datetime not null default(getdate()),                      --申请时间
	ApproveState int not null check(ApproveState=1 or ApproveState=2),   --审批状态(1:未审批  2:已审批)
	ApproveTime datetime default(null),                                  --审批时间
	ApproveResult nvarchar(20) default(null),                            --审批结果
	UserID int references UserInfo(UserID)                               --申请用户编号
)


insert UserInfo values('宋仲基','123','1')
insert UserInfo values('宋慧乔','123','2')
insert UserInfo values('李振及','123','2')

insert Leave values('我要回家','2018-5-6','2018-5-6','我要回家考驾照',default,'2',default,default,'3')
insert Leave values('我要请三天假','2018-5-9','2018-6-11','我要陪小孩',default,'1',default,default,'2')
insert Leave values('我要请假回家','2018-5-10','2018-5-12','我要回家办身份证',default,'1',default,default,'3')


select * from userinfo
select *,case when ApproveState = '1' then '未审批'
			  when ApproveState = '2' then '已审批'end
			  as SPZT
from Leave a ,UserInfo b where a.UserID=b.UserID 


select *,case when ApproveState = '1' then '未审批'
			  when ApproveState = '2' then '已审批'end
			  as SPZT
from Leave a ,UserInfo b where a.UserID=b.UserID and a.UserID='2'and  a.Title like '%我%'