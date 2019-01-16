CREATE PROCEDURE [dbo].[spMonPenyakitTerbanyakIRJ]
(@bulan bigint,
@tahun bigint)
AS
BEGIN
select 0 as nomor,i.kode,i.diagnosa,count(i.kode) as counter
from registrasi r
left join soapnote sn on sn.idregistrasi=r.idregistrasi 
inner join analisarmdt ad on ad.idregistrasi=r.idregistrasi 
left join icd i on ad.idicd=i.idicd 
left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE'
where r.iddepartment in (select [value] from sys_appsetting where variable in ('IDOutpatientDept')) 
and year(r.registrasidate)=@tahun and month(r.registrasidate)=@bulan
and ad.isdeleted=0 and ad.analisarmtype=2 and i.icdtype=3 
group by i.kode,i.diagnosa
order by count(i.kode) desc
END