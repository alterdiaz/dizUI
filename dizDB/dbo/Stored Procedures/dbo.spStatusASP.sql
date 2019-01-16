CREATE PROCEDURE dbo.spStatusASP
@periode varchar(10)
AS
BEGIN
set @periode='%'+@periode

select d.department,
isnull(satu.counter,0) as belumasp, 
isnull(dua.counter,0) as sudahasp, 
isnull(tot.counter,0) as total  
from department d 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.isasesmenperawat=0 and r.isdeleted=0 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) satu on d.iddepartment=satu.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.isasesmenperawat=1 and r.isdeleted=0 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) dua on d.iddepartment=dua.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.isdeleted=0 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) tot on d.iddepartment=tot.iddepartment 
where d.iddepartment in (
select value from sys_appsetting where variable in('idemergencydept','idicudept','idinpatientdept','idlabdept','idnicudept','idoperatingdept','idoutpatientdept','idpicudept','idphysiodept','idraddept')
)
order by d.department asc

END