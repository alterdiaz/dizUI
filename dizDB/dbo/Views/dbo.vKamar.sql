CREATE VIEW [dbo].[vKamar] AS
  select isnull(a.ward,b.ward) as ward,isnull(a.idpriority,b.idpriority) as priority, isnull(b.kelas,'') as kelas,isnull(a.idlokasi,b.idlokasi) as id,isnull(isnull(a.ward,b.ward) + ' (' + b.kelas+')',isnull(a.ward,b.ward)) as content from ((
select lk.idlokasi,lk.nama as ward, 0 as idpriority
from lokasi lk 
where lk.lokasitype in (4) and lk.iddepartment in(
select value from sys_appsetting where variable in ('IDOperatingDept'))
) a full outer join (
select lk.idlokasi,lk.nama as ward, kl.kelas, kl.idpriority   
from kelaskamar kk 
left join lokasi lk on lk.idlokasi=kk.idlokasi 
left join kelas kl on kk.idkelas=kl.idkelas 
where lk.lokasitype in (22,3,4) and lk.iddepartment in(
select value from sys_appsetting where variable in ('IDInpatientDept','IDNICUDept','IDPICUDept','IDICUDept')
)) b on a.ward=b.ward)
