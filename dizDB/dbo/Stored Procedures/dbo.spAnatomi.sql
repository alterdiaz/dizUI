CREATE PROCEDURE dbo.spAnatomi
@id bigint
AS
BEGIN 
	select top 1 a.idanatomi,im.images 
	from anatomi a left join sys_images im on a.idimages=im.idimages 
	where a.isdeleted=0 and a.idregistrasi=@id 
    order by a.idanatomi desc 
END
