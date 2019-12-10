--Trigger
--trigger is a spl type of stored procedure that automatically
--runs when an event occurs in the database server.
--store store char data i.e eng,noneng
/*create trigger tr_tblEmployee_forInsert
on tblEmployee
for insert
as
begin
select * from inserted	
END
insert into tblEmployee values(10,'jimmy',1840,'male','tokyo',5)
select * from tblEmployee
select * from tblEmployeeAudit



alter trigger tr_tblEmployee_forInsert
on tblEmployee
for insert
as
begin
	declare @id int
	Select @id=id from inserted

	insert into tblEmployeeAudit
	values('new employee with id='+
			cast(@id as nvarchar(5))+
			'is added at'+cast(Getdate() as nvarchar(20)))
END

create trigger tr_tblEmployee_forDeleteAction
on tblEmployee
for delete
as
begin
	declare @id int
	Select @id=id from deleted

	insert into tblEmployeeAudit
	values('new employee with id='+
			cast(@id as nvarchar(5))+
			'is added at'+cast(Getdate() as nvarchar(20)))
END

*/