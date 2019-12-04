<!DOCTYPE html>
<html>
<head>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
<script> 
$(document).ready(function(){
  $("button").click(function(){
    $("div").animate({left: '250px'});
	/*
	$("div").animate({
      height: 'toggle'
    });*/
  });
});
</script> 
</head>
<body>
<button>Start Animation</button>
<p>the html elements have a static position and cannot be moved.
we are going to change the position by using css properties</p>

<div style="background:#98bf21;height:100px;width:100px;position:absolute;"></div>
</body>
</html>