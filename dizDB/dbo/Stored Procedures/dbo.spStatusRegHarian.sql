CREATE PROCEDURE dbo.spStatusRegHarian
@periode varchar(10)
AS
BEGIN
DECLARE @StartDate AS DATETIME
DECLARE @EndDate AS DATETIME
DECLARE @CurrentDate AS DATETIME
Declare @Tbl as Table (tanggal datetime,counter bigint)

declare @month as varchar(2)
declare @year as varchar(4)

set @month=(select top 1 kolom from (select kolom,row_number() over (order by kolom) as rownum from fSplitStr(@periode,'-')) kol where kol.rownum=1)
set @year=(select top 1 kolom from (select kolom,row_number() over (order by kolom) as rownum from fSplitStr(@periode,'-')) kol where kol.rownum=2)

--SET @StartDate = '2018-09-01'
SET @StartDate = @year+'-'+@month+'-01'
--SET @EndDate = '2018-09-30'
SET @EndDate = DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,@StartDate)+1,0))
SET @CurrentDate = @StartDate

WHILE (@CurrentDate <= @EndDate)
BEGIN
    --IF NOT EXISTS (select 1 from registrasi where convert(varchar,registrasidate,105)=convert(varchar,@CurrentDate,105))
    --BEGIN
		insert into @Tbl(tanggal,counter) 
        select @CurrentDate,count(idregistrasi) as counter 
        from registrasi 
        where convert(varchar,registrasidate,105)=convert(varchar,@CurrentDate,105)
    --END
    SET @CurrentDate = dateadd(day,1,@CurrentDate);
END
select left(convert(varchar,tanggal,105),2) as tanggal,counter from @tbl order by tanggal asc;

END