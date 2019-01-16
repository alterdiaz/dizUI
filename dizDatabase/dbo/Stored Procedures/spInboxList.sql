CREATE PROCEDURE [dbo].[spInboxList]
@idusr as bigint
AS
BEGIN
select um.idusermessages
,convert(varchar,um.idsender) + '-' + convert(varchar,um.idreceiver) as objid
,s.username as sender
,r.username as receiver
,case when um.idsender<>@idusr then um.idsender else um.idreceiver end as userid  
,case when um.idsender<>@idusr then s.username else r.username end as username 
,um.[message]
,gc.generalcode as messagestatus
,um.sendingdate as tglkirim
,convert(varchar,um.sendingdate,105) + ' ' + convert(varchar,um.sendingdate,108) as sendingdate
,convert(varchar,um.updateddate,105) + ' ' + convert(varchar,um.updateddate,108) as updateddate
from sys_usermessages um 
left join sys_user s on um.idsender=s.iduser 
left join sys_user r on um.idreceiver=r.iduser 
left join sys_generalcode gc on um.messagestatus=gc.idgeneral and gc.gctype='ISMESSAGE'
where um.isdeleted=0 and um.idusermessages in (
select um.idusermessages from (
select max(um.idusermessages) as idusermessages,
case when um.idsender<>@idusr then um.idsender else um.idreceiver end as iduser  
from sys_usermessages um 
where (um.idsender=@idusr and um.idreceiver in (
select distinct 
case when um.idsender<>@idusr then um.idsender else um.idreceiver end as iduser 
from sys_usermessages um 
where um.idsender=@idusr or um.idreceiver=@idusr )) 
or 
(um.idreceiver=@idusr and um.idsender in (
select distinct 
case when um.idsender<>@idusr then um.idsender else um.idreceiver end as iduser 
from sys_usermessages um 
where um.idsender=@idusr or um.idreceiver=@idusr 
))
group by case when um.idsender<>@idusr then um.idsender else um.idreceiver end 
) um )
order by um.sendingdate desc

END

