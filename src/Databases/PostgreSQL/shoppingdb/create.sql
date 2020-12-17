/*----------------------------------------------------------------------------------------------------------------------
    shoppingdb veritabanı
----------------------------------------------------------------------------------------------------------------------*/
create schema shoppingdb;


create table phone_types (
    phone_type_id serial primary key,
    description varchar(10) not null
);

insert into phone_types (description) values ('GSM'), ('İş'), ('Ev');

create table customers (
	customer_id serial primary key,
	citizen_number char(11) check(length(citizen_number) = 11) unique not null,
	first_name varchar(100) not null,
	middle_name varchar(100),
	family_name varchar(100) not null
);

create table customer_to_phones (
    customer_to_phone_id serial primary key,
    customer_id integer references customers(customer_id) not null,
    phone_type_id integer references phone_types(phone_type_id) not null,
    phone char(14) not null
);

create table countries (
    country_id serial primary key,
    name varchar(50) not null
);

create table address_type (
    address_type_id serial primary key,
    description varchar(50) not null
);

insert into address_type (description) values ('Fatura Adresi'), ('Teslimat Adres');

create table addresses (
    address_id serial primary key,
    street varchar(50) not null,
    postal_code integer not null,
    county varchar(50),
    address_type_id integer references address_type(address_type_id) not null,
    country_id int references countries(country_id) not null,
    customer_id integer references customers(customer_id) not null
);

create table vendors (
    vendor_id serial primary key,
    title varchar(100) unique not null,
    description varchar(250)
);

create table products (
    product_code char(7) primary key,
    vendor_id integer references vendors(vendor_id) not null,
    name varchar(100) not null,
    stock int not null,
    cost money not null,
    unit_price money not null
);

create table orders (
    order_id bigserial primary key,
    customer_id integer references customers(customer_id) not null,
    product_code char(7) references products(product_code) not null,
    quantity int check(quantity > 0) default(1) not null,
    unit_price money not null
);




