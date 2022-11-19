addEventListener( 'load',  (chargeEvent) => {
    console.log("teste loading");
} )

$('#a1').addEventListener ('click', (event) => {
    $('#aba1').style.visibility = 'visible';
    $('#aba2').style.visibility = 'hidden';
    $('#aba3').style.visibility = 'hidden';
    $('#aba4').style.visibility = 'hidden';
    console.log("Teste");
})

$('#a2').addEventListener ('click', (event) => {
    $('#aba1').style.visibility = 'hidden';
    $('#aba2').style.visibility = 'visible';
    $('#aba3').style.visibility = 'hidden';
    $('#aba4').style.visibility = 'hidden';
    console.log("Teste");
})

$('#a3').addEventListener ('click', (event) => {
    $('#aba1').style.visibility = 'hidden';
    $('#aba2').style.visibility = 'hidden';
    $('#aba3').style.visibility = 'visible';
    $('#aba4').style.visibility = 'hidden';
    console.log("Teste");
})


$('#a4').addEventListener ('click', (event) => {
    $('#aba1').style.visibility = 'hidden';
    $('#aba2').style.visibility = 'hidden';
    $('#aba3').style.visibility = 'hidden';
    $('#aba4').style.visibility = 'visible';
    console.log("Teste");
})

//TODO uma função só para fazer a das 4 acima

function $(querySelector) {
    return document.querySelector(querySelector);
}