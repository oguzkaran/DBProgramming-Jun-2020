/*----------------------------------------------------------------------------------------------------------------------
	Aşağıda açıklanan bankappdb veritabanını ve ilgili sorulara ilişkin kodları yazınız.
	bankappdb veritabanının tabloları:
	nationalities
		- id
		- description
	customers
		- id
		- citizen_id
		- nationality_id
		- number 
		- first_name 
		- middle_name
		- surname
		- email
		- is_alive
		- is_active
		- is_personnel
		- is_local
	phone_types
		- id
		- description
	phones
		- id 
		- customer_id
		- phone_type_id
		- phone
	addresses
		- id
		- customer_id
		- descrption
	card_types
		- id
		- description
	cards:
		- id 
		- customer_id
		- number
		- expiry_date_mon 
		- expiry_date_year
		- ccv 
		- card_type_id	
----------------------------------------------------------------------------------------------------------------------*/

create database bankappdb

go

use bankappdb

go

create table nationalities (
	nationality_id int primary key identity(1, 1),
	description nvarchar(30) not null
)

go

insert into nationalities (description) values ('TC'), ('US')

go


create table customers (
	customer_id int primary key identity(1, 1),
	citizen_id char(50) unique not null,
	nationality_id int foreign key references nationalities(nationality_id) not null,
	number char(8) check(LEN(number) = 8) unique not null,
	first_name nvarchar(100) not null,
	middle_name nvarchar(100), 
	surname nvarchar(100) not null,
	email nvarchar(100) not null,
	is_alive bit default(1) not null,
	is_active bit default(1) not null,
	is_personnel bit default(0) not null,
	is_local bit default(1) not null
)

go

create table phone_types (
	phone_type_id int primary key identity(1, 1),
	description nvarchar(30) not null
)

go

insert into phone_types (description) values ('GSM'), ('Ev'), ('Ofis'), ('Acil')

go


create table phones (
	phone_id int primary key identity(1, 1), 
	customer_id int foreign key references customers(customer_id),
	phone_type_id int foreign key references phone_types(phone_type_id), 
	phone char(14) check(LEN(phone) = 14) not null
)

go

create table addresses (
	address_id int primary key identity(1, 1), 
	customer_id int foreign key references customers(customer_id),
	description nvarchar(max) not null
)

go

create table card_types (
	card_type_id int primary key identity(1, 1),
	description nvarchar(30) not null
)

go

insert into card_types (description) values ('Visa'), ('Master'), ('Maestro')

go

create table cards (
	card_id int primary key identity(1, 1), 
	customer_id int foreign key references customers(customer_id),
	number char(20) check(LEN(number) = 20) unique not null,
	expiry_date_mon int check(1 <= expiry_date_mon and expiry_date_mon <= 12) not null,
	expiry_date_year int check(2000 <= expiry_date_year) not null,
	ccv char(3) check(LEN(ccv) = 3) not null,
	card_type_id int foreign key references card_types(card_type_id)
)

go

create function fn_hide_text(@text nvarchar(MAX), @ch nchar(1), @n int)
returns nvarchar(MAX)
as
begin
	return LEFT(@text, @n) + REPLICATE(@ch, LEN(@text) - @n)
end

go

create function fn_get_fullname(@first_name nvarchar(100), @middle_name nvarchar(100), @surname nvarchar(100))
returns nvarchar(300)
as
begin
	return case 
		when @middle_name is null then @first_name + ' ' +  UPPER(@surname)
		else @first_name + ' ' +  @middle_name + ' ' + UPPER(@surname)
		end
end

go

create function fn_get_status(@predicate bit, @true_str nvarchar(50), @false_str nvarchar(50))
returns nvarchar(50)
as
begin
	return case @predicate
		when 1 then @true_str
		else @false_str
		end
end
		 
go

/*
 Parametresi ile aldığı müşteri numarasına göre müşterinin aşağıdaki bilgilerini tablo biçiminde döndüren
	fn_get_card_info_by_customer_number fonksiyonunu yazınız:
		1. Müşteri adı soyadı
		2. Kart numarası: ilk 4 hanesi gözükecek geri kalanlar * olacak
		3. ccv: İlk karakteri gözükecek geri kalanlar * olacak
		4. Kart türünün yazısal karşılığı
		5. Kartın son kullanma tarihi bilgisi aa/yyyy
		6. Kartın sahibinin personel olup olmadığı
		7. Kartın sahibinin yaşayıp yaşamadığı
*/

create function fn_get_card_info_by_customer_number(@number char(8))
returns table 
as
return (
	select 
	dbo.fn_get_fullname(c.first_name, c.middle_name, c.surname) as fullname,
	dbo.fn_hide_text(ca.number, '*', 4) as card_number,
	dbo.fn_hide_text(ca.ccv, '*', 1) as ccv,
	ct.description card_type,
	dbo.fn_get_status(c.is_personnel, 'PERSONEL', 'PERSONEL DEĞİL') as personnel_status,
	dbo.fn_get_status(c.is_alive, 'SAĞ', 'ÖLÜ') as alive_status
	from 
	customers c inner join cards ca on c.customer_id=ca.customer_id
	inner join card_types ct on ct.card_type_id=ca.card_type_id
	where c.number = @number
)

go

/*
- Parametresi ile aldığı müşteri numarası ve ccv bilgilerinegöre müşterinin aşağıdaki bilgilerini tablo
	biçiminde döndüren	fn_get_card_info_by_customer_number_ccv fonksiyonunu yazınız: 
		1. Müşteri adı soyadı
		2. Kart numarası: ilk 4 hanesi gözükecek geri kalanlar * olacak
		3. Kart türünün yazısal kaşılığı
		4. Kartın son kullanma tarihi bilgisi aa/yyyy
*/

go

create function fn_get_expiry_date(@expiry_date_mon int, @expiry_date_year int)
returns char(5)
as 
begin
	return TRIM(CAST(@expiry_date_mon as char)) + '/' + TRIM(CAST(@expiry_date_year - 2000 as char))
end

go

create function fn_get_card_info_by_customer_number_ccv(@number char(8), @ccv char(3))
returns table 
as
return (
	select 
	dbo.fn_get_fullname(c.first_name, c.middle_name, c.surname) as fullname,
	dbo.fn_hide_text(ca.number, '*', 4) as card_number,	
	ct.description card_type,
	dbo.fn_get_expiry_date(ca.expiry_date_mon, ca.expiry_date_year) as expiry_date
	from 
	customers c inner join cards ca on c.customer_id=ca.customer_id
	inner join card_types ct on ct.card_type_id=ca.card_type_id
	where c.number = @number and ca.ccv= @ccv 
)

go

/*
	-Belirli bir kart türünde kartı aktif olan ve yurt dışında ikamet eden müşterilerin bilgilerini uyrukları da 
	içerecek şekilde getiren sorguyu fonksiyon biçiminde yazınız
*/

create function fn_get_customer_info_by_card_type_id_tr(@card_type_id int)
returns table 
as
return (
	select 
	dbo.fn_get_fullname(c.first_name, c.middle_name, c.surname) as fullname,
	n.description as nationality,
	dbo.fn_get_status(c.is_alive, 'SAĞ', 'ÖLÜ') as alive_status,
	dbo.fn_get_status(c.is_personnel, 'PERSONEL', 'PERSONEL DEĞİL') as personnel_status
	from
	cards ca inner join customers c on c.customer_id=ca.customer_id
	inner join nationalities n on c.nationality_id=n.nationality_id
	where c.is_active = 1 and c.is_local=0 and ca.card_type_id=@card_type_id
)

go

/*
	- Müşteri numarası bilinen müşteriye ilişkin kart bilgilerini kart türü ile birlikte getiren sorguyu fonksiyon 
	biçiminde yazınız
*/

create function fn_get_customer_info_by_customer_number(@number char(8))
returns table
as
return (
	select 
		dbo.fn_get_fullname(c.first_name, c.middle_name, c.surname) as fullname,
		dbo.fn_hide_text(ca.number, '*', 4) as card_number,	
		ct.description as card_type
	from
	customers c inner join cards ca on c.customer_id=ca.customer_id
	inner join card_types ct on ct.card_type_id=ca.card_type_id
	where c.number=@number
)
