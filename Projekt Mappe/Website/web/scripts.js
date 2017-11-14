function addElement() {
	var element = document.getElementById("txtInput").value;
	
	var element1 = document.getElementById("lblNavn").innerHTML = element;
}

function noget(){
	var element = document.getElementById("txtTal1").value;
	var element1 = document.getElementById("txtTal2").value;
	var element2 = document.getElementById("lblResul").innerHTML = +element + +element1;
}

function euro(){
	var element = document.getElementById("txtDkk").value;
	var element1 = document.getElementById("lblEuro").innerHTML = +element * +0.13;
}

function doDate()
{
    var str = "";

    var days = new Array("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday");
    var months = new Array("January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December");

    var now = new Date();

    str += "Today is: " + days[now.getDay()] + ", " + now.getDate() + " " + months[now.getMonth()] + " " + now.getFullYear() + " " + now.getHours() +":" + now.getMinutes() + ":" + now.getSeconds();
    document.getElementById("todaysDate").innerHTML = str;
}
setInterval(doDate, 1000);