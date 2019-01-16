CREATE PROCEDURE dbo.spStatusAPS
@periode varchar(10)
AS
BEGIN
set @periode='%'+@periode

select d.department,
isnull(satu.counter,0) as aps, 
isnull(dua.counter,0) as nonaps, 
isnull(tot.counter,0) as total  
from department d 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis 
where rm.rekammedisno=0 and r.isdeleted=0 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) satu on d.iddepartment=satu.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis 
where rm.rekammedisno>0 and r.isdeleted=0 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) dua on d.iddepartment=dua.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis 
where (rm.rekammedisno=0 or rm.rekammedisno>0) and r.isdeleted=0 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) tot on d.iddepartment=tot.iddepartment 
where d.iddepartment in (
select value from sys_appsetting where variable in('idlabdept','idraddept')
)
order by d.department asc

END