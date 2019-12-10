
--SCALAR FUN:B.C IT RETURNS SINGLE VALUE

SELECT dbo.CalculateAge('10/12/2018') as age


CREATE FUNCTION CalculateAge(@DOB date)
returns int
as 
begin
--DECLARE @DOB DATE
DECLARE @AGE INT
--SET @DOB='10/12/1998'
--FUNCTION DATEDIFF,DOB-STARTING,GETDATE-END DATE
SET @AGE=DATEDIFF(YEAR,@DOB,GETDATE())-
		CASE
		WHEN(MONTH(@DOB)>MONTH(GETDATE())) OR
			(MONTH(@DOB)=MONTH(GETDATE())) AND DAY(@DOB)>DAY(GETDATE())
			THEN 1
			ELSE 0
			END
RETURN @AGE
END