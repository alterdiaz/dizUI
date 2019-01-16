CREATE PROCEDURE dbo.spStatusAppointment
@periode varchar(10)
AS
BEGIN
set @periode='%'+@periode

select bs.generalcode as appstat,isnull(cnt.counter,0) as counter
from sys_generalcode bs 
left join (
select bs.idgeneral,count(a.idappointment) as counter 
from appointment a 
right join sys_generalcode bs on a.bookingstatus=bs.idgeneral and bs.gctype='BOOKINGSTAT'
where convert(varchar,a.bookingdate,105) like @periode 
group by bs.idgeneral  
) cnt on cnt.idgeneral=bs.idgeneral 
where bs.gctype='BOOKINGSTAT'

END