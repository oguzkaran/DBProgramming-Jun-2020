/*----------------------------------------------------------------------------------------------------------------------
    shoppingappdb veritabanı
----------------------------------------------------------------------------------------------------------------------*/
create database shoppingdb

go

use shoppingdb

go


create table phone_types (
    phone_type_id int identity(1, 1) primary key,
    description nvarchar(10) not null
)

go

insert into phone_types (description) values ('GSM'), ('İş'), ('Ev')

go

create table customers (
	customer_id int identity(1, 1) primary key,
	citizen_number char(11) check(len(citizen_number) = 11) unique not null,
	first_name nvarchar(100) not null,
	middle_name nvarchar(100),
	family_name nvarchar(100) not null
)

go

create table customer_to_phones (
    customer_to_phone_id int identity(1, 1) primary key,
    customer_id int foreign key references customers(customer_id) not null,
    phone_type_id int foreign key references phone_types(phone_type_id) not null,
    phone char(14) not null
)

go

create table countries (
    country_id int identity(1, 1) primary key,
    name nvarchar(50) not null
)

go

create table address_type (
    address_type_id int identity(1, 1) primary key,
    description nvarchar(50) not null
)

go

insert into address_type (description) values ('Fatura Adresi'), ('Teslimat Adresi')

go

create table addresses (
    address_id int identity(1, 1) primary key,
    street nvarchar(50) not null,
    postal_code int not null,
    county nvarchar(50),
    address_type_id int foreign key references address_type(address_type_id) not null,
    country_id int foreign key references countries(country_id),
    customer_id int foreign key references customers(customer_id)
)

go

create table vendors (
    vendor_id int identity(1, 1) primary key,
    title nvarchar(100) unique not null,
    description nvarchar(250)
)

go

create table products (
    product_code nchar(7) primary key,
    vendor_id int foreign key references vendors(vendor_id),
    name nvarchar(100) not null,
    stock int not null,
    cost money not null,
    unit_price money not null
)

go

create table orders (
    order_id int identity(1, 1) primary key,
    customer_id int foreign key references customers(customer_id) not null,
    product_code nchar(7) foreign key references products(product_code) not null,
    quantity int check(quantity > 0) default(1) not null,
    unit_price money not null
)

go




