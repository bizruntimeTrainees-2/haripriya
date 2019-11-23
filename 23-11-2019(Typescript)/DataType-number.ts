let first: number = 123;
let second: number = 0x37cf;
Console.log(first);

let myNumber: number = 123456;
myNumber.toExponential();//1.23456e+5

let myNumber1: number = 10.87;
myNumber1.toFixed();//11


let myNumber2: number = 10667.987;
myNumber2.toLocaleString(); 

let myNumber3: number = 10.5679;
myNumber3.toPrecision(1);//1e+1

let myNumber4: number = 123;
myNumber4.toString(); // returns '123'

let myNumber5 = new Number(123);
Console.log(myNumber);


//STRINGS:
let employeeName1: string = 'ABC';//"ABC"



let employeeName2: string = "John Smith";
let employeeDept: string = "Finance";
let employeedetls1: string = employeeName2+ " works in the " + employeeDept + " department.";
//let employeedetls2: string = `${employeeName2} works in the ${employeeDept} department.`;
console.log(employeedetls1);
//console.log(employeedetls2);


let str: string = "XYZ";
str.charAt(0);//X

let str1: string = 'Hello';
let str2: string = 'TypeScript';
str1.concat(str2); //'HelloTypeScript'
str1.concat(' ', str2);//'HelloTypeScript'
str1.concat(' Mr.', 'ABC');//Hello Mr.ABC

let str3: string = 'TYEPESCRIPT';
str3.indexOf('T');//0

let st: string = 'HELOSCRIPT';
let st1: string = 'TYPE';
str1.replace('SCRIPT', 'ABC');//HELOABC

//BOOLEAN:
let isPresent: boolean = true;

//Array Declaration and Initialization
let company: Array<string>;
company = ['BIZRUNTIME', 'WIPRO'];
company[0];//BIZRUNTIME

let values: (string | number)[] = ['abc',1,'xyz'];
let values1: Array<string | number> = ['abc', 1, 'xyz'];


var alpha: Array<string> = ['A', 'B'];
alpha.sort();//[A,B]
console.log(alpha);
console.log(alpha.pop());//[A]
alpha.push('c');//['A','C']
alpha = alpha.concat(['D', 'E']);
console.log(alpha);

//data type
var empId: number = 1;
var empName: string = "ABC";

//Tuple
var employee: [number, string] = [1, "XYZ"];
employee.push(2, "ABC");//[1,'XYZ',2,'ABC']