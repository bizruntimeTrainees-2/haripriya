"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var observable = new rxjs_1.Observable(function subscribe(subscribe) {
    var id = setInterval(function () {
        subscribe.next('hi');
    }, 1000);
});
observable.subscribe(function (x) { return console.log(x); });
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
