CREATE PROCEDURE dbo.spRegistrasiSlip
@idreg as bigint
AS
BEGIN
select 
r.idrekammedis, 
case 
when p.rekammedisno<>0 then
dbo.fFormatNoRM(p.rekammedisno) 
when p.rekammedisno=0 then
'A P S'
end
as norm,
r.registrasino as regno,
'No. Registrasi : ' + r.registrasino as registrasino,
p.nama + ' ,' + np.generalcode as namapasien,
convert(varchar,p.tanggallahir,105) as tanggallahir,
jk.generalcode as sex,
pa.nama as paramedis,
isnull(s.nama,'-') as spesialis,
isnull(pe.pelayanan,'-') as pelayanan,
isnull(l.nama,'-') as lokasi,
isnull(kal.nama,'-') as kamar,
isnull(ke.kelas,'-') as kelas,
pt.generalcode as payertype, 
isnull(pay.nama,'-') as payer,
isnull(asr.nama,'-') as asuransi,
dbo.fRegNoUrut(r.idregistrasi,r.iddokterruangan,r.registrasidate,r.idjadwalsesi) as nourut
from registrasi r 
left join rekammedis p on r.idrekammedis=p.idrekammedis and p.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join sys_generalcode jk on p.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' 
left join sys_generalcode np on p.sapaan=np.idgeneral and np.gctype='SAPAAN' 
left join sys_generalcode pt on r.payertype=pt.idgeneral and pt.gctype='PAYERTYPE' 
left join unit u on r.idunit=u.idunit and u.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join lokasi l on r.idlokasi=l.idlokasi and l.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join paramedis pa on r.iddokterruangan=pa.idparamedis and pa.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join spesialis s on r.idspesialisruangan=s.idspesialis and s.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join pelayananspesialis ps on ps.idspesialis=r.idspesialisruangan 
left join pelayanan pe on ps.idpelayanan=pe.idpelayanan 
left join kamar ka on r.idlokasi=ka.idkamar and pa.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join lokasi kal on ka.idlokasi=kal.idlokasi and kal.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join kelas ke on r.idkelas=ke.idkelas and ke.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join businesspartner pay on r.idpayer=pay.idbusinesspartner and pay.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join businesspartner asr on r.idasuransi=asr.idbusinesspartner and asr.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
where r.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
and r.idregistrasi=@idreg 
END
