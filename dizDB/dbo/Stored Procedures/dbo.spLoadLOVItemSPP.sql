CREATE PROCEDURE dbo.spLoadLOVItemSPP
@idtrans as bigint
AS
BEGIN
	select dt.iditem,i.item,convert(bit,0) as cek,isnull(qt.qtyc,0)-isnull(qtt.qtyt,0) as qty 
	from transaksidt dt 
	left join item i on dt.iditem=i.iditem 
	left join (
		select iditem,sum(qtycharges) as qtyc from transaksidt where idtransaksi2=5 group by iditem
	) qt on dt.iditem=qt.iditem 
	left join (
		select dt.iditem,sum(dt.qtycharges) as qtyt 
		from transaksidt dt left join transaksi t on dt.idtransaksi=t.idtransaksi 
		where t.transaksitype in (
			select idtransactiontype from transactiontype where iddepartment in (
				select iddepartment from department where iddepartment in(
					select value from sys_appsetting where variable='IDPurchaseDept'
				)
        	) and idunit=(select idunit from transaksi where idtransaksi2=@idtrans) and jenistransaksi='Pembelian')
		group by dt.iditem
	) qtt on dt.iditem=qtt.iditem 
	where dt.idtransaksi2=@idtrans 
END