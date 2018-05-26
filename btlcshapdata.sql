create database QLBH

use QLBH
create table NhanVien
(
	maNhanVien	nvarchar(10) primary key not null,
	hoTen		nvarchar(30) not null,
	diaChi		nvarchar(30) not null,
	soDienThoai	nvarchar(30) not null	  
)
create table KhachHang
(
	maKhachHang nvarchar(10) primary key not null,
	hoTen		nvarchar(30) not null,
	diaChi		nvarchar(30) not null,
	soDienThoai	nvarchar(30) not null
)
create table LoaiHang
(
	maLoai	nvarchar(10) primary key not null,
	tenLoai nvarchar(30) not null,
	ghiChu	nvarchar(30) not null
)
create table NhaCungCap
(
	maNhaCungCap	nvarchar(10)  primary key not null,
	tenNhaCungCap	nvarchar(30) not null,
	diaChi			nvarchar(30) not null,
	soDienhoai		nvarchar(30) not null
)
create table HoaDon
(
	maHoaDon	nvarchar(10) primary key  not null,
	maKhachHang nvarchar(10) not null,
	ngayLap		date not null,
	maNhanVien  nvarchar(10) not null,
	constraint	FK1 Foreign Key(maNhanVien) references NhanVien(maNhanVien) on update cascade on delete cascade, 
    constraint	FK2 Foreign Key(maKhachHang) references KhachHang(maKhachHang) on update cascade on delete cascade
)
create table Hang
(
	maHang			nvarchar(10) primary key not null,
	tenHang			nvarchar(30) not null,
	donViTinh		nvarchar(30) not null,
	donGia			float not null,
	maLoai			nvarchar(10) not null,
	soLuongCo		int not null,
	maNhaCungCap	nvarchar(10) not null
	constraint	FK3 Foreign Key(maLoai) references LoaiHang(maLoai) on update cascade on delete cascade,
	constraint	FK4 Foreign Key(maNhaCungCap) references NhaCungCap(maNhaCungCap) on update cascade on delete cascade
  
)
create table HoaDonChiTiet
(
	maHoaDon	nvarchar(10) not null,
	maHang		nvarchar(10) not null,
	soLuong		int not null,
	constraint	PK1 primary key(maHoaDon,maHang),
	constraint	FK5 Foreign Key(maHoaDon) references HoaDon(maHoaDon) on update cascade on delete cascade,
	constraint	FK6 Foreign Key(maHang) references Hang(maHang) on update cascade on delete cascade,
)

create table LichSuGia
(
	
	maHang		nvarchar(10) not null,
	ngayBatDau	date not null,
	ngayKetThuc date not null, 
	donGia		float not null,
	ngayCapNhat date not null, 
	constraint	PK2 primary key(ngayBatDau,maHang),
	constraint	FK7 Foreign Key(maHang) references Hang(maHang) on update cascade on delete cascade,
)











insert into LoaiHang values('LH1','Rau',N'Tốt')
insert into LoaiHang values('LH2',N'Củ',N'Tốt')
insert into LoaiHang values('LH3',N'Quả',N'Kém')
insert into LoaiHang values('LH4',N'Hoa',N'Trung bình')
insert into LoaiHang values('LH5',N'Thịt',N'Tốt')
insert into LoaiHang values('LH6',N'Cá',N'Trung bình')
insert into LoaiHang values('LH7',N'Trứng',N'Tốt')
select * from LoaiHang

insert into NhaCungCap values('NCC1','SX1',N'Hà Nội','098888888')
insert into NhaCungCap values('NCC2','SX2',N'Hà Nam','098998888')
insert into NhaCungCap values('NCC3','SX3',N'Hồ Chí Minh','098888908')
insert into NhaCungCap values('NCC4','SX4',N'Hải Phòng','0988444488')
insert into NhaCungCap values('NCC5','SX5',N'Hà Phòng','098115565')
insert into NhaCungCap values('NCC6','SX6',N'Hà Nội','0981552133')
insert into NhaCungCap values('NCC7','SX7',N'Hà Nội','0986666666')

insert into Hang values('MH1',N'Rau cải',N'Kg',120000,'LH1',100,'NCC1')
insert into Hang values('MH2',N'Rau muống ',N'Kg',50000,'LH1',100,'NCC1')
insert into Hang values('MH3',N'Cà chua',N'Kg',10000,'LH3',100,'NCC2')
insert into Hang values('MH4',N'Bí ngô',N'Kg',125000,'LH3',100,'NCC2')
insert into Hang values('MH5',N'Cà rốt',N'Kg',2000,'LH2',100,'NCC3')
insert into Hang values('MH6',N'Khoai',N'Kg',9900,'LH2',100,'NCC3')
insert into Hang values('MH7',N'Hoa Hướng Dương',N'Bông',10000,'LH4',100,'NCC4')
insert into Hang values('MH8',N'Hoa Lan',N'Bông',60000,'LH4',100,'NCC4')
insert into Hang values('MH9',N'Hoa Ly',N'Bông',20000,'LH4',100,'NCC5')
insert into Hang values('MH10',N'Thịt bò','Kg',80000,'LH5',100,'NCC5')
insert into Hang values('MH11',N'Thịt lợn','Kg',120000,'LH5',100,'NCC6')
insert into Hang values('MH12',N'Cá rô','Kg',12000,'LH6',100,'NCC6')
insert into Hang values('MH13',N'Cá ba sa','Kg',9000,'LH6',100,'NCC7')
insert into Hang values('MH14',N'Trứng gà',N'Quả',40000,'LH7',100,'NCC7')
insert into Hang values('MH15',N'Trứng vịt',N'Quả',20000,'LH7',100,'NCC1')
select * from LichSuGia

insert into LichSuGia values('MH1','01/12/2017','02/12/2017',120000,'02/09/2017')
insert into LichSuGia values('MH2','02/12/2017','03/12/2017',50000,'03/09/2017')
insert into LichSuGia values('MH3','01/12/2017','02/12/2017',10000,'02/09/2017')
insert into LichSuGia values('MH4','01/12/2017','02/12/2017',1250000,'02/09/2017')
insert into LichSuGia values('MH5','08/10/2017','09/10/2017',2000,'08/15/2017')
insert into LichSuGia values('MH6','08/10/2017','09/10/2017',9900,'08/15/2017')
insert into LichSuGia values('MH7','08/10/2017','09/10/2017',10000,'08/15/2017')
insert into LichSuGia values('MH8','10/12/2017','12/12/2017',60000,'12/09/2017')
insert into LichSuGia values('MH9','10/12/2017','12/12/2017',20000,'12/09/2017')
insert into LichSuGia values('MH10','10/12/2017','12/12/2017',80000,'12/09/2017')
insert into LichSuGia values('MH11','09/12/2017','12/12/2017',120000,'12/09/2017')
insert into LichSuGia values('MH12','09/12/2017','12/12/2017',12000,'12/09/2017')
insert into LichSuGia values('MH13','09/12/2017','12/12/2017',9000,'12/09/2017')
insert into LichSuGia values('MH14','02/12/2017','04/12/2018',40000,'02/22/2018')
insert into LichSuGia values('MH15','02/12/2017','04/12/2018',20000,'02/22/2018')

insert into KhachHang values('KH1',N'Nguyễn Văn Nam',N'Hà Nội','012335566')
insert into KhachHang values('KH2',N'Nguyen Đình Hải',N'Hà Nam','01545566')
insert into KhachHang values('KH3',N'Trần Văn Mạnh',N'Hà Dông','064535566')
insert into KhachHang values('KH4',N'Trần Hùng Cường',N'Hải Phòng','042335566')
insert into KhachHang values('KH5',N'Đăng Văn Khoa',N'Hải Dương','0135566')
insert into KhachHang values('KH6',N'Đặng Thị Quyên',N'Hà Tĩnh','098335566')
insert into KhachHang values('KH7',N'Lê Thế Lâm',N'Hồ Chí Minh','034335566')


insert into NhanVien values('NV1',N'Lê Văn Nam',N'Hà Nội','05435566')
insert into NhanVien values('NV2',N'Lê Văn Hải',N'Hà Nội','034435566')
insert into NhanVien values('NV3',N'Nguyen Hùng Nam',N'Hà Nội','012335566')
insert into NhanVien values('NV4',N'Trần Thị Tâm',N'Hà Nội','01215566')
insert into NhanVien values('NV5',N'Lê Đình Cường',N'Hà Nội','012335545')
insert into NhanVien values('NV6',N'Nguyễn Văn Thế',N'Hà Nội','012335654')
insert into NhanVien values('NV7',N'Đăng Văn Nguyên',N'Hà Nội','01233645')

insert into HoaDon values('HD1','KH1','03/10/2017','NV2')
insert into HoaDon values('HD2','KH2','03/10/2017','NV2')
insert into HoaDon values('HD3','KH3','03/10/2017','NV2')
insert into HoaDon values('HD4','KH4','04/12/2017','NV2')
insert into HoaDon values('HD5','KH5','04/12/2017','NV2')
insert into HoaDon values('HD6','KH6','04/12/2017','NV1')
insert into HoaDon values('HD7','KH7','03/8/2017','NV1')
insert into HoaDon values('HD8','KH7','03/8/2017','NV3')
insert into HoaDon values('HD9','KH5','03/8/2017','NV3')
insert into HoaDon values('HD10','KH5','02/12/2017','NV4')
insert into HoaDon values('HD11','KH6','02/12/2017','NV5')
insert into HoaDon values('HD12','KH6','03/12/2017','NV4')
insert into HoaDon values('HD13','KH7','04/12/2017','NV6')
insert into HoaDon values('HD14','KH1','04/12/2017','NV6')
insert into HoaDon values('HD15','KH6','05/12/2017','NV7')
insert into HoaDon values('HD16','KH6','06/12/2017','NV7')
insert into HoaDon values('HD17','KH1','06/12/2017','NV7')
insert into HoaDon values('HD18','KH1','05/12/2017','NV7')

insert into HoaDonChiTiet values('HD1','MH1',15)
insert into HoaDonChiTiet values('HD2','MH1',25)
insert into HoaDonChiTiet values('HD3','MH2',10)
insert into HoaDonChiTiet values('HD4','MH3',10)
insert into HoaDonChiTiet values('HD5','MH3',25)
insert into HoaDonChiTiet values('HD6','MH2',31)
insert into HoaDonChiTiet values('HD7','MH4',12)
insert into HoaDonChiTiet values('HD8','MH5',12)
insert into HoaDonChiTiet values('HD9','MH4',15)
insert into HoaDonChiTiet values('HD10','MH5',15)
insert into HoaDonChiTiet values('HD11','MH6',35)
insert into HoaDonChiTiet values('HD12','MH7',45)
insert into HoaDonChiTiet values('HD13','MH7',21)
insert into HoaDonChiTiet values('HD14','MH6',42)
insert into HoaDonChiTiet values('HD15','MH3',45)
insert into HoaDonChiTiet values('HD16','MH4',65)
insert into HoaDonChiTiet values('HD17','MH7',17)
insert into HoaDonChiTiet values('HD18','MH1',36)

SELECT * FROM NhaCungCap
SELECT * FROM KhachHang
SELECT * FROM NhanVien
SELECT * FROM HoaDon
SELECT * FROM HoaDonChiTiet
SELECT * FROM Hang
SELECT * FROM LoaiHang




