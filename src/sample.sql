declare @students xml

set @students = (select * from students for xml auto)

select  @students