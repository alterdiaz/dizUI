CREATE PROCEDURE dbo.spStatusResponTime
@periode varchar(10)
AS
BEGIN
set @periode='%'+@periode

select d.department,
convert(bigint,case when prep.preptime is null then '0' else convert(varchar,isnull(prep.preptime,0)) end) 
as preptime,
convert(bigint,case when recv.recvtime is null then '0' else convert(varchar,isnull(recv.recvtime,0)) end) 
as recvtime  
from department d 
left join (
select MIN(dbo.fumurdetik2(r.registrasidate,r.prepareddate)) as preptime,r.iddepartment 
from registrasi r 
where r.prepareddate is not null and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) prep on d.iddepartment=prep.iddepartment 
left join (
select MIN(dbo.fumurdetik2(r.prepareddate,r.receiveddate)) as recvtime,r.iddepartment 
from registrasi r 
where r.receiveddate is not null and convert(varchar,r.createddate,105) like @periode 
group by r.iddepartment 
) recv on d.iddepartment=recv.iddepartment 
where d.iddepartment in (
select value from sys_appsetting where variable in('idemergencydept','idicudept','idinpatientdept','idlabdept','idnicudept','idoperatingdept','idoutpatientdept','idpicudept','idphysiodept','idraddept')
)
order by d.department asc

END