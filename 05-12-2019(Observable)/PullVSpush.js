"use strict";
//Pull and Push are two different protocols that describe - 
//how a "data Producer" can communicate with a "data Consumer"
//the Consumer determines when it receives data from the data Producer.
// The Producer itself is unaware of when the data will be delivered to the Consumer.
exports.__esModule = true;
function foo() {
    console.log('Hello');
    return 4;
}
function call() {
    console.log('Hello');
    return 40;
}
var x = foo();
console.log(x);
var y = foo();
console.log(y);
console.log('before');
console.log(foo.call(1));
console.log('after');
/*
import { Observable } from 'rxjs';
const foo = new Observable(subscriber => {
  console.log('Hello');
  subscriber.next(42);
});

foo.subscribe(x => {
  console.log(x);
});
foo.subscribe(y => {
  console.log(y);
});*/ 
