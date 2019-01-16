CREATE PROCEDURE dbo.spParamedisJadwal
AS
BEGIN
  
select pj.idunit,u.unit,pj.hari,ps.idparamedisspesialis,p.idparamedis,s.idspesialis,p.nama,s.nama as spesialis, 
case 
when p.paramedistype=1 then s.nama 
when p.paramedistype<>1 then p.nama 
end as paramedis, 
pj.idparamedisjadwal, pj.idjadwalsesi, pj.idlokasi, pj.isparamedissms, pj.ispasiensms, pj.ismonitor, 
pj.isdeleted, js.nama as sesi,l.nama as lokasi, 
case 
when pj.hari like '%0%' then 'Ya' 
else 'Tidak' 
end as minggu, 
case 
when pj.hari like '%1%' then 'Ya' 
else 'Tidak' 
end as senin, 
case  
when pj.hari like '%2%' then 'Ya' 
else 'Tidak' 
end as selasa, 
case 
when pj.hari like '%3%' then 'Ya' 
else 'Tidak' 
end as rabu, 
case 
when pj.hari like '%4%' then 'Ya' 
else 'Tidak' 
end as kamis, 
case 
when pj.hari like '%5%' then 'Ya' 
else 'Tidak' 
end as jumat, 
case  
when pj.hari like '%6%' then 'Ya' 
else 'Tidak' 
end as sabtu, 
sd.generalcode as statdata, convert(varchar,pj.tanggalmulai,105) as tanggalmulai, convert(varchar,pj.tanggalselesai,105) as tanggalselesai, 
substring(convert(varchar,pj.jammulai,108),0,6) as jammulai, 
substring(convert(varchar,pj.jamselesai,108),0,6) as jamselesai, 
pj.maxapp, pj.durasi, prs.generalcode as paramedissms, pps.generalcode as pasiensms, pms.generalcode as monitor, 
pj.remarks 
from paramedisjadwal pj 
left join unit u on pj.idunit=u.idunit 
left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis and ps.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join paramedis p on ps.idparamedis=p.idparamedis and p.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join spesialis s on ps.idspesialis=s.idspesialis and s.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join jadwalsesi js on js.idjadwalsesi=pj.idjadwalsesi and js.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join lokasi l on pj.idlokasi=l.idlokasi and l.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join sys_generalcode sd on pj.isdeleted=sd.idgeneral and sd.gctype='DELETE' 
left join sys_generalcode prs on pj.isparamedissms=prs.idgeneral and prs.gctype='ISSMS' 
left join sys_generalcode pps on pj.ispasiensms=pps.idgeneral and pps.gctype='ISSMS' 
left join sys_generalcode pms on pj.ismonitor=pms.idgeneral and pms.gctype='ISMONITOR' 
where pj.isdeleted<>2 
order by s.nama asc,p.nama asc
  
END
