/*----------------------------------------------------------------------------------------------------------------------
	Bir login'in şifresi aşağıdaki gibi alter login cümlesi ile değiştirilebilir
----------------------------------------------------------------------------------------------------------------------*/
create login turgut with password='1234'

alter login turgut with password='34567'

alter server role diskadmin add member turgut
alter server role sysadmin add member turgut

