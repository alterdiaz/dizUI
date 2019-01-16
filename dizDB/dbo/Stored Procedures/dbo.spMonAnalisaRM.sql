CREATE PROCEDURE [dbo].[spMonAnalisaRM]
(@bulan bigint,
@tahun bigint
)AS
BEGIN
select 0 as nomor,
r.idregistrasi,
convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as regdate,
dbo.fFormatNoRM(rm.rekammedisno) as norm,
r.registrasino as regno,
rm.nama,
sx.generalcode as jeniskelamin,
convert(varchar,rm.tanggallahir,105) as tanggallahir,
dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as umur,
isnull(ks.generalcode,'Belum Asesmen Medis') as subyektif,
isnull(ko.generalcode,'Belum Asesmen Medis') as obyektif,
isnull(ka.generalcode,'Belum Asesmen Medis') as asesmen,
isnull(kp.generalcode,'Belum Asesmen Medis') as planning,
isnull(kl.generalcode,'Belum Asesmen Medis') as klpcm,
isnull(it.generalcode,'Belum Asesmen Medis') as jenisicd,
i.kode,
isnull(i.diagnosa,'Belum Asesmen Medis') as diagnosa
from registrasi r 
left join rekammedis rm on r.idrekammedis=rm.idrekammedis 
left join soapnote sn on sn.idregistrasi=r.idregistrasi 
left join analisarm ar on ar.idregistrasi=r.idregistrasi 
left join analisarmdt ad on ad.idregistrasi=r.idregistrasi and ad.analisarmtype=2
left join icd i on ad.idicd=i.idicd 
left join sys_generalcode kl on ar.klpcm=kl.idgeneral and kl.gctype='LENGKAPBERKAS'
left join sys_generalcode ks on ar.subyektif=ks.idgeneral and ks.gctype='LENGKAPBERKAS'
left join sys_generalcode ko on ar.obyektif=ko.idgeneral and ko.gctype='LENGKAPBERKAS'
left join sys_generalcode ka on ar.asesmen=ka.idgeneral and ka.gctype='LENGKAPBERKAS'
left join sys_generalcode kp on ar.planning=kp.idgeneral and kp.gctype='LENGKAPBERKAS'
left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE'
left join sys_generalcode sx on rm.jeniskelamin=sx.idgeneral and sx.gctype='SEXTYPE'
where r.iddepartment in (select [value] from sys_appsetting where variable in ('IDEmergencyDept','IDPhysioDept','IDOutpatientDept')) 
and year(r.registrasidate)=@tahun and month(r.registrasidate)=@bulan
and ad.isdeleted=0
order by r.registrasino desc
END
