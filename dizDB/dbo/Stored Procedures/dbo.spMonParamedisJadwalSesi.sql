CREATE PROCEDURE dbo.spMonParamedisJadwalSesi
@paramedis bigint,@tanggal date,@hari varchar
AS
BEGIN

select pj.idjadwalsesi as id,js.nama + ' (' + left(convert(varchar,pj.jammulai,108),5) + '-' + LEFT(convert(varchar,pj.jamselesai,108),5) +')' as content,
case when pj.durasi=0 then DATEDIFF(minute,pj.jammulai,pj.jamselesai)/pj.maxapp else pj.durasi end as durasi,
case when pj.maxapp=0 then DATEDIFF(minute,pj.jammulai,pj.jamselesai)/pj.durasi else pj.maxapp end as maxapp,
pj.maxapp,LEFT(convert(varchar,pj.jammulai,108),5) as jammulai,LEFT(convert(varchar,pj.jamselesai,108),5) as jamselesai
from paramedisjadwal pj 
left join jadwalsesi js on pj.idjadwalsesi=js.idjadwalsesi 
left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis 
where pj.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
and pj.hari like '%'+ @hari +'%'
and pj.idparamedisspesialis=@paramedis
and (pj.tanggalmulai <= @tanggal and pj.tanggalselesai >= @tanggal) 
and pj.isdeleted<>2 
order by content asc

END
