CREATE PROCEDURE [dbo].[spLoadLOVItemNQ]
@idunit as bigint
AS
BEGIN
	select i.iditem,i.item,0 as qty,0 as price,convert(bit,0) as cek,'('+ gc.generalcode +')' as note 
    from item i 
    left join sys_generalcode gc on i.itemtype=gc.idgeneral and gc.gctype='ITEMTYPE' 
    --isnull(iu.hargaakhir,isnull(iu.qty,
    --left join itemunit iu on i.iditem=iu.iditem and iu.idunit=@idunit and iu.iddepartment=(select top 1 [value] from sys_appsetting where variable='IDLogisticsDept') 
    where i.itemtype in (1,11)
    order by i.item asc    
END
