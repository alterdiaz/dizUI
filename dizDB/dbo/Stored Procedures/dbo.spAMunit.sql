CREATE PROCEDURE dbo.spAMunit
@id as bigint
AS
BEGIN
select u.idunit,u.unit,a.alamat,k.wilayah as kota,p.phone,pk.phone as fax,e.email, 
isnull(a.alamat,'') + ' ' + isnull(k.wilayah,'')  + char(13) + char(10) + 'Telp. ' + isnull(p.phone,0) +' Fax. '+ isnull(pk.phone,0)  + char(13) + char(10) + 'Email '+ isnull(e.email,'-') as notes
from unit u 
left join alamat a on a.idreff=u.idunit and a.tablereff='UNIT' 
left join phone p on p.idreff=u.idunit and p.tablereff='UNIT' and p.isprimary=1 and p.phonetype=1 
left join phone pk on pk.idreff=u.idunit and pk.tablereff='UNIT' and pk.isprimary=1 and pk.phonetype=4 
left join email e on e.idreff=u.idunit and e.tablereff='UNIT' and e.isprimary=1 and e.emailtype=2 
left join wilayah k on a.idkabupaten=k.idwilayah 
where u.idunit=
(select r.idunit
from assessment a 
left join registrasi r on a.idregistrasi=r.idregistrasi 
where a.idassessment=@id
)
END
