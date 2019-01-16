CREATE PROCEDURE [dbo].[spCheckRMbaru]
@nama varchar(300),
@nokartu varchar(50)
AS
BEGIN

select r.nama,isnull(krt.nomorkartu,0) as nomorkartu  
from rekammedis r
left join (
select k.idkartu,k.nomorkartu,k.idreff,k.jeniskartu 
from kartu k 
left join rekammedis r on k.idreff=r.idrekammedis and k.tablereff='PASIEN' and k.isprimary=1 and k.isdeleted=0 and k.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
where r.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
and r.isdeleted=0 and r.rekammedisno<>0 and replace(r.nama,' ','')=@nama 
) krt on r.idrekammedis=krt.idreff 
where r.idcompany=(select top 1 convert(bigint,value) as value from sys_appsetting where variable='CompanyID') 
and r.isdeleted=0 and r.rekammedisno<>0 and replace(r.nama,' ','')=@nama and krt.nomorkartu=@nokartu 

END