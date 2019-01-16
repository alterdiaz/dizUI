CREATE FUNCTION dbo.fFormatNoRM (
@param varchar(max)
)
RETURNS varchar(max) 
AS
BEGIN

declare @val varchar(max)
set @val=LEFT((convert(varchar,replicate('0',8-len(@param)))+convert(varchar,@param)),2)+'-'+
substring(convert(varchar,replicate('0',8-len(@param)))+convert(varchar,@param),3,2)+'-'+
substring(convert(varchar,replicate('0',8-len(@param)))+convert(varchar,@param),5,2)+'-'+
RIGHT(convert(varchar,replicate('0',8-len(@param)))+convert(varchar,@param),2)

return @val
END
