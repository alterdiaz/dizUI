CREATE PROCEDURE [dbo].[spRepJurnal] 
@tanggal varchar(10)
AS
select j.idjurnal,
convert(varchar,j.tanggaljurnal,105) +' '+ convert(varchar,j.tanggaljurnal,108) as tanggaljurnal,
j.idcoa, l.coa as coalama, c.coa, c.remarks as rekening,
j.remarks as keterangan, isnull(d.jumlahuang,0) as debet, isnull(k.jumlahuang,0) as kredit 
from jurnal j left join coa c on j.idcoa=c.idcoa left join coa l on j.idcoalama=l.idcoa 
left join (
select j.idjurnal,isnull(j.jumlahuang,0) as jumlahuang from jurnal j where j.posisidk=2 
and convert(varchar,j.tanggaljurnal,105)=@tanggal
) d on j.idjurnal=d.idjurnal 
left join (
select j.idjurnal,isnull(j.jumlahuang,0) as jumlahuang from jurnal j where j.posisidk=1 
and convert(varchar,j.tanggaljurnal,105)=@tanggal
) k on j.idjurnal=k.idjurnal 
where convert(varchar,j.tanggaljurnal,105)=@tanggal
order by j.tanggaljurnal asc

