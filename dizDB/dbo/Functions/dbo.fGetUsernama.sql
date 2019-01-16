CREATE FUNCTION dbo.fGetUsernama (@id as bigint)
RETURNS
varchar(max)
AS
BEGIN
	declare @retval varchar(max)
	set @retval = (select top 1 namalengkap from sys_user where iduser=@id)
    return @retval
END
