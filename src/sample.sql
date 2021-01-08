/*----------------------------------------------------------------------------------------------------------------------	
	insert into select cümlesi ile bir tabloya başka bir tablodan ekleme yapılabilir. Bu durumda karşılıklı eklenen 
	elemanların uygun şekilde olması gerekir. Şüphesiz hedef tablonun varolması gerekir. Aşağıdaki örnekte 
	questions_backup tablosunun kendine ait bir identity primary key bilgisi olduğundan question_id kaynak
	tabloadan alınmamıştır
----------------------------------------------------------------------------------------------------------------------*/

insert into questions_backup (description, level_id, answer_index) 
(select description, level_id, answer_index from questions)

select * from questions_backup