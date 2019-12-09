"use strict";
exports.__esModule = true;
/*import { take, map, combineAll } from 'rxjs/operators';
import { interval } from 'rxjs';

// emit every 1s, take 2
const source = interval(1000).pipe(take(2));
// map each emitted value from source to interval observable that takes 5 values
//pipes let you combine multiple function into a single function.
const example = source.pipe(
    //map applies a given function to each elements emitted by source observable
  map(val =>
    interval(1000).pipe(
      map(i => `Result (${val}): ${i}`),
      take(5)
    )
  )
);
example
  .pipe(combineAll())
  .subscribe(console.log);
  
  2 values from source will map to 2 (inner) interval observables that emit every 1s.
  combineAll uses combineLatest strategy, emitting the last value from each
  whenever either observable emits a value

import { timer, combineLatest } from 'rxjs';
// timerOne emits first value at 1s, then once every 4s
const timerOne = timer(1000, 4000);
// timerTwo emits first value at 2s, then once every 4s
const timerTwo = timer(2000, 4000);
// timerThree emits first value at 3s, then once every 4s
const timerThree = timer(3000, 4000);

// when one timer emits, emit the latest values from each timer as an array
combineLatest(timerOne, timerTwo, timerThree).subscribe(
  ([timerValOne, timerValTwo, timerValThree]) => {
    
    Example:
    timerOne first tick: 'Timer One Latest: 1, Timer Two Latest:0, Timer Three Latest: 0
    timerTwo first tick: 'Timer One Latest: 1, Timer Two Latest:1, Timer Three Latest: 0
    timerThree first tick: 'Timer One Latest: 1, Timer Two Latest:1, Timer Three Latest: 1
  
    console.log(
      `Timer One Latest: ${timerValOne},
     Timer Two Latest: ${timerValTwo},
     Timer Three Latest: ${timerValThree}`
    );
  }
);

//of()-useful for maintaining the observable data type
import { of, concat } from 'rxjs';
concat(
  of(1, 2, 3),
  // subscribed after first completes
  of(4, 5, 6),
  // subscribed after second completes
  of(7, 8, 9)
)
  .subscribe(console.log);


import { map, concatAll } from 'rxjs/operators';
import { of, interval } from 'rxjs';

//emit a value every 2 seconds
const source = interval(2000);
const example = source.pipe(
  map(val => of(val + 10)),
  concatAll()
);
const subscribe = example.subscribe(val =>
  console.log('Example with Basic Observable:', val)
);


import { endWith } from 'rxjs/operators';
import { of } from 'rxjs';

const source = of('Hello', 'Friend', 'Goodbye');

source
  // emit on completion
  .pipe(endWith('Friend'))
  .subscribe(console.log);

  

//forkJoin:
//this operator is best used when you have a group of observables and only care about final emmited value of each.
import { ajax } from 'rxjs/ajax';
import { forkJoin } from 'rxjs/operators';


  when all observables complete, provide the last
  emitted value from each as dictionary

forkJoin(
  {
    google: ajax.getJSON('https://api.github.com/users/google'),
    microsoft: ajax.getJSON('https://api.github.com/users/microsoft'),
    users: ajax.getJSON('https://api.github.com/users')
  }
)
  // { google: object, microsoft: object, users: array }
  .subscribe(console.log);

*/
var operators_1 = require("rxjs/operators");
var rxjs_1 = require("rxjs");
//emit every 2.5 seconds
var first = rxjs_1.interval(2500);
var second = rxjs_1.interval(2000);
var third = rxjs_1.interval(1500);
var fourth = rxjs_1.interval(1000);
var example = rxjs_1.merge(first.pipe(operators_1.mapTo('FIRST!')), second.pipe(operators_1.mapTo('SECOND!')), third.pipe(operators_1.mapTo('THIRD')), fourth.pipe(operators_1.mapTo('FOURTH')));
var subscribe = example.subscribe(function (val) { return console.log(val); });
//
