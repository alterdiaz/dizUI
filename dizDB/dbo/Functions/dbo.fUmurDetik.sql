CREATE FUNCTION [dbo].[fUmurDetik](@tanggallahir datetime,@tanggalregister datetime)
RETURNS varchar(2000) AS
BEGIN

Declare 
	@dateofbirth datetime, 
	@currentdatetime datetime,
    @tmpdate datetime,
	@years int,
	@months int,
	@days int,
	@hours int,
    @minutes int,
    @seconds int,
	@returnvalue varchar(2000)
    
set @dateofbirth=@tanggallahir
set @currentdatetime=@tanggalregister
set @tmpdate=@dateofbirth

-- To find Years
set @years = DATEDIFF(yy, @tmpdate,@currentdatetime ) - CASE WHEN (MONTH(@dateofbirth) > MONTH(@currentdatetime)) OR (MONTH(@dateofbirth) =  MONTH(@currentdatetime) AND DAY(@dateofbirth) > DAY(@currentdatetime)) THEN 1 ELSE 0 END
set @tmpdate = DATEADD(yy, @years, @tmpdate)

-- To Find Months
set @months = DATEDIFF(mm, @tmpdate, @currentdatetime) - CASE WHEN   DAY(@dateofbirth) > DAY(@currentdatetime) THEN 1 ELSE 0 END
set @tmpdate = DATEADD(mm, @months, @tmpdate)
--if month(@dateofbirth)>month(@currentdatetime) 
--set @months=(datediff(year,@dateofbirth,@currentdatetime)*12)-datediff(month,@dateofbirth,@currentdatetime) 
--else 
--set @months=datediff(month,@dateofbirth,@currentdatetime)-(datediff(year,@dateofbirth,@currentdatetime)*12) 

-- To Find Days
set @days = DATEDIFF(dd, @tmpdate, @currentdatetime)        
set @tmpdate = DATEADD(dd, @days, @tmpdate)
--set @days=datediff(day,@dateofbirth,@currentdatetime)

-- To Find Hours
set @hours = DATEDIFF(hh, @tmpdate, @currentdatetime)
set @tmpdate = DATEADD(hh, @hours, @tmpdate)

-- To Find Minutes
--if datepart(hour,@dateofbirth)>datepart(hour,@currentdatetime)
--set @minutes=(datepart(hour,@currentdatetime)+24-datepart(hour,@dateofbirth))*60+datepart(minute,@date
--else
set @minutes = DATEDIFF(mi, @tmpdate, @currentdatetime)
set @tmpdate = DATEADD(mi, @minutes, @tmpdate)

-- To Find Seconds 
set @seconds = DATEDIFF(ss, @tmpdate, @currentdatetime)
set @tmpdate = DATEADD(ss, @seconds, @tmpdate)

set @years=abs(@years)
set @months=abs(@months)
set @days=abs(@days)
set @hours=abs(@hours)
set @minutes=abs(@minutes)
set @seconds=abs(@seconds)

if @years=0
if @months=0
if @days=0
if @hours=0
if @minutes=0
set @returnvalue=convert(varchar,@seconds)+'dtk'
else
set @returnvalue=convert(varchar,@minutes)+'mnt '+convert(varchar,@seconds)+'dtk'
else
set @returnvalue=convert(varchar,@hours)+'jam '+convert(varchar,@minutes)+'mnt '+convert(varchar,@seconds)+'dtk'
else
set @returnvalue=convert(varchar,@days)+'hr '+convert(varchar,@hours)+'jam '+convert(varchar,@minutes)+'mnt '+convert(varchar,@seconds)+'dtk'
else
set @returnvalue=convert(varchar,@months) + 'bln '+convert(varchar,@days)+'hr '+convert(varchar,@hours)+'jam '+convert(varchar,@minutes)+'mnt '+convert(varchar,@seconds)+'dtk'
else
set @returnvalue=convert(varchar,@years)  +'th ' +convert(varchar,@months) + 'bln '+convert(varchar,@days)+'hr '+convert(varchar,@hours)+'jam '+convert(varchar,@minutes)+'mnt '+convert(varchar,@seconds)+'dtk'

RETURN @returnvalue
END