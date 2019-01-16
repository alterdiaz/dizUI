CREATE FUNCTION [dbo].[fTerbilang](@the_amount decimal(20,2)) 
RETURNS varchar(5000) AS
BEGIN

DECLARE 
    @divisor    decimal(20,2),
    @large_amount    decimal(20,2),
    @tiny_amount    decimal(20,2),
    @the_word    varchar(5000),
    @dividen    decimal(20,2),
    @dummy        decimal(20,2),
    @weight    varchar(100),
    @unit        varchar(30),
    @follower    varchar(50),
    @prefix    varchar(50),
    @sufix        varchar(50)

--SET NOCOUNT ON
SET @the_word = ''
SET @large_amount = FLOOR(ABS(@the_amount) )
SET @tiny_amount = ROUND((ABS(@the_amount) - @large_amount ) * 100.00,0)
SET @divisor = 1000000000000.00

IF @large_amount > @divisor * 1000.00
    RETURN 'OUT OF RANGE' 
    
WHILE @divisor >= 1
BEGIN        
    SET @dividen = FLOOR(@large_amount / @divisor)
    SET @large_amount = CONVERT(bigint,@large_amount) % @divisor
    
    SET @unit = ''
    IF @dividen > 0.00
        SET @unit=(CASE @divisor
            WHEN 1000000000000.00 THEN 'TRILYUN '
            WHEN 1000000000.00 THEN 'MILYAR '            
            WHEN 1000000.00 THEN 'JUTA '                
            WHEN 1000.00 THEN 'RIBU '
            ELSE @unit
        END )

    SET @weight = ''    
    SET @dummy = @dividen
    IF @dummy >= 100.00
        SET @weight = (CASE FLOOR(@dummy / 100.00)
            WHEN 1 THEN 'SE'
            WHEN 2 THEN 'DUA '
            WHEN 3 THEN 'TIGA '
            WHEN 4 THEN 'EMPAT '
            WHEN 5 THEN 'LIMA '
            WHEN 6 THEN 'ENAM '
            WHEN 7 THEN 'TUJUH '
            WHEN 8 THEN 'DELAPAN '
            ELSE 'SEMBILAN ' END ) + 'RATUS '

    SET @dummy = CONVERT(bigint,@dividen) % 100

    IF @dummy < 10.00
    BEGIN
        IF @dummy = 1.00 AND @unit = 'RIBU'
        BEGIN
            IF @dividen=@dummy
                SET @weight = @weight + 'SE'
            ELSE
                SET @weight = @weight + 'SATU '
        END
        ELSE
        IF @dummy > 0.00 
            SET @weight = @weight + (CASE @dummy
                WHEN 1 THEN 'SATU '
                WHEN 2 THEN 'DUA '
                WHEN 3 THEN 'TIGA '
                WHEN 4 THEN 'EMPAT '
                WHEN 5 THEN 'LIMA '
                WHEN 6 THEN 'ENAM '
                WHEN 7 THEN 'TUJUH '
                WHEN 8 THEN 'DELAPAN '
                ELSE 'SEMBILAN ' END)
    END
    ELSE
    IF @dummy BETWEEN 11 AND 19
        SET @weight = @weight + (CASE CONVERT(bigint,@dummy) % 10 
            WHEN 1 THEN 'SE'
            WHEN 2 THEN 'DUA '
            WHEN 3 THEN 'TIGA '
            WHEN 4 THEN 'EMPAT '
            WHEN 5 THEN 'LIMA '
            WHEN 6 THEN 'ENAM '
            WHEN 7 THEN 'TUJUH '
            WHEN 8 THEN 'DELAPAN '
            ELSE 'SEMBILAN ' END ) + 'BELAS '
    ELSE
    BEGIN
        SET @weight = @weight + (CASE FLOOR(@dummy / 10) 
            WHEN 1 THEN 'SE'
            WHEN 2 THEN 'DUA '
            WHEN 3 THEN 'TIGA '
            WHEN 4 THEN 'EMPAT '
            WHEN 5 THEN 'LIMA '
            WHEN 6 THEN 'ENAM '
            WHEN 7 THEN 'TUJUH '
            WHEN 8 THEN 'DELAPAN '
            ELSE 'SEMBILAN ' END ) + 'PULUH '
        IF CONVERT(bigint,@dummy) % 10 > 0 
            SET @weight = @weight + (CASE CONVERT(bigint,@dummy) % 10 
                WHEN 1 THEN 'SATU '
                WHEN 2 THEN 'DUA '
                WHEN 3 THEN 'TIGA '
                WHEN 4 THEN 'EMPAT '
                WHEN 5 THEN 'LIMA '
                WHEN 6 THEN 'ENAM '
                WHEN 7 THEN 'TUJUH '
                WHEN 8 THEN 'DELAPAN '
                ELSE 'SEMBILAN ' END )
    END
    
    SET @the_word = @the_word + @weight + @unit
    SET @divisor = @divisor / 1000.00
END

IF FLOOR(@the_amount) = 0.00 
    SET @the_word = 'NOL '

SET @follower = 'RUPIAH'
IF @tiny_amount < 10.00
BEGIN    
    IF @tiny_amount > 0.00 
        SET @follower = 'KOMA NOL ' + (CASE @tiny_amount
            WHEN 1 THEN 'SATU '
            WHEN 2 THEN 'DUA '
            WHEN 3 THEN 'TIGA '
            WHEN 4 THEN 'EMPAT '
            WHEN 5 THEN 'LIMA '
            WHEN 6 THEN 'ENAM '
            WHEN 7 THEN 'TUJUH '
            WHEN 8 THEN 'DELAPAN '
            ELSE 'SEMBILAN ' END)
END
ELSE
BEGIN
    SET @follower = 'KOMA ' + (CASE FLOOR(@tiny_amount / 10.00)
            WHEN 1 THEN 'SATU '
            WHEN 2 THEN 'DUA '
            WHEN 3 THEN 'TIGA '
            WHEN 4 THEN 'EMPAT '
            WHEN 5 THEN 'LIMA '
            WHEN 6 THEN 'ENAM '
            WHEN 7 THEN 'TUJUH '
            WHEN 8 THEN 'DELAPAN '
            ELSE 'SEMBILAN ' END)
    IF CONVERT(bigint,@tiny_amount) % 10 > 0 
        SET @follower = @follower + (CASE CONVERT(bigint,@tiny_amount) % 10
            WHEN 1 THEN 'SATU '
            WHEN 2 THEN 'DUA '
            WHEN 3 THEN 'TIGA '
            WHEN 4 THEN 'EMPAT '
            WHEN 5 THEN 'LIMA '
            WHEN 6 THEN 'ENAM '
            WHEN 7 THEN 'TUJUH '
            WHEN 8 THEN 'DELAPAN '
            ELSE 'SEMBILAN ' END)
END 
    
SET @the_word = @the_word + @follower

IF @the_amount < 0.00
    SET @the_word = 'MINUS ' + @the_word
    
RETURN @the_word
END



