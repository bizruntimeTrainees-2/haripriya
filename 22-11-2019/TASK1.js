
i=0;
function display()
  {
    a = document.getElementById("add");
    b = document.createElement("input");
    b.setAttribute("type","text");
    b.setAttribute("id","box"+(i++));
    a.appendChild(b);
  }
  i=0;
  function display1()
    {
    a = document.getElementById("add1");
    b = document.createElement("input");
    b.setAttribute("type","text");
    b.setAttribute("id","box"+(i++));
    a.appendChild(b);
    }

      
    function get()
    {
    var xhr = new XMLHttpRequest();
    xhr.onreadystatechange=function(){
    if(xhr.status==200&& xhr.readyState==4)
    {
    document.getElementById("doc").innerHTML = xhr.responseText;
    }
    };
    xhr.open("get","get?foo1=foo2",true);
    xhr.send();
    }


function post()
{
var xhr = new XMLHttpRequest();
xhr.onreadystatechange=function(){
if(xhr.status==200&& xhr.readyState==4)
{
document.getElementById("doc").innerHTML = xhr.responseText;
}
};
xhr.open("post","post",true);
xhr.send();
}


function postformdata()
{
var xhr = new XMLHttpRequest();
xhr.onreadystatechange=function(){
if(xhr.status==200&& xhr.readyState==4)
{
document.getElementById("doc").innerHTML = xhr.responseText;
}
};
xhr.open("post","post?foo1=foo2",true);
xhr.send();
}



function put()
{
var xhr = new XMLHttpRequest();
xhr.onreadystatechange=function(){
if(xhr.status==200&& xhr.readyState==4)
{
document.getElementById("doc").innerHTML = xhr.responseText;
}
};
xhr.open("put","put",true);
xhr.send();
}


function patch()
{
var xhr = new XMLHttpRequest();
xhr.onreadystatechange=function(){
if(xhr.status==200&& xhr.readyState==4)
{
document.getElementById("doc").innerHTML = xhr.responseText;
}
};
xhr.open("PATCH","patch",true);
xhr.setRequestHeader("Content-Type","application/x-www-form-urlencoded")
xhr.send("DATA");
}

function Delete()
{
var xhr = new XMLHttpRequest();
xhr.onreadystatechange=function(){
if(xhr.status==200&& xhr.readyState==4)
{
document.getElementById("doc").innerHTML = xhr.responseText;
}
};
xhr.open("DELETE","delete",true);
xhr.send("DATA");
}


function openCity(evt,operation) {
  var i, tabcontent, tablinks;
  tabcontent = document.getElementsByClassName("tabcontent");
  for (i = 0; i < tabcontent.length; i++) {
    tabcontent[i].style.display = "none";
  }
  tablinks = document.getElementsByClassName("tablinks");
  for (i = 0; i < tablinks.length; i++) {
    tablinks[i].className = tablinks[i].className.replace(" active", "");
  }
  document.getElementById(operation).style.display = "block";
  evt.currentTarget.className += " active";
}
