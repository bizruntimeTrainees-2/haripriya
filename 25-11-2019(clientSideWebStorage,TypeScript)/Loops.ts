//swichCase


let day: number = 4;
switch (day) {
    case 0:
        console.log("It is a Sunday.");
        break;
    case 1:
        console.log("It is a Monday.");
        break;
    case 2:
        console.log("It is a Tuesday.");
        break;
    case 3:
        console.log("It is a Wednesday.");
        break;
    case 4:
        console.log("It is a Thursday.");
        break;
    case 5:
        console.log("It is a Friday.");
        break;
    case 6:
        console.log("It is a Saturday.");
        break;
    default:
        console.log("No such day exists!");
        break;
}
console.log("---------------------");

let x = 10, y = 5;
switch (x - y) {
    case 0:
        console.log("Result: 0");
        break;
    case 5:
        console.log("Result: 5");
        break;
    case 10:
        console.log("Result: 10");
        break;
}
console.log("---------------------");

//for loop
for (let i = 0; i < 3; i++) {
    console.log(i);
}

//for..of loop
//iterate and access elements of an array, list, or tuple collection
let arr1 = [10, 20, 30];
//let str = "Hello World";

for (var val of arr1) {//for(var char of str)
    console.log(val);//console.log(char);
}


let arr = [10, 20, 30, 40];

for (var index1 in arr) {
    console.log(index1); 
}
console.log(index1); 

for (let index2 in arr) {
    console.log(index2); 
}
//console.log(index2);//Cannot find index2 
console.log("-----");

//while loop

let i: number = 2;
while (i < 4) {
    console.log("Block statement execution no." + i)
    i++;
}

//do-while
let n: number = 2;
do {
    console.log("Block statement execution no." + n)
    n++;
} while (i < 4)