create database LeaveSysDB
go
use LeaveSysDB
go
create table UserInfo (--�û���Ϣ��
	UserID int not null primary key identity(1,1),          --�û����
	LoginName nvarchar(20) not null,                        --�û���¼��
	Password nvarchar(20) not null,                         --��¼����
	UserRole int not null check(UserRole=1 or UserRole=2)   --�û���ɫ( 1:����  2:��ͨԱ��)
)

create table Leave (--��ٵ���
	LeaveID int not null primary key identity(1,1),                      --��ٱ��
	Title nvarchar(100) not null,                                        --��ٱ���
	BeginDate datetime not null,                                         --��ٿ�ʼ����
	EndDate datetime not null,                                           --��ٽ�������
	LeaveReason nvarchar(20) not null,                                   --���ԭ��
	ApplyTime datetime not null default(getdate()),                      --����ʱ��
	ApproveState int not null check(ApproveState=1 or ApproveState=2),   --����״̬(1:δ����  2:������)
	ApproveTime datetime default(null),                                  --����ʱ��
	ApproveResult nvarchar(20) default(null),                            --�������
	UserID int references UserInfo(UserID)                               --�����û����
)


insert UserInfo values('���ٻ�','123','1')
insert UserInfo values('�λ���','123','2')
insert UserInfo values('����','123','2')

insert Leave values('��Ҫ�ؼ�','2018-5-6','2018-5-6','��Ҫ�ؼҿ�����',default,'2',default,default,'3')
insert Leave values('��Ҫ�������','2018-5-9','2018-6-11','��Ҫ��С��',default,'1',default,default,'2')
insert Leave values('��Ҫ��ٻؼ�','2018-5-10','2018-5-12','��Ҫ�ؼҰ����֤',default,'1',default,default,'3')


select * from userinfo
select *,case when ApproveState = '1' then 'δ����'
			  when ApproveState = '2' then '������'end
			  as SPZT
from Leave a ,UserInfo b where a.UserID=b.UserID 


select *,case when ApproveState = '1' then 'δ����'
			  when ApproveState = '2' then '������'end
			  as SPZT
from Leave a ,UserInfo b where a.UserID=b.UserID and a.UserID='2'and  a.Title like '%��%'