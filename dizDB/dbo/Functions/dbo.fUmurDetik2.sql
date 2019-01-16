CREATE FUNCTION [dbo].[fUmurDetik2](@tanggallahir datetime,@tanggalregister datetime)
RETURNS varchar(2000) AS
BEGIN

Declare 
	@dateofbirth datetime, 
	@currentdatetime datetime,
    @tmpdate datetime,
	@seconds int,
	@returnvalue varchar(2000)
    
set @dateofbirth=@tanggallahir
set @currentdatetime=@tanggalregister
set @tmpdate=@dateofbirth

-- To Find Seconds 
set @seconds = DATEDIFF(ss, @tmpdate, @currentdatetime)
set @tmpdate = DATEADD(ss, @seconds, @tmpdate)

set @seconds=abs(@seconds)
set @returnvalue=convert(varchar,@seconds)

RETURN @returnvalue
END