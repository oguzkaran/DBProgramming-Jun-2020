/*----------------------------------------------------------------------------------------------------------------------	
	Sınıf Çalışması: Aşağıdaki veritabanını oluşturunuz:
	patients
		- patient_id
		- name
		- address
		- city_id
		- birth_date
	companions
		- companion_id
		- name
		- patient_id
		- relation_id
	cities
		- city_id
		- name
	relations
		- relation_id		
		- description

	relations tablosu hasta yakının hasta ile yakınlık derecesine ilişkin bilgileri tutmaktadır. 

	Buna göre aşağıdaki procedure'leri cursır ile yapınız:
	1. Tüm patient_id'lere ilişkin hastaların isimlerini  büyük harfe çeviren procedure'ü yazınız
	2. İl id'ine göre hastaların referakatçi isimlerini küçük harfe çeviren procedure'ü yazınız
	3. Belirli bir yaştan büyük olan hastaların refakatçi ve kendi isimlerini büyük harfe çeviren procedure'ü
	yazınız
----------------------------------------------------------------------------------------------------------------------*/

create database patientsdb

go

use patientsdb

go

go

create table cities(
	city_id int primary key identity(1, 1),
	name nvarchar(30) not null
)

go

go

create table relations(
	relation_id int primary key identity(1, 1),
	description nvarchar(50) not null,	
)

go

insert into relations(description)values('Annesi'),( 'Babasi'),('Cocugu'),('Kizi'),('Oglu'),('Teyzesi'),( 'Halasi'),('Amcasi'),('Dayisi'),('Yegeni'),('Kuzeni')


go

create table patients(
	patient_id int primary key identity(1, 1),
	name nvarchar(200) not null,
	address nvarchar(max),
	city_id int foreign key references cities(city_id),
	birth_date date not null
)

go

go
create table companions(
	companion_id int primary key identity(1, 1),
	name nvarchar(200) not null,
	patient_id int foreign key references patients(patient_id),
	relation_id int foreign key references relations(relation_id),
)

go

