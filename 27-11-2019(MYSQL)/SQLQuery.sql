use happy1;
select *from employee;
select min(e_salary) from employee;
select max(e_age) from employee;
select count(*) from employee where e_gender='female';
select sum(e_salary) from employee;
select avg(e_age) from employee;

select '      hari';
select ltrim('       hari');

--String Function:
select 'THIS IS SQL';

select lower('THIS IS SQL');

select upper('this is sql');

select reverse('this is sql');

select 'this is sql';
select substring('this is sql',9,3);

--order By:
select * from employee order by e_salary ;--by default asc
select * from employee order by e_salary desc;
--top By:
select top(3) * from employee;
select top(3) * from employee order by e_age desc;
--Group By;
select avg(e_salary),e_gender from employee group by e_gender;
select avg(e_age),e_dept from employee group by e_dept order by avg(e_age) desc;

--Update Statemt:
select * from employee;
update employee set e_age=42 where e_name='sam';
update employee set e_dept='Tech' where e_gender='female';
update employee set e_salary=500000; 

--Delete :
delete from employee where(e_age=28);

--create department table:
create table department(d_id int,d_name varchar(20),d_location varchar(20));

insert into department values(1,'content','new york'); 

insert into department values(2,'support','chicago'); 

insert into department values(3,'Analytics','new york');

insert into department values(4,'sales','Boston'); 

insert into department values(5,'Tech','Dallas'); 

select * from employee;
select * from department;

--Inner join:
select employee.e_id,employee.e_dept,department.d_id,department.d_location
from employee
inner join department on employee.e_dept=department.d_name;

--left join:
select employee.e_name,employee.e_dept,department.d_name,department.d_location
from employee 
left join department 
on employee.e_dept=department.d_name;

--Right join:
select employee.e_name,employee.e_dept,department.d_name,department.d_location
from employee
right join department
on employee.e_dept=department.d_name;

--Fully join:
select * from employee;

select * from department;

select employee.e_name,employee.e_dept,department.d_name,department.d_location
from employee
full join department
on employee.e_dept=department.d_name;

--Union operator:
create table student_details1(s_id int,s_name varchar(20),s_marks int);
insert into student_details1 values(1,'Sam',45);
insert into student_details1 values(2,'Bob',87);
insert into student_details1 values(3,'Anne',73);
insert into student_details1 values(4,'Julia',92);

create table student_details2(s_id int not null,s_name varchar(20) not null,s_marks int not null);
insert into student_details1 values(3,'Anne',73);
insert into student_details1 values(4,'Julia',92);
insert into student_details1 values(5,'Matt',65);

select * from student_details1
union
select * from student_details2;

select * from student_details1
union All
select * from student_details2;

--Except Operator:

