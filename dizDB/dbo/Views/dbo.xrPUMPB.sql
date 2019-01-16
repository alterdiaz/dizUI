CREATE VIEW [dbo].[xrPUMPB] AS 
select p.idpengajuan,p.nopengajuan,
convert(varchar,p.tanggalpengajuan,105) + ' ' + convert(varchar,p.tanggalpengajuan,108) as tanggalpengajuan, 
p.jumlahuang, p.hurufuang, p.namapemohon, p.jabatanpemohon, p.keperluan, 
p.namareview, convert(varchar,p.tanggalreview,105) + ' ' + convert(varchar,p.tanggalreview,108) as tanggalreview, 
isnull(p.namakabid,'') as namakabid, convert(varchar,p.tanggalkabid,105) + ' ' + convert(varchar,p.tanggalkabid,108) as tanggalkabid, 
isnull(p.namadirektur,'') as namadirektur, convert(varchar,p.tanggaldirektur,105) + ' ' + convert(varchar,p.tanggaldirektur,108) as tanggaldirektur, 
sr.generalcode as deleted,p.rejectreason 
from pengajuan p 
left join sys_generalcode sr on p.isdeleted=sr.idgeneral and sr.gctype='REJECT'
where p.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID')
