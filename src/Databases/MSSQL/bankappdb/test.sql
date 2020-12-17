declare @pred bit = 1
select dbo.fn_get_status(@pred, 'Kadın', 'Erkek')
select dbo.fn_get_status(@pred, 'Açık', 'Kapalı')