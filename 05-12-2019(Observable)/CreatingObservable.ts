
import {Observable, Subscriber} from 'rxjs';
const observable=new Observable(function subscribe(subscribe){
    const id=setInterval(()=>{
        subscribe.next('hi')
    },1000);
});
observable.subscribe(x => console.log(x));

/*
import { Observable } from 'rxjs';
const observable = new Observable(function subscribe(subscriber) {
subscriber.next(1);
subscriber.next(2);
subscriber.next(3);
subscriber.complete();
subscriber.next(4); // Is not delivered because it would violate the contract
});
*/

/*
import { from } from 'rxjs';
const observable = kfrom([10, 20, 30]);
const subscription = observable.subscribe(x => console.log(x));
subscription.unsubscribe();
*/

/*
const observable = new Observable(function subscribe(subscriber) {
  const intervalId = setInterval(() => {
    subscriber.next('hi');
  }, 1000);

  return function unsubscribe() {
    clearInterval(intervalId);
  };
});*/


/*
function subscribe(subscriber) {
  const intervalId = setInterval(() => {
    subscriber.next('hi');
  }, 1000);

  return function unsubscribe() {
    clearInterval(intervalId);
  };
}

const unsubscribe = subscribe({next: (x) => console.log(x)});

// Later:
unsubscribe(); // dispose the resources
*/