CREATE PROCEDURE dbo.spMonSPB
@tahun as integer,
@bulan as integer, 
@iddept as bigint,
@idunit as bigint
AS
BEGIN
  select ROW_NUMBER() OVER (order by t.createddate desc) as nomor,
  t.idtransaksi,
  t.transaksino,
  ts.generalcode as transaksistatus,
  c.username as createdby,
  convert(varchar,t.createddate,105)+' '+convert(varchar,t.createddate,108) as createddate,
  dt.counter as totalitem,
  dtot.total as totalbarang 
  from transaksi t 
  left join (
	select idtransaksi,count(idtransaksidt) as counter 
	from transaksidt dt 
    group by idtransaksi
  ) dt on t.idtransaksi=dt.idtransaksi 
  left join (
  	select idtransaksi,
    sum(qtycharges) as total 
    from transaksidt dt 
    group by idtransaksi
  ) dtot on t.idtransaksi=dtot.idtransaksi 
  left join sys_generalcode ts on ts.idgeneral=t.transaksistatus and ts.gctype='transstatus' 
  left join sys_user c on c.iduser=t.createdby 
  where t.transaksitype=(
  	select idtransactiontype 
    from transactiontype 
    where kodetransaksi in (
    	select [value] 
        from sys_appsetting 
        where [variable]='KodePermintaanBarang'
    ) and iddepartment=@iddept and idunit=@idunit) 
    and month(t.createddate)=@bulan 
    and year(t.createddate)=@tahun 
    order by t.createddate desc
  
END