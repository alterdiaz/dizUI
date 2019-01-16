CREATE PROCEDURE dbo.spRegistrasiPasienDept
@iddept bigint
AS
BEGIN

select 
r.idregistrasi, 
r.idlokasi,
r.transactiontype,
convert(bit,0) as cek,
case 
when p.rekammedisno<>0 then
dbo.fFormatNoRM(p.rekammedisno) 
when p.rekammedisno=0 then
'A P S'
end
as norm,
convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as registrasidate,
r.registrasino,
dbo.fUmurRegister(p.tanggallahir,r.registrasidate) as umur,
p.nama + ' ,' + np.generalcode as namapasien,
jk.generalcode as sex,
pa.nama as paramedis,
isnull(s.nama,'-') as spesialis,
isnull(l.nama,'-') as lokasi,
isnull(kal.nama,'-') as kamar,
isnull(ke.kelas,'-') as kelas,
pt.generalcode as payertype, 
isnull(pay.nama,'-') as payer,
isnull(asr.nama,'-') as asuransi,
sr.generalcode as regstatus 
from registrasi r 
left join rekammedis p on r.idrekammedis=p.idrekammedis and p.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join sys_generalcode jk on p.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' 
left join sys_generalcode np on p.sapaan=np.idgeneral and np.gctype='SAPAAN' 
left join sys_generalcode pt on r.payertype=pt.idgeneral and pt.gctype='PAYERTYPE' 
left join sys_generalcode sr on r.registrasistatus=sr.idgeneral and sr.gctype='REGSTATUS' 
left join unit u on r.idunit=u.idunit and u.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join lokasi l on r.idlokasi=l.idlokasi and l.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join paramedis pa on r.iddokterruangan=pa.idparamedis and pa.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join spesialis s on r.idspesialisruangan=s.idspesialis and s.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join kamar ka on r.idlokasi=ka.idkamar and pa.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join lokasi kal on ka.idlokasi=kal.idlokasi and kal.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join kelas ke on r.idkelas=ke.idkelas and ke.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join businesspartner pay on r.idpayer=pay.idbusinesspartner and pay.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join businesspartner asr on r.idasuransi=asr.idbusinesspartner and asr.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
where r.isdeleted=0 and r.registrasistatus=0 and 
r.iddepartment=@iddept and
r.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
order by r.registrasino asc

END