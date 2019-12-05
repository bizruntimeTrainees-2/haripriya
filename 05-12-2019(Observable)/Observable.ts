



import {Observable} from 'rxjs';
var myObservable=Observable.create(function(observer){//just before subscribe
    observer.next(1);//got value:1
    observer.next(2);//got value:2
    observer.next(3);//got value:3
    setTimeout(()=>{
        observer.next(4);
        observer.complete();//got value:4
    },1000);
});
console.log('just before subscribe');//just after subscribe
myObservable.subscribe({
    next:x=>console.log('got value:'+x),
    error:err=>console.error('something wrong occured:'+err),
    complete:()=>console.log('done'),//done
});
console.log('just after subscribe');

/*

just before subscribe
got value:1
got value:2
got value:3
just after subscribe
got value:4
done

Explnation:
Observable:Represent any set of value over any amount of time.

Subscription:
1)the listening to the stream is called subscribing.
2)calling subscribe method of observable we can listen to stream.
3)To invoke observable ,we need to subscribe to it.
4)just creating observable will not going to listen streams,we must have to 
invoke the observable by calling subscribe method.



observer:
1)observer can be an object with an object with "next,error,complete methods on it"
2)observable will call the observer next(value) method to provide data

*/