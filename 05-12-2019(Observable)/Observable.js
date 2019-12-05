"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var myObservable = rxjs_1.Observable.create(function (observer) {
    observer.next(1);
    observer.next(2);
    observer.next(3);
    setTimeout(function () {
        observer.next(4);
        observer.complete();
    }, 1000);
});
console.log('just before subscribe');
myObservable.subscribe({
    next: function (x) { return console.log('got value:' + x); },
    error: function (err) { return console.error('something wrong occured:' + err); },
    complete: function () { return console.log('done'); }
});
console.log('just after subscribe');
