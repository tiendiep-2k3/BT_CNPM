use test00

drop table Tickets

CREATE TABLE Customer (
    Name_cus nvarchar(30),
    SDT VARCHAR(50) Primary key,
	PIN int
);

CREATE table dataTicket (
    Name_cus nvarchar(30),
	SDT VARCHAR(50),
	Diemdi nvarchar(30),
	Diemden nvarchar(30),
	FOREIGN KEY (SDT) REFERENCES customer(sdt)
);

drop table Customer
drop table dataTicket

insert into Customer values
(N'Nguyen Van Nam','012',123),
(N'Nguyen Van Quan','890',123),
(N'Nguyen Van An','123',123),
(N'Nguyen Van Binh','456',123);

insert into dataTicket values
(N'Nguyen Van Nam','012',N'ĐH Tôn Đức Thắng',N'ĐH Văn Lang');


select * from dataTicket;
select * from Customer;
