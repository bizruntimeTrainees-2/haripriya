create database SQL;
use SQL;



create table emp(
emp_id int primary key,
last_name varchar(100) not null,
first_name varchar(20) not  null); 
select * from emp;

insert into emp(emp_id,last_name,first_name) values (504,'raj','hasan');

create table emp1(
emp_id int,
last_name varchar(10) not null,
first_name varchar(20) not null,
Constraint emp1_pk primary key(emp_id));

insert into emp1(emp_id,first_name,last_name)
(select * from emp);

insert into emp1(emp_id,first_name)
(select emp_id,first_name from emp);

update emp set emp_id='520' where emp_id=504;


create table emp2(
last_name varchar(50) not null,
first_name varchar(10) not null,
salary money,
constraint emp_pk primary key(last_name,first_name));


create table emp4(
emp_id int not null,
Last_name varchar(20) not null,
Fast_name varchar(10) not null);

alter table emp4
add constraint emp_primaryKey primary key(emp_id);


create table product (
prod_id int primary key,
prod_name varchar(50) not null,
category varchar(25));

create table orders(
order_id int primary key,
prod_id int not null,
quantity int,

constraint fk_product_id
foreign key(prod_id)
references product(prod_id)
);


create table product1(
prod_id int primary key,
prod_name varchar(50) not null,
category varchar(25));

create table order1(
order_id int primary key,
prod_id int not null,
quality int);

insert into order1(
order_id,prod_id,quality) values(20,18,1);  

insert into order1(
order_id,prod_id,quality) values(1,2,4);  

select * from order1;

alter table orders1
add constraint fk_product_id1
foreign key(prod_id)
references product1(prod_id);

--ON DELETE CASCADE--
--fk CREATE R/S between two tables--

create view TestView as select * from emp;

select top(3) * from order1;
--order By--
--used along with where clause to display the specified col in as or dec
create table DEPT(Dept_number int,First_name varchar(20),Last_name varchar(100));

insert into DEPT(Dept_number,First_name,Last_name)values(1,'ABC','abc');
insert into DEPT(Dept_number,First_name,Last_name)values(5,'XYZ','xyz');
insert into DEPT(Dept_number,First_name,Last_name)values(4,'LMP','lmp');
insert into DEPT(Dept_number,First_name,Last_name)values(7,'XYZ','xyz');
insert into DEPT(Dept_number,First_name,Last_name)values(6,'LMP','lmp');


select * from DEPT;

select * from DEPT ORDER BY Dept_number DESC;

select top(2) * from DEPT

select top(2) * from DEPT order by Dept_number desc

--filtering:Used to join more than 2 queries

select * from DEPT where Dept_number=1 and First_name='ABC'




