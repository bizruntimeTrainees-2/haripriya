(function(){
	'use strict;
	sessionStorage.setItem('key','value');//it will show the key upto window not closed.
	console.log(sessionStorage.getItem('key'));


	//localStorage.setItem('key','value');
	//console.log(localStorage.getItem('key'));

	//store obj in session 
	//localStorage.setItem('key',JSON.stringify{id:3,name:'abc'});//convert to string
	//console.log(sessionStorage.getItem('key'));

	//console.log(JSON.parse(sessionStorage.getItem('key'));//get values of obj

	//console.log(JSON.parse(sessionStorage.getItem('key')).id);//get id

	//console.log(JSON.parse(sessionStorage.getItem('key')).name);//get name

	//use an array convert into string
	//localStorage.setItem('key',['hello','hai']);
	//console.log(sessionStorage.getItem('key'));

	//remove key from array
	//sessionStorage.setItem('key',['hello','hai']);
	//sessionStorage.removeItem('key');
	//console.log(sessionStorage.getItem('key'));



	//getting the key index
	//sessionStorage.setItem('key0',['hello','hai']);
	//sessionStorage.setItem('key1',['hello','hai']);	
	//console.log(sessionStorage.key(0));//key0
	//console.log(sessionStorage.key(1));//key1


	//clear()
	//localStorage.setItem('key0',['hello','hai']);
	//localStorage.setItem('key1',['hello','hai']);
	//sessionStorage.clear();
	//console.log(sessionStorage);
	
}());