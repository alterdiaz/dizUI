CREATE PROCEDURE [dbo].[spSPP]
@idasal bigint,
@asaltype varchar(150)
AS
BEGIN

select d.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,sum(d.qtycharges) as qty,sum(d.qtylalu) as qtylalu,sum(d.qtyask) as qtyask,'-' as remarks 
from transaksi p 
left join transaksidt d on p.idtransaksi=d.idtransaksi 
left join item i on d.iditem=i.iditem 
left join sys_generalcode gc on gc.idgeneral=i.itemtype and gc.gctype='ITEMTYPE' 
left join satuan s on s.idsatuan=i.idsatuan 
where p.transaksitype in (
select tt.idtransactiontype from transactiontype tt where tt.kodetransaksi=(select [value] from sys_appsetting where [variable]='KodePermintaanBarang')
) and p.idcompany=(
select [value] from sys_appsetting where [variable]='CompanyID'
) and p.transaksistatus=6 and p.isdeleted=0
and p.idasal=@idasal 
and p.asaltype=@asaltype 
group by d.iditem,i.itemtype,i.idsatuan,gc.generalcode,i.kode,i.item,s.satuan
order by i.item asc

END