CREATE FUNCTION dbo.fGetUsername (@id as bigint)
RETURNS
varchar(max)
AS
BEGIN
	declare @retval varchar(max)
	set @retval = (select top 1 username from sys_user where iduser=@id)
    return @retval
END
