CREATE PROCEDURE [dbo].[spMessagesHD]
@iduser bigint
AS
BEGIN
	select hd.idusermessageshd
    ,hd.idreceiver
    ,hd.idsender
    ,case when sender.namalengkap='' then 'noname' else sender.namalengkap end as sender
    ,case when receiver.namalengkap='' then 'noname' else receiver.namalengkap end as receiver
    ,hd.lastmessage,convert(varchar,hd.lastdate,105)+' '+convert(varchar,hd.lastdate,108) as lastdate
    ,hd.ismessagenew
	from sys_usermessageshd hd 
	left join sys_user sender 
	on hd.idsender=sender.iduser 
	left join sys_user receiver 
	on hd.idreceiver=receiver.iduser 
	where hd.isdeleted=0 and hd.idsender=@iduser
END


