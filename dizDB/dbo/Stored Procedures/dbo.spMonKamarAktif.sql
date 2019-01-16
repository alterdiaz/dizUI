CREATE PROCEDURE [dbo].[spMonKamarAktif]
AS
BEGIN

	select distinct 
    reg.idregistrasi as id,
    k.kelas,
    l.nama as content,
    sk.generalcode as bedstatus,
    isnull(reg.registrasino,'-') as registrasino,
    isnull(convert(varchar,reg.registrasidate,105) +' '+convert(varchar,reg.registrasidate,108),'-') as registrasidate,
    isnull(dbo.fFormatNoRM(rm.rekammedisno),'-') as rekammedisno,
    isnull(rm.nama,'-') as nama,
    isnull(convert(varchar,km.checkin,105) +' '+convert(varchar,km.checkin,108),'-') as checkin,
	isnull(sex.generalcode,'-') as jeniskelamin,
    isnull(dbo.fUmur(rm.tanggallahir),'-') as umur,
    isnull(convert(varchar,rm.tanggallahir,105),'-') as tanggallahir,
    isnull(par.nama,'-') as paramedis,
    isnull(parc.nama,'-') as paramedisc
	from registrasi reg 
	left join lokasi l on reg.idlokasi=l.idlokasi 
    left join kelaskamar kk on l.idlokasi=kk.idlokasi 
	left join kelas k on kk.idkelas=k.idkelas 
	left join kamar km on km.idlokasi=reg.idlokasi 
	left join sys_generalcode sk on sk.idgeneral=isnull(km.statusbed,1) and sk.gctype='BEDSTATUS' 
	left join rekammedis rm on reg.idrekammedis=rm.idrekammedis 
	left join sys_generalcode sex on sex.idgeneral=rm.jeniskelamin and sex.gctype='SEXTYPE' 
	left join paramedis par on reg.iddokterruangan=par.idparamedis
	left join paramedis parc on reg.iddoktercase=parc.idparamedis
	where reg.registrasistatus=0
	and reg.iddepartment=(select value from sys_appsetting where variable='IDInpatientDept') 
	order by k.kelas asc,l.nama asc


END