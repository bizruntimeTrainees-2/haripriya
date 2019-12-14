"use strict";
exports.__esModule = true;
var operators_1 = require("rxjs/operators");
var rxjs_1 = require("rxjs");
var source = rxjs_1.interval(1000).pipe(operators_1.take(2));
var example = source.pipe(operators_1.map(function (val) {
    return rxjs_1.interval(1000).pipe(operators_1.map(function (i) { return "Result (" + val + "): " + i; }), operators_1.take(5));
}));
example
    .pipe(operators_1.combineAll())
    .subscribe(console.log);
