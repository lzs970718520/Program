create database CarInfo
go
use CarInfo
go
create table CarBrand
(
	BrandId	int	primary key identity(1,1),
	BrandName	varchar(50)	not null
)

create table CarDetail
(
	cid	int	primary key identity(1,1),
	cname	Varchar(50) not null,
	Content	Varchar(200) not null,
	Price	int not null,
	ImageUrl	Varchar(200) not null,
	Ltime datetime default(Getdate()) not null,
	BrandId	int	references CarBrand(BrandId) not null
)

insert into CarBrand values('雪佛兰'),('奔驰')

insert into CarDetail values('迈锐宝XL','雪佛兰旗下B级车旗舰品牌','300000','img/1.jpg',default,'1'),
('奔驰SLC260','梅赛德斯奔驰，土豪必备','420000','img/2.jpg',default,'2'),
('奔驰C200','好车就是好看','1000000','img/3.jpg',default,'2')

select * from CarDetail
select BrandId from CarBrand
select * from CarDetail a,CarBrand b where a.BrandId=b.BrandId