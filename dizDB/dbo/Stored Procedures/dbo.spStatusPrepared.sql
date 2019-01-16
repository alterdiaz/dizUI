CREATE PROCEDURE dbo.spStatusPrepared
@periode varchar(10)
AS
BEGIN
set @periode='%'+@periode

select d.department, 
isnull(prep.counter,0) as prep, 
isnull(prepd.counter,0) as prepd, 
isnull(rcv.counter,0) as rcv, 
isnull(rcvd.counter,0) as rcvd 
from department d 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.prepareddate is null and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) prep on d.iddepartment=prep.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.prepareddate is not null and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) prepd on d.iddepartment=prepd.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.receiveddate is null and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) rcv on d.iddepartment=rcv.iddepartment 
left join (
select count(r.idregistrasi) as counter,r.iddepartment 
from registrasi r 
where r.receiveddate is not null and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) rcvd on d.iddepartment=rcvd.iddepartment 
where d.iddepartment in (
select value from sys_appsetting where variable in('idemergencydept','idicudept','idinpatientdept','idlabdept','idnicudept','idoperatingdept','idoutpatientdept','idpicudept','idphysiodept','idraddept')
)
order by d.department asc

END