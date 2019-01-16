CREATE FUNCTION dbo.fRegNoUrut (
@idreg as varchar(50),
@iddokter as bigint,
@tglreg as date,
@idsesi as bigint
)
RETURNS bigint
AS
BEGIN
	declare @retval bigint

	set @retval=(select top 1 a.rownum from (
	select ROW_NUMBER() OVER(ORDER BY idregistrasi ASC) AS RowNum,idregistrasi  
	from registrasi 
	where idjadwalsesi=@idsesi and 
    iddokterruangan=@iddokter and 
    convert(varchar,registrasidate,105)=convert(varchar,@tglreg,105)) a
	where a.idregistrasi=@idreg)

	return @retval
END
