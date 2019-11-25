function printname(person)
//function greeter(person: string)
{
    return "Hello, " + person;
   
}
let user = "ABC";
document.body.textContent = printname(user);

//type annotation
function calling(person: string) {
    return "Hello, " + person;
}

let user1 = [0, 1, 2];
document.body.textContent = calling(user1);
//number is not assignable to parameter of type string.


//interface
interface Person {
    firstName: string;
    lastName: string;
}

function interface(person: Person) {
    return "Hello, " + person.firstName + " " + person.lastName;
}
let names = { firstName: "Jane", lastName: "User" };
document.body.textContent = interface(names);


//classes
class Student {
    fullName: string;
    constructor(public firstName: string, public middleInitial: string, public lastName: string) {
        this.fullName = firstName + " " + middleInitial + " " + lastName;
    }
}
interface Person {
    firstName: string;
    lastName: string;
}

function greeter(person: Person) {
    return "Hello, " + person.firstName + " " + person.lastName;
}
let names1 = new Student("helo", "Mr", "Rao");
document.body.textContent = greeter(names1);