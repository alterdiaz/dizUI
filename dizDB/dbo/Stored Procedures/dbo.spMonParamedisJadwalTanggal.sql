CREATE PROCEDURE dbo.spMonParamedisJadwalTanggal
@tanggal as date
AS
BEGIN
	select distinct pj.idparamedisspesialis as id,p.nama + ' (' + s.nama +')' as content
	from paramedisjadwal pj 
	left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis 
	left join spesialis s on ps.idspesialis=s.idspesialis 
	left join paramedis p on ps.idparamedis=p.idparamedis 
	where pj.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
	and (pj.tanggalmulai <= @tanggal and pj.tanggalselesai >= @tanggal) 
	and pj.isdeleted<>2 
	order by content asc
END
