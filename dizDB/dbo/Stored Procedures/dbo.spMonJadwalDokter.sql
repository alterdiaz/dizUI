CREATE PROCEDURE dbo.spMonJadwalDokter
@tglmulai as DATE,@tglselesai as date
AS
BEGIN
select 0 as nomor,pj.idparamedisjadwal,pj.idparamedisspesialis,isnull(pe.pelayanan,'-') as pelayanan,p.nama as paramedis,s.nama as spesialis,
isnull(hari0.jadwal,'-') as hr0,
isnull(hari1.jadwal,'-') as hr1,
isnull(hari2.jadwal,'-') as hr2,
isnull(hari3.jadwal,'-') as hr3,
isnull(hari4.jadwal,'-') as hr4,
isnull(hari5.jadwal,'-') as hr5,
isnull(hari6.jadwal,'-') as hr6
from paramedisjadwal pj 
left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis 
left join spesialis s on ps.idspesialis=s.idspesialis 
left join paramedis p on ps.idparamedis=p.idparamedis 
left join pelayananspesialis sp on sp.idspesialis=s.idspesialis 
left join pelayanan pe on sp.idpelayanan=pe.idpelayanan 
left join (
select pj.idparamedisjadwal,left(convert(varchar,pj.jammulai,108),5) + ' - '+ left(convert(varchar,pj.jamselesai,108),5) as jadwal 
from paramedisjadwal pj where pj.hari like '%0%') hari0 on hari0.idparamedisjadwal=pj.idparamedisjadwal  
left join (
select pj.idparamedisjadwal,left(convert(varchar,pj.jammulai,108),5) + ' - '+ left(convert(varchar,pj.jamselesai,108),5) as jadwal 
from paramedisjadwal pj where pj.hari like '%1%') hari1 on hari1.idparamedisjadwal=pj.idparamedisjadwal  
left join (
select pj.idparamedisjadwal,left(convert(varchar,pj.jammulai,108),5) + ' - '+ left(convert(varchar,pj.jamselesai,108),5) as jadwal 
from paramedisjadwal pj where pj.hari like '%2%') hari2 on hari2.idparamedisjadwal=pj.idparamedisjadwal  
left join (
select pj.idparamedisjadwal,left(convert(varchar,pj.jammulai,108),5) + ' - '+ left(convert(varchar,pj.jamselesai,108),5) as jadwal 
from paramedisjadwal pj where pj.hari like '%3%') hari3 on hari3.idparamedisjadwal=pj.idparamedisjadwal  
left join (
select pj.idparamedisjadwal,left(convert(varchar,pj.jammulai,108),5) + ' - '+ left(convert(varchar,pj.jamselesai,108),5) as jadwal 
from paramedisjadwal pj where pj.hari like '%4%') hari4 on hari4.idparamedisjadwal=pj.idparamedisjadwal  
left join (
select pj.idparamedisjadwal,left(convert(varchar,pj.jammulai,108),5) + ' - '+ left(convert(varchar,pj.jamselesai,108),5) as jadwal 
from paramedisjadwal pj where pj.hari like '%5%') hari5 on hari5.idparamedisjadwal=pj.idparamedisjadwal  
left join (
select pj.idparamedisjadwal,left(convert(varchar,pj.jammulai,108),5) + ' - '+ left(convert(varchar,pj.jamselesai,108),5) as jadwal 
from paramedisjadwal pj where pj.hari like '%6%') hari6 on hari6.idparamedisjadwal=pj.idparamedisjadwal  
where pj.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
and (pj.tanggalmulai <= @tglmulai and pj.tanggalselesai >= @tglselesai) 
and pj.isdeleted<>2 
order by pe.pelayanan asc,p.nama asc,s.nama asc
END
