/*----------------------------------------------------------------------------------------------------------------------	
	Sınıf Çalışması: Aşağıda belirtilen students isimli tabloyu oluşturunuz
	- student_id	- int
	- name			- nvarchar(30)
	- surname		- nvarchar(30)
	- phone			- char(14)

	Bu tabloya göre oluşan error'lara ilişkin source number, message, severity number, line ve oluşma tarih-zaman bilgilerini
	students_errors isimli bir tabloya kaydeden sp_insert_student isimli stored procedure'ü yazınız
----------------------------------------------------------------------------------------------------------------------*/
go

create table students (
	student_id	int primary key identity(1, 1),
	name nvarchar(30) not null,
	surname nvarchar(30) not null,
	phone char(14)
)


go

create table students_errors (
	error_id int primary key identity(1, 1),
	source nvarchar(max) not null,
	number int not null,
	message nvarchar(max) not null,
	severity int not null,
	line int not null,
	datetime datetime default(sysdatetime()) not null
)

go

create procedure sp_insert_student(@name nvarchar(50), @surname nvarchar(50), @phone char(50))
as
begin
	begin try
		insert into students (name, surname, phone) values (@name, upper(@surname), @phone)
	end try
	begin catch
		insert into students_errors (source, number, severity, message, line) 
		values (error_procedure(), error_number(), error_severity(), error_message(), error_line())
	end catch
end


go

exec sp_insert_student 'Oğuz', 'Karan', '00905325158012'

select * from students_errors