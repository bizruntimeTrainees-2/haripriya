	console.log("Helo");
	console.log("Hai");

 function iCallMyCallbackSynchronously(cb) {
  cb();
}
 
const boundSyncFn =rxjs.bindCallback(iCallMyCallbackSynchronously);
const boundAsyncFn = rxjs.bindCallback(iCallMyCallbackSynchronously, null, Rx.Scheduler.async);
 
boundSyncFn().subscribe(() => console.log('I was sync!'));
boundAsyncFn().subscribe(() => console.log('I was async!'));
console.log('This happened...');