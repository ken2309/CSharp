create database thongtinkhachhang;
go
drop table PHONGBAN
create table dbo.GIOITINH(
MaNV varchar(5) primary key,
Ngaysinh datetime,
Hoten nvarchar(max),
MaGT int,
MaPB varchar(5)  ,
ThuongTru nvarchar(MAX),
TrangThai smallint,
)
go
create table dbo.PHONGBAN(
MaPB varchar(5) primary key,
TenPB nvarchar(20),
TrangThai smallint,
)
alter table dbo.GIOITINH
add foreign key (MaPB) references dbo.PHONGBAN(MaPB)