CREATE PROCEDURE dbo.spPenunjangRAD
 @id bigint
AS
BEGIN
	select pt.generalcode as penunjangtype,pp.hasilpemeriksaan 
	from pemeriksaanpenunjang pp 
	left join sys_generalcode pt on pt.idgeneral=pp.penunjangtype and pt.gctype='PENUNJANGTYPE'
	where pp.isdeleted=0 and pp.penunjangtype = 3 and pp.idregistrasi=@id
END
