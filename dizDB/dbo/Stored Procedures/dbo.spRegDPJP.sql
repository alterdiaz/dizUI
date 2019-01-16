CREATE PROCEDURE [dbo].[spRegDPJP]
	@id bigint
AS
BEGIN
	select dp.idregistrasidpjp,
    pa.nama as paramedis,
    ps.nama as spesialis,
    dt.generalcode as dpjptype,
    sd.generalcode as statdata,
    dp.remarks,
    dt.idpriority as dpjpprioritas,
    pa.nama + ' ( '+ ps.nama + ' )' + char(13) + char(10) + 'sebagai ' + dt.generalcode + + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + dp.remarks as note 
    from registrasidpjp dp 
    left join spesialis ps on dp.idspesialis=ps.idspesialis 
    left join paramedis pa on dp.idparamedis=pa.idparamedis 
    left join sys_generalcode dt on dp.dpjptype=dt.idgeneral and dt.gctype='DPJPTYPE' 
    left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' 
    where dp.idregistrasi=@id 
    order by dp.createddate asc 
END
