import {Observable} from 'rxjs';
import { from ,pipe} from 'rxjs/operators';
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
var input=Observable.pipe(from(1 , 2, 3, 4))
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

//it's represent possible values:function,primitivetype

import { of } from 'rxjs';
import { map, take, concatAll,f } from 'rxjs/operators';
import { first } from 'rxjs/operators';
import { fromEvent, interval } from 'rxjs';


map(x =>x)(of(1, 2, 3)).subscribe((v) => console.log(`value: ${v}`));
first()(of(1, 2, 3)).subscribe((v) => console.log(`value: ${v}`));


 
const clicks = fromEvent(document, 'click');
const higherOrder = clicks.pipe(
  map(ev => interval(1000).pipe(take(4))),
);
const firstOrder = higherOrder.pipe(concatAll());
firstOrder.subscribe(x => console.log(x));