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
import { Observable, asyncScheduler } from 'rxjs';
import { observeOn } from 'rxjs/operators';
var observable = new Observable((proxyObserver) => {
proxyObserver.next(1);
proxyObserver.next(2);
proxyObserver.next(3);
proxyObserver.complete();
}).pipe(
  observeOn(asyncScheduler)
);

var finalObserver = {
  next(x) {
    console.log('got value ' + x)
  },
  error(err) {
    console.error('something wrong occurred: ' + err);
  },
  complete() {
     console.log('done');
  }
};
console.log('just before subscribe');
observable.subscribe(finalObserver);
console.log('just after subscribe');