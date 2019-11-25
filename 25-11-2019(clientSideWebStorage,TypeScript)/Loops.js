//swichCase
var day = 4;
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
var x = 10, y = 5;
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
for (var i_1 = 0; i_1 < 3; i_1++) {
    console.log(i_1);
}
//for..of loop
//iterate and access elements of an array, list, or tuple collection
var arr1 = [10, 20, 30];
//let str = "Hello World";
for (var _i = 0, arr1_1 = arr1; _i < arr1_1.length; _i++) { //for(var char of str)
    var val = arr1_1[_i];
    console.log(val); //console.log(char);
}
var arr = [10, 20, 30, 40];
for (var index1 in arr) {
    console.log(index1);
}
console.log(index1);
for (var index2 in arr) {
    console.log(index2);
}
//console.log(index2);//Cannot find index2 
console.log("-----");
//while loop
var i = 2;
while (i < 4) {
    console.log("Block statement execution no." + i);
    i++;
}
//do-while
var n = 2;
do {
    console.log("Block statement execution no." + n);
    n++;
} while (i < 4);
//# sourceMappingURL=Loops.js.map