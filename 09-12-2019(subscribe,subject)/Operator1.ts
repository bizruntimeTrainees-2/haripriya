/*import 'rxjs/observable/of/map';
import {map} from 'rxjs/operators';
import {of} from 'rxjs';
import { take } from 'rxjs/operators';


//of- method for creating an observable

const source=of('world').pipe(
    map(x=>`hello ${x}`)//this function will receive 'world',as its input parameter x
);
let sub=source.subscribe(x=>{
    debugger;
    console.log(x);
});
//map is an operator that transforms data by applying a function
//pipe composes operators (like map, filter, etc)
//A representation of any set of values over any amount of time
//map wraps projection function in an observable,
//operator always returns observables
//pipe is a method on observable which is used for composing operator.

import { interval } from 'rxjs';
import {Observable} from 'rxjs';
import * as Rx from "rxjs";
import { of } from 'rxjs';
import { first } from 'rxjs/operators';
const source = of(0, '', 'foo', 69);
//of-returns an observable which immediately emits whatever values are supplied to of()
const result = source.pipe(
  first(Boolean)
);
result.subscribe(console.log);
//buffer Count:

//Create an observable that emits a value every second
const myInterval = Rx.Observable.interval(1000);
//After three values are emitted, pass on as an array of buffered values
const bufferThree = myInterval.bufferCount(3);
//Print values to console
//ex. output [0,1,2]...[3,4,5]
const subscribe = bufferThree.subscribe(val => console.log('Buffered Values:', val));
*/
// RxJS v6+
import { interval } from 'rxjs';

//emit value in sequence every 1 second
const source = interval(1000);
//output: 0,1,2,3,4,5....
const subscribe = source.subscribe(val => console.log(val));
