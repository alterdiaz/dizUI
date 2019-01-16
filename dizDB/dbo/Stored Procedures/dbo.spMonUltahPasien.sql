CREATE PROCEDURE [dbo].[spMonUltahPasien]
@tanggal as date 
AS
BEGIN
select ROW_NUMBER() OVER (Order by rm.rekammedisno asc) as nomor,
rm.idrekammedis,
dbo.fFormatNoRM(rm.rekammedisno) as norm,
rm.nama+', '+sap.generalcode as nama, 
jk.generalcode as jeniskelamin,
convert(varchar,rm.tanggallahir,105) as tanggallahir,
dbo.fUmurregister(rm.tanggallahir,@tanggal) as umur, 
isnull(p.phone,0) as telepon 
from rekammedis rm 
left join phone p on p.idreff=rm.idrekammedis and p.tablereff='PASIEN' and p.isprimary=1 and p.phonetype=3 
left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE'
left join sys_generalcode sap on rm.sapaan=sap.idgeneral and sap.gctype='SAPAAN' 
where day(rm.tanggallahir)=day(@tanggal) and month(rm.tanggallahir)=month(@tanggal) and rm.rekammedisno<>0
order by rm.rekammedisno asc

END
