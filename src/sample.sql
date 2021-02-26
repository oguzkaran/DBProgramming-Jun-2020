/*----------------------------------------------------------------------------------------------------------------------	
	grant/revoke komutları view'lar için de kullanılabilir
----------------------------------------------------------------------------------------------------------------------*/

go
create view allpeople 
as
select * from people

go

create login sema with password='1234', default_database=peopledb

use peopledb

create user sema

grant select on allpeople to sema