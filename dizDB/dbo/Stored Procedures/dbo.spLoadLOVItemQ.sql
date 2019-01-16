CREATE PROCEDURE [dbo].[spLoadLOVItemQ]
@idunit as bigint
AS
BEGIN
	select i.iditem,i.item,isnull(iu.qty,0) as qty,isnull(iu.hargaakhir,0) as price,convert(bit,0) as cek,'('+ gc.generalcode +') Qty ' + convert(varchar,isnull(iu.qty,0)) as note 
    from item i 
    left join sys_generalcode gc on i.itemtype=gc.idgeneral and gc.gctype='ITEMTYPE' 
    left join itemunit iu on i.iditem=iu.iditem and iu.idunit=@idunit and iu.iddepartment=(select top 1 [value] from sys_appsetting where variable='IDLogisticsDept') 
    where i.itemtype in (1,11)
    order by i.item asc    
END
