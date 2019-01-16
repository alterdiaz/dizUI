CREATE PROCEDURE dbo.spMessagesList
@idhd bigint
AS
BEGIN
select dt.idusermessagesdt,dt.idsender,dt.idreceiver,sender.namalengkap as sender,receiver.namalengkap as receiver,dt.[message],convert(varchar,dt.messagedate,105)+' '+convert(varchar,dt.messagedate,108)as messagedate,gc.generalcode as gcmessagestatus  
from sys_usermessagesdt dt 
left join sys_user sender on dt.idsender=sender.iduser 
left join sys_user receiver on dt.idreceiver=receiver.iduser 
left join sys_generalcode gc on gc.idgeneral=dt.messagestatus and gc.gctype='ISMESSAGE'
where dt.isdeleted=0 and dt.idusermessageshd=@idhd
END
