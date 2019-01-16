CREATE PROCEDURE dbo.spStatusASM
@periode varchar(10)
AS
BEGIN
set @periode='%'+@periode

select d.department,
isnull(satu.counter,0) as belumasm, 
isnull(dua.counter,0) as sudahasm, 
isnull(tot.counter,0) as total  
from department d 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.isasesmenmedis=0 and r.isdeleted=0 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) satu on d.iddepartment=satu.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.isasesmenmedis=1 and r.isdeleted=0 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) dua on d.iddepartment=dua.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.isdeleted=0 and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) tot on d.iddepartment=tot.iddepartment 
where d.iddepartment in (
select value from sys_appsetting where variable in('idemergencydept','idicudept','idinpatientdept','idnicudept','idoperatingdept','idoutpatientdept','idpicudept','idphysiodept')
)
order by d.department asc

END