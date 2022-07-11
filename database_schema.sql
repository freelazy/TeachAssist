-- 创建数据库
create database TeachAssist;
use TeachAssist

-- 创建学生表
create table students
(
  id varchar(50) primary key,
  name nvarchar(50) not null,
  homecity nvarchar(50),
  telephone varchar(20),
  state int default 1,
  tiwen_cishu int default 0,  -- 冗余
  tiwen_fenshu int default 0, -- 冗余
  gno int
);

-- 添加组表
create table groups
(
  gno int primary key,
  stuid varchar(50),
  slogan varchar(200)
);

-- 存储系统参数
create table parameters
(
  name varchar(200) not null,
  value varchar(200) not null,
  category varchar(200) not null default 'misc',
  type int not null default 1
);
insert into parameters (name, value) values ('defaultMenuIndex', '1');
insert into parameters (name, value) values ('autoRollInterval', '2000');
insert into parameters (name, value) values ('avatarDir', 'E:/Workdir/avatars/');


-- 添加提问记录表
create table tiwen
(
   id int identity primary key,
   stuid varchar(50),
   score int,
   created_at datetime default getdate()
);

-- 清空分数
update students set tiwen_cishu = 0, tiwen_fenshu=0;
delete from tiwen;
