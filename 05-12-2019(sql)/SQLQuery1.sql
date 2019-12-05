 use company;
 
create table `company`.`employee`(
`fname` varchar(15) not null,
`lastname`varchar(20) not null,
`ID` int8 not null,
primary key(`ID`));

 alter table employee add middlename varchar(10) not null;
 alter table employee add fullname varchar(20) not null after middlename;
 alter table employee add companyname varchar(20) not null after ID;
 alter table employee modify middlename varchar(50) null; 
 alter table employee drop column middlename;
 alter table employee change column companyname CompanyName varchar(10);
 /*alter table employee rename to Employee; */
 
 
 /*truncate statement removes the complete data without removing its structure.*/
 truncate table employee;
 /* DROP table statement removes the complete data with structure */
 drop table employee;
 
 
 insert into `company`.`employee`( fname,lastname,ID) values ('RAJ','MR',504);
 insert into `company`.`employee` values('Hari','anapala',518);
 insert into `employee` values('priya','thota',520);
 
select * from employee;
 
create table `company`.`dept`(
 `Dname` varchar(20) not null,
 `Dnumber` int not null,
primary key(`Dnumber`));
 
 insert into `company`.`dept` values('Development','001'); 
 insert into `company`.`dept` values('Testing','002'); 
 insert into dept values('analysis','003');
 
 select * from dept;
 
create table `dept_loc`(
 `Dnumber` int not null,
 `Dlocation` varchar(20) not null,
primary key(`Dnumber`,`Dlocation`));
 
 insert into `company`.`dept_loc` values('1','Bang');
 insert into dept_loc values('2','BTM');
 
 select * from dept_loc; 
 
 create table `project`(
 `Pname` varchar(20) not null,
 `Pnumber` int not null,
 `Plocation` varchar(20),
 primary key(`Pnumber`),
 unique(`Pname`));
  /* Primary key will not accept NULL values whereas
 Unique key can accept one NULL value */
 
 insert into project values('textFields',1,'BIZ runtime');
 insert into project values('Buttons','2','BIZ runtime');
 
  select * from project; 
 
 update employee set lastname='MR' where lastname='Prakash'; 
 
 
 
 
 
 
 
 
 
 
 
 