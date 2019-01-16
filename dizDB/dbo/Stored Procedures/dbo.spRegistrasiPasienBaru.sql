CREATE PROCEDURE [dbo].[spRegistrasiPasienBaru]
@idrm as bigint
AS
BEGIN
select r.idrekammedis,
dbo.fTanggalLokal(r.createddate,'ID') as tanggalregistrasi,
isnull(krttyp.generalcode + ' ' + krt.nomorkartu,'-') as idcard,
isnull(gdr.generalcode + ' (' + rhs.generalcode +')','-') as goldar,
dbo.fFormatNoRM(r.rekammedisno) as norm,
r.nama,
isnull(k.wilayah,'-') as kotalahir,
dbo.fTanggalLokal(r.tanggallahir,'ID') as tanggallahir,
dbo.fUmur(r.tanggallahir) as umur,
isnull(jk.generalcode,'-') as jeniskelamin,
isnull(st.generalcode,'-') as pernikahan,
isnull(re.generalcode,'-') as agama,
isnull(pk.generalcode,'-') as pekerjaan,
isnull(pd.generalcode,'-') as pendidikan,
isnull(a.alamat,'-') as alamat,
isnull(ak.wilayah,'-') as alamatkota,
isnull(a.kodepos,'-') as kodepos,
isnull(hr.phone,'-') as telprumah,
isnull(hk.phone + ' ('+hk.extension+')','-') as telpkantor,
isnull(hh.phone,'-') as telpcell,
isnull(em.email,'-') as email,
isnull(kel.nama,'-') as kelnama,
isnull(famtyp.generalcode,'-') as keljenis,
isnull(akel.alamat,'-') as kelalamat,
isnull(akelw.wilayah,'-') as kelkota,
isnull(hrk.phone,'-') as kelrumah,
isnull(hhk.phone,'-') as kelcell,
isnull(payt.generalcode,'-') as payertype
from rekammedis r
left join wilayah k on r.kotalahir=k.idwilayah and k.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID')
left join sys_generalcode rhs on r.rhesus=rhs.idgeneral and rhs.gctype='RHESUS'
left join sys_generalcode gdr on r.golongandarah=gdr.idgeneral and gdr.gctype='GOLONGANDARAH'
left join sys_generalcode jk on r.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE'
left join sys_generalcode st on r.pernikahan=st.idgeneral and st.gctype='MARITALSTATUS'
left join sys_generalcode re on r.agama=re.idgeneral and re.gctype='RELIGION'
left join sys_generalcode pk on r.pekerjaan=pk.idgeneral and pk.gctype='PEKERJAAN'
left join sys_generalcode pd on r.pendidikan=pd.idgeneral and pd.gctype='PENDIDIKAN'
left join (
select top 1 a.idalamat,a.idkabupaten,a.alamat,a.kodepos,a.idreff,a.tablereff 
from alamat a 
where a.idreff=@idrm and a.tablereff='PASIEN' and a.isprimary=1 and a.isdeleted=0 and a.addresstype=2 
and a.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting 
where variable='CompanyID') order by a.idalamat desc
) a on r.idrekammedis=a.idreff 
left join wilayah ak on a.idkabupaten=ak.idwilayah 
left join (
select top 1 p.idphone,p.idreff,p.phone,p.extension 
from phone p 
where p.idreff=@idrm and p.tablereff='PASIEN' and p.isprimary=1 and p.isdeleted=0 and p.phonetype=2 
and p.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
order by p.idphone desc
) hr on r.idrekammedis=hr.idreff 
left join (
select top 1 p.idphone,p.idreff,p.phone,p.extension 
from phone p 
where p.idreff=@idrm and p.tablereff='PASIEN' and p.isprimary=1 and p.isdeleted=0 and p.phonetype=1 
and p.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
order by p.idphone desc
) hk on r.idrekammedis=hk.idreff 
left join (
select top 1 p.idphone,p.idreff,p.phone,p.extension 
from phone p 
where p.idreff=@idrm and p.tablereff='PASIEN' and p.isprimary=1 and p.isdeleted=0 and p.phonetype=3 
and p.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
order by p.idphone desc
) hh on r.idrekammedis=hh.idreff 
left join (
select top 1 e.idemail,e.idreff,e.email 
from email e 
where e.idreff=@idrm and e.tablereff='PASIEN' and e.isprimary=1 and e.isdeleted=0 and e.emailtype=1 
and e.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
order by e.idemail desc
) em on r.idrekammedis=em.idreff 
left join (
select top 1 k.idkeluarga,k.idreff,k.nama,k.familytype 
from keluarga k 
where k.idreff=@idrm and k.tablereff='PASIEN' and k.isdeleted=0 
and k.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
order by k.idkeluarga desc
) kel on kel.idreff=r.idrekammedis 
left join sys_generalcode famtyp on kel.familytype=famtyp.idgeneral and famtyp.gctype='FAMILYTYPE'
left join 
(
select top 1 a.idalamat,a.idkabupaten,a.alamat,a.kodepos,a.idreff 
from alamat a 
where a.idreff=@idrm and a.tablereff='KELUARGAPASIEN' and a.isprimary=1 and a.isdeleted=0 and a.addresstype=2 
and a.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') order by a.idalamat desc
) akel on r.idrekammedis=akel.idreff 
left join wilayah akelw on akel.idkabupaten=akelw.idwilayah and akelw.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID')
left join (
select top 1 p.idphone,p.idreff,p.phone,p.extension 
from phone p left join keluarga k on p.idreff=k.idkeluarga and p.tablereff='KELUARGAPASIEN'
where k.idreff=@idrm and k.tablereff='PASIEN' and p.isprimary=1 and p.isdeleted=0 and p.phonetype=2 
and p.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
order by p.idphone desc
) hrk on kel.idkeluarga=hrk.idreff 
left join (
select top 1 p.idphone,p.idreff,p.phone,p.extension 
from phone p left join keluarga k on p.idreff=k.idkeluarga and p.tablereff='KELUARGAPASIEN'
where k.idreff=@idrm and k.tablereff='PASIEN' and p.isprimary=1 and p.isdeleted=0 and p.phonetype=3 
and p.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
order by p.idphone desc
) hhk on kel.idkeluarga=hhk.idreff  
left join (
select top 1 k.idkartu,k.nomorkartu,k.idreff,k.jeniskartu 
from kartu k 
where k.idreff=@idrm and k.tablereff='PASIEN' and k.isprimary=1 and k.isdeleted=0 
and k.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
order by k.idkartu desc
) krt on r.idrekammedis=krt.idreff 
left join sys_generalcode krttyp on krt.jeniskartu=krttyp.idgeneral and krttyp.gctype='CARDTYPE'
left join ( 
select top 1 reg.idrekammedis,reg.payertype from registrasi reg where reg.idrekammedis=@idrm and reg.isdeleted=0 and reg.registrasistatus=6 and reg.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') order by idregistrasi desc
) reg on reg.idrekammedis=r.idrekammedis 
left join sys_generalcode payt on payt.idgeneralcode=reg.payertype and payt.gctype='PAYERTYPE' 
where r.idrekammedis=@idrm and r.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
END
