create database QLINTERNET

use QLINTERNET

create table May
(
	IDMay char(5) not null primary key,
	TenMay nvarchar(50),
	TrangThai ntext default N'Bật',
	SoTG time default '00:00:00',
	PhuongThucDung ntext default N'Không có',
	SoTien float default 0,
	TimeStart datetime default '2000-01-01 00:00:00'
)

insert into SanPham 
values('SP01', N'Cơm rang dưa bò', 30000, 10),
      ('SP02', N'Cơm rang thập cẩm', 30000, 10),
      ('SP03', N'Cơm rang trứng', 30000, 15),
	  ('SP04', N'Đồ uống Sting', 10000, 50),
	  ('SP05', N'Đồ uống 7UP', 10000, 50),
	  ('SP06', N'Đồ uống Coca', 10000, 100),
	  ('SP07', N'Bún ếch măng cay', 40000, 10),
	  ('SP08', N'Thẻ game garena', 20000, 100),
	  ('SP09', N'Thẻ game garena', 50000, 100),
	  ('SP10', N'Thẻ game garena', 100000, 100),
	  ('SP11', N'Thẻ game garena', 200000, 100),
	  ('SP12', N'Thẻ game garena', 500000, 100);

create table TaiKhoan
(
	UserName varchar(20) not null primary key,
	Pass varchar(20) not null,
	SoPhut int default 0,
	DayLgEnd date,
	SoTienHienCo int default 0
)

create table DaiLy
(
	MaDL char(5) not null primary key,
	TenDL nvarchar(50) not null,
	DiaChi ntext
)

create table PhieuNhap
(
	IDPhieu char(5) not null primary key,
	MaDL char(5) not null,
	foreign key (MaDL) references DaiLy(MaDL)
)

create table SanPham
(
	IDSP char(5) not null primary key,
	TenSP nvarchar(100) not null,
	GiaBan int,
	SLTon int
)

create table CTPhieuNhap
(
	IDPhieu char(5) not null,
	IDSP char(5) not null,
	SoLuong int,
	TongTien int,
	primary key (IDPhieu, IDSP),
	foreign key (IDPhieu) references PhieuNhap(IDPhieu),
	foreign key (IDSP) references SanPham(IDSP)
)

CREATE TABLE HoaDon (
    mahd int PRIMARY KEY identity,
    NgayLap datetime,
    tongtien float
)

create table CTHoaDon
(
    mahd int,
    IDSP char(5),
    SoLuong int,
    primary key (mahd, Idsp),
    foreign key (mahd) references hoadon(mahd)
)

drop table cthoadon

create table QL_Dai_Ly
(
	MaDL char(5) not null primary key,
	TenDL nvarchar(50) not null,
	DiaChi ntext
)
