create database appointmentdb

go

use appointmentdb

go

create table clients (
	client_id int primary key identity(1, 1),
	email nvarchar(100) unique not null,
	name nvarchar(100) not null,
	phone char(14) not null
)

go

create table appointments (
	appointment_id int primary key identity(1, 1),
	client_id int foreign key references clients(client_id),
	date date not null,
)


go 

create procedure sp_insert_client(@name nvarchar(100), @email nvarchar(100), @phone char(14))
as
begin
	--...
	insert into clients (name, email, phone) values (@name, @email, @phone)
end

