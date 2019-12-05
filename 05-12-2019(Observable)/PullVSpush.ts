//Pull and Push are two different protocols that describe - 
//how a "data Producer" can communicate with a "data Consumer"
//the Consumer determines when it receives data from the data Producer.
// The Producer itself is unaware of when the data will be delivered to the Consumer.


import {Observable} from 'rxjs';

function foo() {
    console.log('Hello');
    return 4;
  }

  function call() {
    console.log('Hello');
    return 40;
  }
  
 
  const x = foo(); 
  console.log(x);
  const y = foo(); 
  console.log(y);


console.log('before');
console.log(foo.call(1));
console.log('after');


 
   const foo1 = new Observable(subscriber => {
    console.log('Hello');
    subscriber.next(42);
    subscriber.next(100); // "return" another value
    subscriber.next(200); // "return" yet another
    });
    
    console.log('before');
    foo1.subscribe(x => {
    console.log(x);
    });
    console.log('after');
    
/*
import { Observable } from 'rxjs';
const foo = new Observable(subscriber => {
  console.log('Hello');
  subscriber.next(42);
  subscriber.next(100);
  subscriber.next(200);
  setTimeout(() => {
    subscriber.next(300); // happens asynchronously
  }, 1000);
});

console.log('before');
foo.subscribe(x => {
  console.log(x);
});
console.log('after');
*/    

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