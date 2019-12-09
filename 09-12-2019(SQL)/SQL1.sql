select * from DEPT;


select Dept_number from DEPT;
--select distict statement is used to return only Different values-->
select distinct Dept_number from DEPT;

select Count(distinct Dept_number) from DEPT; 

select * from DEPT where First_name='ABC';

--Unique creates a constraint(rules) that all values to be inserted must be different from the others-->
--Distinct results in the removal of the duplicate rows while retrieving data-->
select * from DEPT where Dept_number in (1,5);
Select * from DEPT order by Dept_number desc;
select * from DEPT order by First_name,Last_name;
select * from DEPT order by First_name asc,Dept_number desc;
select First_name,Last_name from DEPT where Last_name Is null;
select First_name,Last_name from DEPT where Last_name Is not null;

update DEPT set First_name='EFG',Last_name='XYZ'
where Dept_number=1;

select * from DEPT;
Update DEPT set Dept_number=1;
delete from DEPT where Dept_number=7;
delete from DEPT where First_name='LMP';
insert into DEPT(Dept_number,First_name,Last_name) values(2,'ABC','abc');
insert into DEPT(Dept_number,First_name,Last_name) values(4,'LMP','lmp');

delete from DEPT;
--truncate:removes all rows from table(not undo)
--delete operation can be rolled back
--drop:The DROP command removes a table from the database
select TOP 3 * from DEPT;
select * from DEPT LIMIT 2;
select * from DEPT where Dept_number<=1;
select top 50 percent * from DEPT;
select min(Dept_number) from DEPT;
select max(Dept_number) from DEPT;
select  sum(Dept_number) from DEPT;
select avg(Dept_number) from DEPT;
select * from DEPT where Dept_number like 1;
select * from DEPT where First_name like '%A%';
select Dept_number As dept_number from DEPT;
