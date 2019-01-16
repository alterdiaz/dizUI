CREATE PROCEDURE dbo.spStatusRegistrasi
@periode varchar(10)
AS
BEGIN
set @periode='%'+@periode

select d.department,
isnull(nol.counter,0) as terbuka, 
isnull(dua.counter,0) as batal, 
isnull(tiga.counter,0) as dirujuk, 
isnull(empat.counter,0) as paksa, 
isnull(lima.counter,0) as kabur, 
isnull(enam.counter,0) as meninggal, 
isnull(tujuh.counter,0) as tutup,
isnull(tot.counter,0) as total  
from department d 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.registrasistatus=0 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) nol on d.iddepartment=nol.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.registrasistatus=2 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) dua on d.iddepartment=dua.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.registrasistatus=3 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) tiga on d.iddepartment=tiga.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.registrasistatus=4 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) empat on d.iddepartment=empat.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.registrasistatus=5 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) lima on d.iddepartment=lima.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.registrasistatus=6 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) enam on d.iddepartment=enam.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.registrasistatus=7 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) tujuh on d.iddepartment=tujuh.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r left join department d on r.iddepartment=d.iddepartment 
where convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) tot on d.iddepartment=tot.iddepartment 
where d.iddepartment in (
select value from sys_appsetting where variable in('idemergencydept','idicudept','idinpatientdept','idlabdept','idnicudept','idoperatingdept','idoutpatientdept','idpicudept','idphysiodept','idraddept')
)
order by d.department asc

END