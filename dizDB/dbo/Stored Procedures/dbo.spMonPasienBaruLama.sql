CREATE PROCEDURE dbo.spMonPasienBaruLama
@periode bigint
AS
BEGIN
select 0 as nomor,MONTH(DATEADD(MM, s.number, CONVERT(DATETIME, 0))) as periode,bln.bulan, 
isnull(baru.baru,0) as baru,isnull(lama.lama,0) as lama,isnull(total.total,0) as total
FROM master.dbo.spt_values s 
left join (
select count(r.idregistrasi) as baru,
month(r.registrasidate) as periode 
from registrasi r
where year(r.registrasidate)=@periode and r.isdeleted=0 and r.kunjunganke=1
group by month(r.registrasidate)
) baru on MONTH(DATEADD(MM, s.number, CONVERT(DATETIME, 0)))=baru.periode
left join (
select count(r.idregistrasi) as lama,
month(r.registrasidate) as periode 
from registrasi r
where year(r.registrasidate)=@periode and r.isdeleted=0 and r.kunjunganke<>1
group by month(r.registrasidate)
) lama on MONTH(DATEADD(MM, s.number, CONVERT(DATETIME, 0)))=lama.periode
left join (
select count(r.idregistrasi) as total,
month(r.registrasidate) as periode 
from registrasi r
where year(r.registrasidate)=@periode and r.isdeleted=0 
group by month(r.registrasidate)
) total on MONTH(DATEADD(MM, s.number, CONVERT(DATETIME, 0)))=total.periode
left join (
select convert(bigint,left(kolom.kolom,2)) as id,substring(kolom.kolom,3,15) as bulan from dbo.fsplitstr((select top 1 [value] from sys_appsetting a where variable='StringBulanID'),',') kolom
) bln on MONTH(DATEADD(MM, s.number, CONVERT(DATETIME, 0)))=bln.id 
WHERE [type] = 'P' AND s.number BETWEEN 0 AND 11
ORDER BY MONTH(DATEADD(MM, s.number, CONVERT(DATETIME, 0))) asc
END
