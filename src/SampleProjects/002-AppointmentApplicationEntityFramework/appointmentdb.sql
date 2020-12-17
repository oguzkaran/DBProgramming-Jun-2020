create database AppointmentDb

go

use AppointmentDb

go

create table Client (
	Id int primary key identity(1, 1),
	Email nvarchar(100) unique not null,
	Name nvarchar(100) not null,
	Phone char(14) not null
)

go

create table Appointment (
	Id int primary key identity(1, 1),
	ClientId int foreign key references Client(Id),
	Date date not null,
)


go 


