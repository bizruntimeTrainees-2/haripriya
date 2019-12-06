import * as Rx from "rxjs/Observable";
console.log(Rx);



import { Observable, from} from 'rxjs';
var observable=Observable.create();

//The .create() method accepts a single argument, which is a subscribe function. 
//This subscribe function accepts an observer argument

var observable=Observable.create(function subscribe(observer)
{
    observer.next('Helo');
})
//OR
var observable=Observable.create((observer:any)=>{
    observer.next('Helo');
})

var observable=Observable.create((observer:any)=>{
    observer.next('helo');
})
observable.subscribe((x:any)=>console.log(x));


//observer read values coming from observable,observer is simply
//set of callbacks that accept notification coming from observer
//i.e next,error,complete

var observable=Observable.create((observer:any)=>{
    observer.next('hey guys');
    observer.next('h r u');
    observer.complete();
    observer.next('this will not send');
})

function addItem(val:any) {
    var node = document.createElement("li");
    var textnode = document.createTextNode(val);
    node.appendChild(textnode);
    document.getElementById("output").appendChild(node);
}

    observable.subscribe(
    (x:any)=>addItem(x),
    (error:any)=>addItem(error),
    ()=>addItem('Completed')
);

