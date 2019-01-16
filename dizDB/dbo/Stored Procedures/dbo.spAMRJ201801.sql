CREATE PROCEDURE dbo.spAMRJ201801
@id as bigint
AS
BEGIN
select ass.idassessment, 
rm.nama, 
convert(varchar,rm.tanggallahir,105) as tanggallahir, 
dbo.fFormatNoRM(rm.rekammedisno) as norm, 
r.registrasino, 
convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as registrasidate, 
ass.assessmentno, 
convert(varchar,ass.assessmentdate,105)+' '+convert(varchar,ass.assessmentdate,108) as assessmentdate, 
isnull(ass.fungsitubuh,'-') as fungsitubuh,
isnull(ass.strukturtubuh,'-') as strukturtubuh,
isnull(ass.aktifitas,'-') as aktifitas,
isnull(ass.partisipasi,'-') as partisipasi,
isnull(ass.faktorlingkungan,'-') as faktorlingkungan,
isnull(ass.faktorpersonal,'-') as faktorpersonal,
p.nama as dokterruangan
from assessment ass 
left join registrasi r on ass.idregistrasi=r.idregistrasi 
left join rekammedis rm on rm.idrekammedis=r.idrekammedis 
left join paramedis p on r.iddokterruangan=p.idparamedis 
where ass.idassessment=@id
END
