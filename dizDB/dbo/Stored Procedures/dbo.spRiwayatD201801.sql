CREATE PROCEDURE dbo.spRiwayatD201801
@id bigint
AS
BEGIN
select upper(rt.generalcode) as riwayattype,isnull(rp.riwayat,'-') as riwayat 
from riwayatpasien rp 
left join sys_generalcode rt on rt.idgeneral=rp.riwayattype and rt.gctype='RIWAYATTYPE'
where rp.idreff2=@id and rp.tablereff2='REGISTRASI' and rp.riwayattype = 2 and rp.isdeleted=0
order by rp.riwayattype asc
END
