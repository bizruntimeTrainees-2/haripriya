use sql

create table Company(Dept_number int,Dept_name varchar(20)); 
insert into Company (Dept_number,Dept_name) values (1,'testing');
insert into Company (Dept_number,Dept_name) values (5,'developing');
insert into Company (Dept_number,Dept_name) values (10,'analysis');



--this type of join returns those records which have matching values in both tables


select Company.Dept_number,DEPT.Dept_number,Company.Dept_name,DEPT.First_name
from Company
inner join DEPT
on Company.Dept_number=DEPT.Dept_number;

select * from Company
select * from DEPT

--the left join returns all the records the records from the left table
--and also those records which satisfy a condition from the right table
select Company.Dept_number,DEPT.Dept_number,Company.Dept_name,DEPT.First_name
from Company
left join DEPT
on Company.Dept_number=DEPT.Dept_number;

--right returns all the records from right table and also those records
--which satisfy a condition from left table.
select Company.Dept_number,DEPT.Dept_number,Company.Dept_name,DEPT.First_name
from Company
right join DEPT
on Company.Dept_number=DEPT.Dept_number;

--returns all those records which either have a match in the left or rifht
select Company.Dept_number,DEPT.Dept_number,Company.Dept_name,DEPT.First_name
from Company
full join DEPT
on Company.Dept_number=DEPT.Dept_number;

backup database SQL1 to disk="path.bak";

alter table Company add Dept_address varchar(100)
alter table Company drop column Dept_address; 

create table person(ID int not null,Lastname varchar(100) not null);

--unique con ensures that all values in column are different
create table person1(ID int not null,lastname varchar(200),unique (ID));

--uniquely identifies each record in table
create table person2(ID int ,lastname varchar(200),primary key(ID));

--primary key can't accept null val,uni can accept one null val
--only one primary key in table,more than one unique key 

--A FOREIGN KEY is a key used to link two tables together

use sql
create table Employee(
EmpId int primary key,
EmpName varchar(25),
EmpAddr varchar(50)
)
insert into Employee values(1,'alex','bang')
insert into Employee values(2,'raj','hyb')
insert into Employee values(3,'ram','apt')
insert into Employee values(3,'ram','apt')--error




--foreign key in one table points to a primary key in another table
--references keyword is used to refer to the primary key of parent table

create table DEPARTMENT(
DepID int primary key,
Depname varchar(50),
EmpId int references Employee(EmpId)
);
insert into DEPARTMENT values(101,'testing',1);
insert into DEPARTMENT values(201,'Development',4);


select * from Employee
select * from DEPARTMENT


insert into store(store_id,store_name,phone_num,email,street,city,state,zip_code) 
values(1,'abc',123456987,'@gmail.com','tpt','tpt','kn',004); 

insert into store(store_id,store_name,phone_num,email,street,city,state,zip_code) 
values(2,'xyz',123456987,'@gmail.com','apt','apt','kn',004); 


insert into product values(1,'product1')
insert into product values(2,'product2')

select * from store
select * from product;

create view EmployeeDetails
as
select store_id,store_name,phone_num,email,street,city,state,zip_code 
from store
join product
on  store.store_id=product.description;
select * from EmployeeDetails;

--clustred index determine the physical order of data in a table


--clustered index is used to store the data rows sorted based on the clustered index key values
create table tblEmployee(
id int primary key,
name varchar(50),
salary int,
gender varchar(10),
city varchar(50));

execute sp_helpindex tblEmployee

insert into tblEmployee values(3,'jog',4500,'male','new york');
insert into tblEmployee values(2,'sam',5500,'female','toronto');
insert into tblEmployee values(1,'sara',6500,'male','london');


drop index tblEmployee.PK__tblEmplo__3213E83F9F261A5A 

create clustered index IX_tblEmployee_gender_salary
on  tblEmployee(gender desc,salary asc);

create nonclustered index IX_tblEmployee_name
on  tblEmployee(name);

--stored procedure is a group of t-sql(transact sql) st.
--if you have a situation where you write the same query 
--over and  over again.you can save that specific query as a stored procedure and call it just by it's name.

create procedure spGetEmployee1
as 
begin
select name,gender from tblEmployee
end

spGetEmployee1

execute spGetEmployee1

select * from tblEmployee;

alter table tblEmployee add Department_id int;

insert into tblEmployee values(4,'raj',12000,'male','tpt',201);


SpeGetEmployeesByGenderAndCity 'male','london' 

Create proc SpeGetEmployeesByGenderAndCity
@gender varchar(10),
@city varchar(20)
as 
begin 
select name,salary,gender,city from tblEmployee where
gender=@gender and city=@city
end

alter procedure spGetEmployee1
as 
begin
select name,gender from tblEmployee order by name
end

--view def
sp_helptext spGetEmployee


--string function:
select 'abc';
select LTRIM(' abc');
select lower('THIS IS SQL');
select UPPER('this is sql');
select reverse('sql');
select SUBSTRING('this is sql',9,3);

--Trigger
--trigger is a spl type of stored procedure that automatically
--runs when an event occurs in the database server.

create table tblEmployeeAudit(id int,AuditData varchar(20));

--store store char data i.e eng,noneng
alter trigger tblemployee_forInsert
on tblEmployee
for insert
as
begin
	declare @Id int
	select @Id=Id from inserted
	insert into tblEmployeeAudit
	values('new employee with Id='+
		    cast(@Id as nvarchar(5))+
			'is added at'+
			cast(Getdate() as nvarchar(20)))
		END
insert into tblEmployee values(8,'jimmy',1800,'female','tokyo',3)
select * from tblEmployee
