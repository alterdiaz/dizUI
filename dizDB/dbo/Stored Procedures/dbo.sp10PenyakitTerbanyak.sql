CREATE PROCEDURE dbo.sp10PenyakitTerbanyak
(@bulan bigint,@tahun bigint)
AS
BEGIN
Declare @T Table (nomor bigint,kode varchar(50),diagnosa varchar(200),counter bigint)
Insert @T exec spMonpenyakitTerbanyak @bulan,@tahun
Select top 10 kode,counter from @T order by counter desc
END
