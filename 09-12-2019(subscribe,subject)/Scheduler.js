"use strict";
exports.__esModule = true;
/*
import { Observable, asyncScheduler } from 'rxjs';
import { observeOn } from 'rxjs/operators';

const observable = new Observable((observer) => {
  observer.next(1);
  observer.next(2);
  observer.next(3);
  observer.complete();
}).pipe(
  observeOn(asyncScheduler)
);
//asyncScheduler allows you emit each value in a separate macrotask
console.log('just before subscribe');
observable.subscribe({
  next(x) {
    console.log('got value ' + x)
  },
  error(err) {
    console.error('something wrong occurred: ' + err);
  },
  complete() {
     console.log('done');
  }
});
console.log('just after subscribe');
*/
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var observable = new rxjs_1.Observable(function (proxyObserver) {
    proxyObserver.next(1);
    proxyObserver.next(2);
    proxyObserver.next(3);
    proxyObserver.complete();
}).pipe(operators_1.observeOn(rxjs_1.asyncScheduler));
var finalObserver = {
    next: function (x) {
        console.log('got value ' + x);
    },
    error: function (err) {
        console.error('something wrong occurred: ' + err);
    },
    complete: function () {
        console.log('done');
    }
};
console.log('just before subscribe');
observable.subscribe(finalObserver);
console.log('just after subscribe');
var proxyObserver = {
    next: function (val) {
        rxjs_1.asyncScheduler.schedule(function (x) { return finalObserver.next(x); }, 0 /* delay */, val /* will be the x for the function above */);
    }
};
