CREATE PROCEDURE [dbo].[spSPPturunan]
@idasal bigint,
@asaltype varchar(150)
AS
BEGIN

select p.idtransaksi,d.idtransaksidt,d.iditem,i.itemtype,i.idsatuan,gc.generalcode as type,i.kode,i.item,s.satuan,d.qtycharges as qty,d.qtylalu as qtylalu,d.qtyask as qtyask,'-' as remarks 
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
order by p.idtransaksi,d.idtransaksidt asc

END