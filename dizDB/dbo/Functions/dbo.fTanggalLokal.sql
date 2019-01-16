CREATE FUNCTION [dbo].[fTanggalLokal] (@tanggal as datetime,@regional as varchar(4))
RETURNS varchar(max) 
AS 
BEGIN 

	declare @Split varchar(max) 
	set @Split = (
	select convert(varchar,substring(convert(varchar,@tanggal,105),0,3))+' '+k.kolom+' '+convert(varchar,substring(convert(varchar,@tanggal,105),7,4)) as tglskrg 
	from (
	select ROW_NUMBER() OVER(ORDER BY kolom asc) AS rownum,substring(kolom,3,len(kolom)) as kolom 
	from [dbo].[fSplitStr]((select top 1 value from sys_appsetting where variable='StringBulan'+@regional),',') 
	) k where k.rownum=substring(convert(varchar,@tanggal,105),4,2) )

return @Split
END


