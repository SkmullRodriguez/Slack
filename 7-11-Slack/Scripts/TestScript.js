window.onload = function () {
    oculto();

    btnP = document.getElementById("btn1");
    btnP.addEventListener('click', oculto2);

    btnP2 = document.getElementById("btn2");
    btnP2.addEventListener('click', oculto3);

    btnP3 = document.getElementById("btn3");
    btnP3.addEventListener('click', oculto4);

}

function oculto() {
    document.getElementById("form1").style.display = "block";
    document.getElementById("form2").style.display = "none";
    document.getElementById("form3").style.display = "none";
    document.getElementById("form4").style.display = "none";
}

function oculto2() {
    document.getElementById("form1").style.display = "none";
    document.getElementById("form2").style.display = "block";
    document.getElementById("form3").style.display = "none";
    document.getElementById("form4").style.display = "none";
}

function oculto3() {
    document.getElementById("form1").style.display = "none";
    document.getElementById("form2").style.display = "none";
    document.getElementById("form3").style.display = "block";
    document.getElementById("form4").style.display = "none";
}

function oculto4() {
    document.getElementById("form1").style.display = "none";
    document.getElementById("form2").style.display = "none";
    document.getElementById("form3").style.display = "none";
    document.getElementById("form4").style.display = "block";
}