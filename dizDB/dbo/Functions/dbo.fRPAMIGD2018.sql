CREATE FUNCTION dbo.fRPAMIGD2018 (@idrm bigint,@idreg bigint)
RETURNS bigint
AS
BEGIN
declare @val bigint
	set @val= (
    select count(riw.idriwayatpasien) as counter 
	from riwayatpasien riw 
	where riw.idreff2=@idreg and riw.idreff=@idrm and riw.riwayattype=4 and riw.riwayatalergitype=8 and riw.isdeleted=0 
	)
    return @val
END
