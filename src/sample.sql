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
		- text
		- description

	relations tablosu hasta yakının hasta ile yakınlık derecesine ilişkin bilgileri tutmaktadır. 

	Buna göre:
	1. Tüm patient_id'lere ilişkin hastaların isimlerini  büyük harfe çeviren procedure'ü yazınız
	2. İl id'ine göre hastaların referakatçi isimlerini küçük harfe çeviren procedure'ü yazınız
	3. Belirli bir yaştan büyük olan hastaların refakatçi ve kendi isimlerini büyük harfe çeviren procedure'ü
	yazınız
----------------------------------------------------------------------------------------------------------------------*/

go
create procedure sp_select_value(@val int)
as
begin
	begin try
		if @val < 0
			raiserror('sp_select_value:error', 12, 1)

		select @val
	end try
	begin catch
		select 'sp_select_value:catch';
		throw
	end catch
end

go

begin try
	declare @val int = rand() * 20 - 10	
	exec sp_select_value @val
	select @val
end try
begin catch
	select ERROR_MESSAGE(), ERROR_NUMBER(), ERROR_SEVERITY()
end catch