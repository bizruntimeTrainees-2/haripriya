"use strict";
/*import {Observable} from 'rxjs';
import { from } from 'rxjs';
import 'rxjs/add/observable/from';

function multiplyByTen(input){
    var output=Observable.create(function subscribe(observer)
    {
        input.subscribe({
            next:(v)=>observer.next(10*v),
            error:(err)=>observer.error(err),
            complete:()=>observer.complete()
        });
    });
    return output;
}
var input=Observable.from(1 , 2, 3, 4)
var output=multiplyByTen(input);
output.subscribe(x=>console.log(x));


import { Observable,merge} from 'rxjs';

var observable=Observable.create((observer:any)=>{
    observer.next("helo");
})
var observable1=Observable.create((observer:any)=>{
    observer.next("H r u");
})

var newObs=merge(observable,observable1);

newObs.subscribe((x:any)=>addItem(x))

function addItem(val:any){
    var node=document.createElement("li");
    var textnode=document.createTextNode(val);
    node.appendChild(textnode);
    document.getElementById("output").appendChild(node);
}

it's represent possible values:function,primitivetype*/
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var operators_2 = require("rxjs/operators");
var rxjs_2 = require("rxjs");
operators_1.map(function (x) { return x; })(rxjs_1.of(1, 2, 3)).subscribe(function (v) { return console.log("value: " + v); });
operators_2.first()(rxjs_1.of(1, 2, 3)).subscribe(function (v) { return console.log("value: " + v); });
var clicks = rxjs_2.fromEvent(document, 'click');
var higherOrder = clicks.pipe(operators_1.map(function (ev) { return rxjs_2.interval(1000).pipe(operators_1.take(4)); }));
var firstOrder = higherOrder.pipe(operators_1.concatAll());
firstOrder.subscribe(function (x) { return console.log(x); });
