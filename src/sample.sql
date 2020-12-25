/*----------------------------------------------------------------------------------------------------------------------	
	Sınıf Çalışması: Basit bir çoktan seçmeli sınava ilişkin aşağıdaki veri tabanını oluşturunuz. Tüm soruların
	değişken sayıda seçenekleri olacaktır. 

	questions:
		- question_id
		- description
		- level_id
		- answer_index
	options:
		- option_id
		- description
		- question_id
	levels:
		- level_id
		- description

	Buna göre:
	1. Her çağrıldığında herhangi bir seviyeden rasgele bir soru getiren sorgu
	2. Parametresi ile aldığı level_id bilgisine göre rasgele bir soru getiren sorgu
----------------------------------------------------------------------------------------------------------------------*/

declare @max int = (select COUNT(*) from people) + 1
declare @min int = 1 
declare @index int = RAND() * (@max -@min) + @min --[min, max)

declare crs_people cursor scroll for select citizen_id from people
open crs_people -- cursor açılıyor

declare @citizen_id char(11)

fetch absolute @index from crs_people into @citizen_id 

if @@FETCH_STATUS = 0
	select * from people where citizen_id=@citizen_id

close crs_people

deallocate crs_people





