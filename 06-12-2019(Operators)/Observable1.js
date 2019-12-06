"use strict";
exports.__esModule = true;
var Rx = require("rxjs/Observable");
console.log(Rx);
var rxjs_1 = require("rxjs");
var observable = rxjs_1.Observable.create();
//The .create() method accepts a single argument, which is a subscribe function. 
//This subscribe function accepts an observer argument
var observable = rxjs_1.Observable.create(function subscribe(observer) {
    observer.next('Helo');
});
//OR
var observable = rxjs_1.Observable.create(function (observer) {
    observer.next('Helo');
});
var observable = rxjs_1.Observable.create(function (observer) {
    observer.next('helo');
});
observable.subscribe(function (x) { return console.log(x); });
//observer read values coming from observable,observer is simply
//set of callbacks that accept notification coming from observer
//i.e next,error,complete
var observable = rxjs_1.Observable.create(function (observer) {
    observer.next('hey guys');
    observer.next('h r u');
    observer.complete();
    observer.next('this will not send');
});
function addItem(val) {
    var node = document.createElement("li");
    var textnode = document.createTextNode(val);
    node.appendChild(textnode);
    document.getElementById("output").appendChild(node);
}
observable.subscribe(function (x) { return addItem(x); }, function (error) { return addItem(error); }, function () { return addItem('Completed'); });
