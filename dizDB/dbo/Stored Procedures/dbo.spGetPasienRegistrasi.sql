CREATE PROCEDURE [dbo].[spGetPasienRegistrasi]
@idrm as bigint
AS
BEGIN

select p.idrekammedis,
p.asalpx,
p.asalpx2,
p.asalrujukan,
p.iddokterrujukan,
dbo.fFormatNoRM(p.rekammedisno) as rekammedisno,
isnull(ct.generalcode,'-') as jeniskartu,
isnull(k.nomorkartu,'-') as nomorkartu,
p.namapanggilan,
p.nama,
p.jeniskelamin as idjeniskelamin,
jk.generalcode as jeniskelamin,
isnull(p.ishamil,0) as ishamil,
p.golongandarah as idgolongandarah,
gd.generalcode as golongandarah,
p.rhesus as idrhesus,
rh.generalcode as rhesus,
p.kewarganegaraan,
w.wilayah as warganegara,
convert(varchar,p.tanggallahir,105) as tanggallahir,
dbo.fUmur(p.tanggallahir) as usia,
isnull(ne.wilayah + char(13) + char(10) + 
pr.wilayah + char(13) + char(10) + 
kb.wilayah + char(13) + char(10) + 
kc.wilayah + char(13) + char(10) + 
kl.wilayah + char(13) + char(10) + 
a.alamat,'-') as alamat
from rekammedis p
left join (
select top 1 k.idkartu,k.nomorkartu,k.idreff,k.jeniskartu 
from kartu k 
where k.idreff=@idrm and k.tablereff='PASIEN' and k.isprimary=1 and k.isdeleted=0
and k.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
order by k.idkartu desc
) k on p.idrekammedis=k.idreff 
left join sys_generalcode ct on k.jeniskartu=ct.idgeneral and ct.gctype='CARDTYPE' 
left join sys_generalcode jk on p.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE'
left join sys_generalcode gd on p.golongandarah=gd.idgeneral and gd.gctype='GOLONGANDARAH'
left join sys_generalcode rh on p.rhesus=rh.idgeneral and rh.gctype='RHESUS'
left join wilayah w on p.kewarganegaraan=w.idwilayah and w.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join (
select top 1 a.idalamat,a.idreff,a.tablereff,a.idcompany,a.alamat,a.idnegara,a.idpropinsi,a.idkabupaten,a.idkecamatan,a.idkelurahan,a.isprimary,a.isdeleted 
from alamat a 
where a.idreff=@idrm 
and a.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
and a.tablereff='PASIEN' 
and a.isprimary=1 
and isnull(a.isdeleted,0)=0
) a on p.idrekammedis=a.idreff 
left join wilayah ne on a.idnegara=ne.idwilayah and ne.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join wilayah pr on a.idpropinsi=pr.idwilayah and pr.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join wilayah kb on a.idkabupaten=kb.idwilayah and kb.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join wilayah kc on a.idkecamatan=kc.idwilayah and kc.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
left join wilayah kl on a.idkelurahan=kl.idwilayah and kl.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
where p.idrekammedis=@idrm 

END
