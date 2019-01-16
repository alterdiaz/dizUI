CREATE PROCEDURE dbo.spAppointmentByID
@id as bigint
AS
BEGIN
select 
a.idappointment, 
a.idjadwalsesi, 
js.nama as jadwalsesi,
convert(varchar,a.appointmentdate,105) + ' ' + convert(varchar,a.appointmentdate,108) as appointmentdate, 
convert(varchar,a.bookingdate,105) as bookingdate, 
a.bookingstatus, 
a.nomorurut, 
a.idrekammedis, 
isnull(dbo.fFormatNoRM(rm.rekammedisno),0) as rekammedisno,
case 
when isnull(rm.nama,'-')='-' 
then a.nama 
else rm.nama
end as nama, 
a.telepon1, 
a.telepon2, 
a.jeniskelamin as idjeniskelamin, 
sx.generalcode as jeniskelamin, 
convert(varchar,a.tanggallahir,105) as tanggallahir, 
a.remarks, 
a.alamat, 
a.idnegara, 
n.wilayah as negara, 
a.idpropinsi, 
isnull(p.wilayah,'-') as propinsi, 
a.idkabupaten, 
isnull(b.wilayah,'-') as kabupaten, 
a.idkecamatan, 
isnull(c.wilayah,'-') as kecamatan, 
a.idkelurahan, 
isnull(l.wilayah,'-') as kelurahan, 
a.idregistrasi, 
isnull(r.registrasino,'-') as registrasino, 
convert(varchar,r.registrasidate,105) as registrasidate, 
a.issms, 
a.issmssent, 
a.isdeleted, 
a.createdby, 
cu.username as createduser, 
a.updatedby, 
uu.username as updateduser, 
convert(varchar,a.createddate,105) + ' ' + convert(varchar,a.createddate,108) as createddate, 
convert(varchar,a.updateddate,105) + ' ' + convert(varchar,a.updateddate,108) as updateddate 
from appointment a 
left join jadwalsesi js 
on a.idjadwalsesi=js.idjadwalsesi
left join registrasi r 
on a.idregistrasi=r.idregistrasi 
left join rekammedis rm 
on a.idrekammedis=rm.idrekammedis 
left join wilayah n on n.idwilayah=a.idnegara and n.idlevelwilayah=1 
left join wilayah p on p.idwilayah=a.idpropinsi and n.idlevelwilayah=2 
left join wilayah b on b.idwilayah=a.idkabupaten and n.idlevelwilayah=3 
left join wilayah c on c.idwilayah=a.idkecamatan and n.idlevelwilayah=4 
left join wilayah l on l.idwilayah=a.idkelurahan and n.idlevelwilayah=5 
left join sys_generalcode sx on a.jeniskelamin=sx.idgeneral and sx.gctype='SEXTYPE' 
left join sys_user cu on a.createdby=cu.iduser 
left join sys_user uu on a.updatedby=uu.iduser 
where a.idappointment= @id  
END
