CREATE FUNCTION [dbo].[fUmur](@tanggallahir date)
RETURNS varchar(2000) AS
BEGIN

Declare 
	@dateofbirth datetime, 
	@currentdatetime datetime,
    @thisyearbirthday datetime,
	@years int,
	@months int,
	@days int,
	@returnvalue varchar(2000)
    
set @dateofbirth=@tanggallahir
set @currentdatetime=getdate()
set @thisyearbirthday = DATEADD(year, DATEDIFF(year, @dateofbirth, @currentdatetime), @dateofbirth)

-- To find Years
set @years = DATEDIFF(year, @dateofbirth, @currentdatetime) - (CASE WHEN @thisyearbirthday > @currentdatetime THEN 1 ELSE 0 END)
--set @years=datediff(year,@dateofbirth,@currentdatetime)

-- To Find Months
set @months = MONTH(@currentdatetime - @thisyearbirthday) - 1
--if month(@dateofbirth)>month(@currentdatetime) 
--set @months=(datediff(year,@dateofbirth,@currentdatetime)*12)-datediff(month,@dateofbirth,@currentdatetime) 
--else 
--set @months=datediff(month,@dateofbirth,@currentdatetime)-(datediff(year,@dateofbirth,@currentdatetime)*12) 

-- To Find Days
set @days = DAY(@currentdatetime - @thisyearbirthday) - 1
--set @days=datediff(day,@dateofbirth,@currentdatetime)

if @years=0 
if @months=0 
set @returnvalue=convert(varchar,@days)+'hr' 
else
if @days=0
set @returnvalue=convert(varchar,@months) + 'bln'
else
set @returnvalue=convert(varchar,@months) + 'bln '+convert(varchar,@days)+'hr' 
else
if @months=0
if @days=0
set @returnvalue=convert(varchar,@years)  +'th'
else
set @returnvalue=convert(varchar,@years)  +'th ' +convert(varchar,@days)+'hr' 
else
set @returnvalue=convert(varchar,@years)  +'th ' +convert(varchar,@months) + 'bln '+convert(varchar,@days)+'hr'

RETURN @returnvalue
END


