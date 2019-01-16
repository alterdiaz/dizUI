CREATE FUNCTION [dbo].[fSplitStr] 
( 
    @val VARCHAR(MAX), 
    @delimiter varchar(1) 
) 
RETURNS @output TABLE(kolom VARCHAR(MAX) 
) 
BEGIN 
 
    DECLARE @start INT, @end INT 
    SELECT @start = 1, @end = CHARINDEX(@delimiter, @val) 
 
    WHILE @start < LEN(@val) + 1 BEGIN 
        IF @end = 0  
            SET @end = LEN(@val) + 1
       
        INSERT INTO @output (kolom)  
        VALUES(SUBSTRING(@val, @start, @end - @start)) 
        SET @start = @end + 1 
        SET @end = CHARINDEX(@delimiter, @val, @start)
        
    END 
 
    RETURN 
 
END