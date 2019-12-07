use SQL; 
select * from DEPT;
select * from DEPT order by First_name DESC;

--AND:used to combine two conditions and its fetches the results which satisfy both the condition
select * from DEPT where Dept_number=1 and First_name='ABC';

--OR:used to combine two or more conditions and it fetches the results with satisfy any one of the condition
select * from DEPT where First_name='ABC' or Last_name='xyz';

--NOT:used to negate the condition and it fetches opposite results with satisfy con
select * from DEPT where Last_name not in ('abc');

--Clauses:Order By,Top,Where,Group by,Having Clause

--Comparison Operator(=,!=,<,>,>=,<=,LIKE,Between,IN):

select * from DEPT where Dept_number between 5 AND 7

select * from DEPT where Dept_number in (1,6);
select * from DEPT where Dept_number not in (1,6);
select * from DEPT where Dept_number>5;
select * from DEPT where Dept_number=5;
select * from DEPT where Dept_number!=5;
select * from DEPT where Dept_number<5;
select * from DEPT where Dept_number>=5;
select * from DEPT where Dept_number<=5;
--Like:Search the condition can contain either character or number.
--% denotes Zero or many character
--_denotes one character
select * from DEPT where First_name like '%z';--checks ends with z
select * from DEPT where First_name like 'x%';
select * from DEPT where First_name like 'X%Z';
select * from DEPT where First_name like 'X_ _';

--CASE EXPRESSION:
--used to provide if-then-else of logic to SQL
--select * from DEPT where salary =null(It's doen't work)
--select * from DEPT where salary is null

select * from DEPT where Last_name is not null

select case(Last_name)
when 'ABC' then 'abc'
when 'LMP' then 'lmp'
else 'NO IDEA'
end
from DEPT


--SQL JOINS:
--join clause is used to fetch data from two or more data tables
--Inner Join:inner join fetches records that have matching values in both tables

create table emp(Emp_id int,First_name varchar(20),Last_name varchar(10),Address varchar(50)); 
insert into emp(Emp_id,First_name,Last_name,Address) values(101,'jockson','joe','Mumbai')



create table orders(order_id int ,employee int ,OrderDate date);
insert into orders(order_id)values(1)

select * from emp;
select * from orders;

create schema hr;

CREATE TABLE hr.candidates(
    id INT PRIMARY KEY IDENTITY,
    fullname VARCHAR(100) NOT NULL
);
--The value in an identity column is crated by the server.
--A user generally cannot insert a value into an identity column

CREATE TABLE hr.employees(
    id INT PRIMARY KEY IDENTITY,
    fullname VARCHAR(100) NOT NULL
);
INSERT INTO hr.candidates(fullname)VALUES('John Doe'),('Lily Bush'),('Peter Drucker'), ('Jane Doe');
	 
INSERT INTO hr.employees(fullname)VALUES('John Doe'),('Jane Doe'),('Michael Scott'),('Jack Sparrow');

SELECT  
    c.id candidate_id,c.fullname candidate_name,e.id employee_id,e.fullname employee_name
    FROM 
	hr.candidates c INNER JOIN hr.employees e ON e.fullname = c.fullname;
select * from hr.candidates;
select * from hr.employees;

SELECT  
 c.id candidate_id,
 c.fullname candidate_name,
 e.id employee_id,
 e.fullname employee_name
FROM 
 hr.candidates c
 LEFT JOIN hr.employees e 
 ON e.fullname = c.fullname;

 SELECT  
    c.id candidate_id,
    c.fullname candidate_name,
    e.id employee_id,
    e.fullname employee_name
FROM 
    hr.candidates c
    LEFT JOIN hr.employees e 
        ON e.fullname = c.fullname
WHERE 
    e.id IS NULL;
SELECT  
    c.id candidate_id,
    c.fullname candidate_name,
    e.id employee_id,
    e.fullname employee_name
FROM 
    hr.candidates c
    RIGHT JOIN hr.employees e 
        ON e.fullname = c.fullname;

select fullname from hr.candidates group by fullname;