CREATE PROCEDURE [dbo].[spMonRegisterIGDDay]
@tahun as integer,
@bulan as integer, 
@tanggal as integer
AS
BEGIN
select ROW_NUMBER() OVER (partition by parm.nama Order by r.idregistrasi asc) as nomor,
r.idregistrasi,
convert(varchar,r.registrasidate,105)+ ' '+convert(varchar,r.registrasidate,108) as regdate,
case 
when r.isoneday=1 then r.registrasino + ' (ODS)'
else r.registrasino 
end 
as regno,
dbo.fFormatNoRM(rm.rekammedisno) as norm,
rm.nama, 
jk.generalcode as jeniskelamin,
convert(varchar,rm.tanggallahir,105) as tanggallahir,
dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as umur,
isnull(a.alamat,'-') as alamat,
isnull(n.wilayah,'-') as negara,
isnull(p.wilayah,'-') as propinsi,
isnull(b.wilayah,'-') as kabupaten,
isnull(c.wilayah,'-') as kecamatan,
isnull(l.wilayah,'-') as kelurahan,
ap1.generalcode as asalpx,
case 
when r.asalpx=2 then apd.generalcode 
when r.asalpx=1 then apr.generalcode 
end as asalpx2,
case 
when r.asalpx=1 and r.asalpx2=1 then parr.nama 
when r.asalpx=1 and r.asalpx2=2 then bp.nama 
else '-' 
end as asalrujukan,
parm.nama as dokterruangan,
isnull(spe.nama,'-') as spesialisruangan,
u.unit,
dept.department,
case when r.kunjunganke=1 then 'Baru' else 'Lama' end as kunjungan,
r.remarks, 
sr.generalcode as regstatus,
asm.generalcode as asmed 
from registrasi r 
left join sys_generalcode sr on r.registrasistatus=sr.idgeneral and sr.gctype='REGSTATUS' 
left join rekammedis rm on r.idrekammedis=rm.idrekammedis 
left join alamat a on rm.idrekammedis=a.idreff and a.tablereff='PASIEN' and a.isprimary=1
left join wilayah n on a.idnegara=n.idwilayah 
left join wilayah p on a.idpropinsi=p.idwilayah 
left join wilayah b on a.idkabupaten=b.idwilayah 
left join wilayah c on a.idkecamatan=c.idwilayah 
left join wilayah l on a.idkelurahan=l.idwilayah 
left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE'
left join sys_generalcode ap1 on r.asalpx=ap1.idgeneral and ap1.gctype='ASALPX'
left join sys_generalcode apd on r.asalpx2=apd.idgeneral and apd.gctype='ASALPXDTG' 
left join sys_generalcode apr on r.asalpx2=apr.idgeneral and apr.gctype='ASALPXRUJ' 
left join sys_generalcode asm on r.isasesmenmedis=asm.idgeneral and asm.gctype='ISASESMEN' 
left join businesspartner bp on r.asalrujukan=bp.idbusinesspartner 
left join paramedis parr on r.asalrujukan=parr.idparamedis 
left join paramedis parm on r.iddokterruangan=parm.idparamedis 
left join spesialis spe on r.idspesialisruangan=spe.idspesialis
left join department dept on r.iddepartment=dept.iddepartment 
left join unit u on r.idunit=u.idunit 
where r.isdeleted=0 and 
year(r.registrasidate)=@tahun and month(r.registrasidate)=@bulan and day(r.registrasidate)=@tanggal and 
rm.rekammedisno<>0 and 
r.iddepartment=(
select top 1 value 
from sys_appsetting 
where variable='IDEmergencyDept'
)
order by r.idregistrasi desc
END