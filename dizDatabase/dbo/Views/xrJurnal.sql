CREATE VIEW [dbo].[xrJurnal] AS 
select j.idjurnal,j.tanggaljurnal as datejurnal, convert(varchar,j.tanggaljurnal,105)+' '+ convert(varchar,j.tanggaljurnal,108) as tanggaljurnal,j.idreff,j.tbreff,j.idcoalama,j.idcoa,
  c.coa as coabaru,l.coa as coalama,c.remarks as rekening,j.remarks,j.jumlahuang,j.posisidk,gc.generalcode as dk,j.isdeleted from jurnal j left join coa c on j.idcoa=c.idcoa left join coa l on j.idcoalama=l.idcoa left join sys_generalcode gc on j.posisidk=gc.idgeneral and gc.gctype='POSISIDK'
