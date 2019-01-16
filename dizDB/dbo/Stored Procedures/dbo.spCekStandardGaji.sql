CREATE PROCEDURE dbo.spCekStandardGaji
(@idunit bigint=0,
@iddept bigint=0,
@idjabatan bigint=0,
@idstaff bigint=0)
AS
BEGIN

select isnull(s.idstandardgaji,-1) as idstandardgaji,k.idkomponengaji,
isnull(substring(convert(varchar,s.periode,105),4,7),substring(convert(varchar,getdate(),105),4,7)) as periode,
k.komponengaji,k.jeniskomponengaji,t.generalcode as jeniskomponen,
isnull(s.standardgaji,0) as standardgaji 
from komponengaji k 
left join standardgaji s on s.idkomponengaji=k.idkomponengaji 
and s.idunit=@idunit and s.iddepartment=@iddept and s.idposition=@idjabatan 
and substring(convert(varchar,s.periode,105),4,7)=(
select top 1 substring(convert(varchar,s.periode,105),4,7) 
from standardgaji s
where s.idunit=@idunit and s.iddepartment=@iddept and s.idposition=@idjabatan order by s.periode desc 
)
left join sys_generalcode t on t.idgeneral=k.jeniskomponengaji and t.gctype='JENISKOMPONENGAJI' 
order by k.jeniskomponengaji asc, k.komponengaji asc

END
