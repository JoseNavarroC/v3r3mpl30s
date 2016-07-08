/*
Lizania Gtz Díaz
version 1
04-05-2016
*/

/*__________________________________________*/

/*Barra Busqueda*/

/*__________________________________________*/
var barra_busqueda = $('.search_bar');
var bar = $('#bar');
var icono = $('.icon-search');

barra_busqueda.focusin(function(){
	barra_busqueda.css('width', '80%');
	icono.css('color', '#cccccc');
	bar.css('color', '#000');
});

barra_busqueda.focusout(function(){
	barra_busqueda.css('width', '100%');
	menu.css('width', '100%');
	icono.css('color', '#fff');
	bar.css('color', '#fff');
});


/*__________________________________________*/


/*Input Login*/

/*__________________________________________
var formulario_login = $('.formu');
var cont = $('#cont');
var iconos = $('.icon-lock');
var iconos1 = $('.icon-mention');

formulario_login.focusin(function(){
    formulario_login.css('width', '90%');
    iconos.css('color', '#b1b1b4');
    iconos1.css('color', '#b1b1b4');
    cont.css('color', '#000');
});

formulario_login.focusout(function(){
    formulario_login.css('width', '100%');
    iconos.css('color', '#cccccc');
    iconos1.css('color', '#cccccc');
    cont.css('color', '#cccccc');
});



/*Input CV*/

/*_________________________________________
var formulario_cv = $('.formucv');

formulario_cv.focusin(function(){
    formulario_cv.css('width', '90%');
});

formulario_cv.focusout(function(){
    formulario_cv.css('width', '100%');
});


/*Input Modal login*/

/*__________________________________________
var formulog = $('.formumlog');

formulog.focusin(function(){
    formulog.css('width', '90%');
});

formulog.focusout(function(){
    formulog.css('width', '100%');
});

/*Input Modal pass*/

/*__________________________________________
var formul = $('.formul');

formul.focusin(function(){
    formul.css('width', '90%');
});

formul.focusout(function(){
    formul.css('width', '100%');
});


/*Input cv1*/

/*__________________________________________
var formucv = $('.formucv');

formucv.focusin(function(){
    formucv.css('width', '90%');
});

formucv.focusout(function(){
    formucv.css('width', '100%');
});



/*Input cv2*/

/*__________________________________________
var formuDP = $('.formuDP');

formuDP.focusin(function(){
    formuDP.css('width', '90%');
});

formuDP.focusout(function(){
    formuDP.css('width', '100%');
});


/*Input cv3*/

/*__________________________________________
var formuDP = $('.formuDP');

formuDP.focusin(function(){
    formuDP.css('width', '90%');
});

formuDP.focusout(function(){
    formuDP.css('width', '100%');
});
*/

// Get the modal
var modal = document.getElementById('myModal');

// Get the button that opens the modal
var btn = document.getElementById("myBtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks the button, open the modal 
btn.onclick = function() {
    modal.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function() {
    modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}

/*__________________________________________*/


// Get the modal
var modal1 = document.getElementById('myModal1');

// Get the button that opens the modal1
var btn = document.getElementById("myBtn1");

// Get the <span> element that closes the modal1
var span = document.getElementsByClassName("close1")[0];

// When the user clicks the button, open the modal1 
btn.onclick = function() {
    modal1.style.display = "block";
}

// When the user clicks on <span> (x), close the modal1
span.onclick = function() {
    modal1.style.display = "none";
}

// When the user clicks anywhere outside of the modal1, close it
window.onclick = function(event) {
    if (event.target == modal1) {
        modal1.style.display = "none";
    }
}

/*__________________________________________*/


// Get the modal
var modal2 = document.getElementById('myModal2');

// Get the button that opens the modal2
var btn = document.getElementById("myBtn2");

// Get the <span> element that closes the modal2
var span = document.getElementsByClassName("close2")[0];

// When the user clicks the button, open the modal2 
btn.onclick = function() {
    modal2.style.display = "block";
}

// When the user clicks on <span> (x), close the modal2
span.onclick = function() {
    modal2.style.display = "none";
}

// When the user clicks anywhere outside of the modal2, close it
window.onclick = function(event) {
    if (event.target == modal2) {
        modal2.style.display = "none";
    }
}

/*__________________________________________*/


// Get the modal
var modal3 = document.getElementById('myModal3');

// Get the button that opens the modal3
var btn = document.getElementById("myBtn3");

// Get the <span> element that closes the modal3
var span = document.getElementsByClassName("close3")[0];

// When the user clicks the button, open the modal3 
btn.onclick = function() {
    modal3.style.display = "block";
}

// When the user clicks on <span> (x), close the modal3
span.onclick = function() {
    modal3.style.display = "none";
}

// When the user clicks anywhere outside of the modal3, close it
window.onclick = function(event) {
    if (event.target == modal3) {
        modal3.style.display = "none";
    }
}

/*__________________________________________*/


// Get the modal
var modal4 = document.getElementById('myModal4');

// Get the button that opens the modal4
var btn = document.getElementById("myBtn4");

// Get the <span> element that closes the modal4
var span = document.getElementsByClassName("close4")[0];

// When the user clicks the button, open the modal4 
btn.onclick = function() {
    modal4.style.display = "block";
}

// When the user clicks on <span> (x), close the modal4
span.onclick = function() {
    modal4.style.display = "none";
}

// When the user clicks anywhere outside of the modal4, close it
window.onclick = function(event) {
    if (event.target == modal4) {
        modal4.style.display = "none";
    }
}


/*__________________________________________*/


// Get the modal
var modal5 = document.getElementById('myModal5');

// Get the button that opens the modal5
var btn = document.getElementById("myBtn5");

// Get the <span> element that closes the modal5
var span = document.getElementsByClassName("close5")[0];

// When the user clicks the button, open the modal5 
btn.onclick = function() {
    modal5.style.display = "block";
}

// When the user clicks on <span> (x), close the modal5
span.onclick = function() {
    modal5.style.display = "none";
}

// When the user clicks anywhere outside of the modal5, close it
window.onclick = function(event) {
    if (event.target == modal5) {
        modal5.style.display = "none";
    }
}


/*__________________________________________*/


// Get the modal
var modal6 = document.getElementById('myModal6');

// Get the button that opens the modal6
var btn = document.getElementById("myBtn6");

// Get the <span> element that closes the modal6
var span = document.getElementsByClassName("close6")[0];

// When the user clicks the button, open the modal6 
btn.onclick = function() {
    modal6.style.display = "block";
}

// When the user clicks on <span> (x), close the modal6
span.onclick = function() {
    modal6.style.display = "none";
}

// When the user clicks anywhere outside of the modal6, close it
window.onclick = function(event) {
    if (event.target == modal6) {
        modal6.style.display = "none";
    }
}


/*__________________________________________*/


// Get the modal
var modal7 = document.getElementById('myModal7');

// Get the button that opens the modal7
var btn = document.getElementById("myBtn7");

// Get the <span> element that closes the modal7
var span = document.getElementsByClassName("close7")[0];

// When the user clicks the button, open the modal7 
btn.onclick = function() {
    modal7.style.display = "block";
}

// When the user clicks on <span> (x), close the modal7
span.onclick = function() {
    modal7.style.display = "none";
}

// When the user clicks anywhere outside of the modal7, close it
window.onclick = function(event) {
    if (event.target == modal7) {
        modal7.style.display = "none";
    }
}


/*__________________________________________*/


// Get the modal
var modal8 = document.getElementById('myModal8');

// Get the button that opens the modal8
var btn = document.getElementById("myBtn8");

// Get the <span> element that closes the modal8
var span = document.getElementsByClassName("close8")[0];

// When the user clicks the button, open the modal8 
btn.onclick = function() {
    modal8.style.display = "block";
}

// When the user clicks on <span> (x), close the modal8
span.onclick = function() {
    modal8.style.display = "none";
}

// When the user clicks anywhere outside of the modal8, close it
window.onclick = function(event) {
    if (event.target == modal8) {
        modal8.style.display = "none";
    }
}


/*__________________________________________*/


// Get the modal
var modal9 = document.getElementById('myModal9');

// Get the button that opens the modal9
var btn = document.getElementById("myBtn9");

// Get the <span> element that closes the modal9
var span = document.getElementsByClassName("close9")[0];

// When the user clicks the button, open the modal9 
btn.onclick = function() {
    modal9.style.display = "block";
}

// When the user clicks on <span> (x), close the modal9
span.onclick = function() {
    modal9.style.display = "none";
}

// When the user clicks anywhere outside of the modal9, close it
window.onclick = function(event) {
    if (event.target == modal9) {
        modal9.style.display = "none";
    }
}


/*__________________________________________*/


// Get the modal
var modal10 = document.getElementById('myModal10');

// Get the button that opens the modal10
var btn = document.getElementById("myBtn10");

// Get the <span> element that closes the modal10
var span = document.getElementsByClassName("close10")[0];

// When the user clicks the button, open the modal10 
btn.onclick = function() {
    modal10.style.display = "block";
}

// When the user clicks on <span> (x), close the modal10
span.onclick = function() {
    modal10.style.display = "none";
}

// When the user clicks anywhere outside of the modal10, close it
window.onclick = function(event) {
    if (event.target == modal10) {
        modal10.style.display = "none";
    }
}

