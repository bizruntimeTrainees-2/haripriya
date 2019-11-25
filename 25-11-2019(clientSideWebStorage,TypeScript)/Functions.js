//function with parameter and return type
function Sum(x, y) {
    return x + y;
}
Sum(10, 20);
//Sum(1,2,3);
//Sum(1);
//Default parameter
function Default(name, str) {
    if (str === void 0) { str = "hai"; }
    return str + ' ' + name;
}
Default('ABC');
Default('XYZ');
//Fat Arrow Function
var add = function (x, y) {
    return x + y;
};
add(10, 20);
var Employee = /** @class */ (function () {
    function Employee(code, name) {
        var _this = this;
        this.display = function () { return console.log(_this.empCode + ' ' + _this.empName); };
        this.empName = name;
        this.empCode = code;
    }
    return Employee;
}());
var emp = new Employee(1, 'Raj');
emp.display();
console.log("---");
function add1(a, b) {
    //Any type is used to represent any JavaScript value
    return a + b;
}
add1("helo", "job");
add1(20, 30);
//rest Parameter
function Greet(greeting) {
    var names = [];
    for (var _i = 1; _i < arguments.length; _i++) {
        names[_i - 1] = arguments[_i];
    }
    return greeting + " " + names.join(", ") + "!";
}
Greet("Hello", "Steve", "Bill");
Greet("Hello");
document.body.textContent = Greet("Hello", "Steve", "Bill");
/*
 * function Greet(...names: string[], greeting: string) {  // Compiler Error
    return greeting + " " + names.join(", ") + "!";
}*/ 
//# sourceMappingURL=Functions.js.map