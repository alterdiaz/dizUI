CREATE PROCEDURE [dbo].[spMsgList]
	@idusr as bigint,
	@idrcv as bigint
AS
BEGIN
	select um.idusermessages
	,um.idsender
	,um.idreceiver
	,um.[message]
	,convert(varchar,um.sendingdate,105) +' '+ convert(varchar,um.sendingdate,108) as sendingdate
	,convert(varchar,um.updateddate,105) +' '+ convert(varchar,um.updateddate,108) as updateddate
	,ur.username as receiver
	,case when um.idsender=@idusr then 'Kamu' else us.username end as sender
	from sys_usermessages um
	left join sys_user us on um.idsender=us.iduser 
	left join sys_user ur on um.idreceiver=ur.iduser
	where um.isdeleted=0 and 
	(um.idsender=@idusr and um.idreceiver=@idrcv
	or um.idsender=@idrcv and um.idreceiver=@idusr)
	order by um.idusermessages asc 
END

