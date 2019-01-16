CREATE PROCEDURE dbo.spRiwayatA201801
@id bigint
AS
BEGIN
select upper(rt.generalcode) as riwayattype,
isnull(rp.riwayat,'-') as riwayat,
isnull(rp.reaksi,'-') as reaksi 
from riwayatpasien rp 
left join sys_generalcode rt on rt.idgeneral=rp.riwayattype and rt.gctype='RIWAYATTYPE'
where rp.idreff2=@id and rp.tablereff2='REGISTRASI' and rp.riwayattype=4 and rp.riwayatalergitype=8 and rp.isdeleted=0
order by rp.riwayattype asc
END
