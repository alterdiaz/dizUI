CREATE PROCEDURE dbo.spSN201801
@id bigint
AS
BEGIN
	select s.soapnoteno,
    convert(varchar,s.soapnotedate,105)+' '+convert(varchar,s.soapnotedate,108) as soapnotedate,
	s.chiefcomplain,
    s.subyektif,
    s.obyektif,
    s.asesmen,
    s.planning,
    rm.nama, 
	convert(varchar,rm.tanggallahir,105) as tanggallahir, 
	dbo.fFormatNoRM(rm.rekammedisno) as norm, 
	r.registrasino
    from soapnote s 
    left join registrasi r on s.idregistrasi=r.idregistrasi
    left join rekammedis rm on r.idrekammedis=rm.idrekammedis 
    where s.isdeleted=0 and s.idregistrasi=@id
END
