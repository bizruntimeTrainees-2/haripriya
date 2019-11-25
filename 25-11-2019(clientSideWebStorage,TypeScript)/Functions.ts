//function with parameter and return type
function Sum(x: number, y: number): number {
    return x + y;
}
Sum(10, 20);
//Sum(1,2,3);
//Sum(1);


//Default parameter
function Default(name: string, str: string = "hai"): string {
    return str + ' ' + name;
}
Default('ABC');
Default('XYZ');

//Fat Arrow Function
let add = (x: number, y: number): number => {
    return x + y;
}
add(10, 20);

class Employee {
    empCode: number;
    empName: string;
    constructor(code: number, name: string) {
        this.empName = name;
        this.empCode = code;
    }
    display = () => console.log(this.empCode + ' ' + this.empName)
}
let emp = new Employee(1, 'Raj');
emp.display();
console.log("---");

//Function Overloding;
function add1(a: string, b: string): string;
function add1(a: number, b: number): number;
function add1(a: any, b: any): any {
   //Any type is used to represent any JavaScript value
    return a + b;
}
add1("helo", "job");
add1(20, 30);

//rest Parameter
function Greet(greeting: string, ...names: string[]) {
    return greeting + " " + names.join(", ") + "!";
}

Greet("Hello", "Steve", "Bill"); 
Greet("Hello");
document.body.textContent = Greet("Hello", "Steve", "Bill");




/*
 * function Greet(...names: string[], greeting: string) {  // Compiler Error
    return greeting + " " + names.join(", ") + "!";
}*/