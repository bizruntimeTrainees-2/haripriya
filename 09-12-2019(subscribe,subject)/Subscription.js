"use strict";
exports.__esModule = true;
/*
import { interval } from 'rxjs';
const observable = interval(1000);
const subscription = observable.subscribe(x => console.log(x));
subscription.unsubscribe();*/
var rxjs_1 = require("rxjs");
var observable1 = rxjs_1.interval(400);
var observable2 = rxjs_1.interval(300);
var subscription = observable1.subscribe(function (x) { return console.log('first: ' + x); });
var childSubscription = observable2.subscribe(function (x) { return console.log('second: ' + x); });
subscription.add(childSubscription);
setTimeout(function () {
    // Unsubscribes BOTH subscription and childSubscription
    subscription.unsubscribe();
}, 1000);
