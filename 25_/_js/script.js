//https://servicodados.ibge.gov.br/api/docs/noticias?versao=3 info api

var qtd = 6,
    busca = "";
var news = ["futebol", "economia", "copa_do_mundo", "programacao", "carros"];
URL_API_FUTEBOL = `http://servicodados.ibge.gov.br/api/v3/noticias/?qtd=${qtd}&busca=${news[0]}`;
var futebol = document.getElementById("futebol");
var modal = document.getElementById("modal");
//TODO: FOR
busca = news[0];
const getFutebol = (URL_API_FUTEBOL, functionCallback) => {
    console.log(URL_API_FUTEBOL);
    fetch(URL_API_FUTEBOL)
        .then((response) => response.json())
        .then((data) => functionCallback(data));
};

const preencheFutebol = (data) => {
    console.log(data);
    for (var i = 3; i < 6; i++) {
        let img = JSON.parse(data["items"][i]["imagens"]);
        let newNoticeBody = `  
        <div>
            <br>
            <h1 id="conteudo-titulo" class="titulo${i}"> ${data["items"][i]["titulo"]}</h1>
            <br>
        </div>
        <div>
            <p> ${data["items"][i]["introducao"]}</p>
            <br>
        </div>
        <div> 
            <br>
            <img src="https://agenciadenoticias.ibge.gov.br/${img["image_fulltext"]}" alt="aa"> 
            <br>
        </div>
        <div>
            <h4>${data["items"][i]["data_publicacao"]}</h4>
            <a href="${data["items"][i]["link"]}"> acesse </a> 
            <br>     
        </div>
        <div>
            <br>
            <button onclick="comentar(${i})"> Comentar </button>
            <br> 
        </div>`;

        futebol.innerHTML += newNoticeBody;
    }

    futebol.innerHTML += `
    <br>
    <br>
    <center> 
        <button id="btnAbrirComentarios" onclick="abrirComentarios()"> Ver Comentários </button>
    </center>`;
};

function comentar(i) {
    limparCampos();
    let nomeTitulo = document.getElementsByClassName(`titulo${i}`);
    let tituloMateria = document.getElementById("tituloMateria");
    modal.style.display = "block";
    futebol.innerHTML += ``;
    tituloMateria.innerHTML = nomeTitulo[0].textContent;
    //fix me: retirar
    //console.log(nomeTitulo[0].textContent);
}



function abrirComentarios() {
    esconderComentarios();
    let btnComentarios = document.getElementById("btnAbrirComentarios");
    btnComentarios.style = "opacity: 0";
    let indice = parseInt(localStorage.getItem("contador")) - 1;
    if (!isNaN(indice)) {
        futebol.innerHTML += `
    <div class="exibe-comentario"> 
    <h1> Comentários (${indice})</h1>
    </div>`;
        for (let i = 1; i < indice + 1; i++) {
            let tituloNoticia = localStorage
                .getItem(`titulo${i}`)
                .replace('"', "")
                .toUpperCase()
                .replace('"', "");

            let autorComentario = localStorage
                .getItem(`pessoa${i}`)
                .replace('"', "")
                .toLowerCase()
                .replace('"', "");

            let comentario = localStorage
                .getItem(`texto${i}`)
                .replace('"', "")
                .toLowerCase()
                .replace('"', "");
            console.log(tituloNoticia);

            futebol.innerHTML += `
        <div id="btn-comentario" class="conteudo-comentarios"> 
            <br>
            <h2> ${tituloNoticia} </h1>
            <br>
            <h4> Autor: ${autorComentario}</h2>
            <br>
            <p> ${comentario}</p>
        </div> `;

        }

    } else {
        window.alert("Não há comentários para exibir, seja o primeiro.");
    }
}
function esconderComentarios() {
    let conteudo = document.getElementsByClassName("conteudos-comentarios");
    let labelComentario = document.getElementsByClassName("exibe-comentario");
    //conteudo.innerHTML = `teste`;
    console.log(conteudo);
    console.log(labelComentario);
    labelComentario.innerText = "";
}

function gravarComentario() {
    let contador = parseInt(localStorage.getItem("contador"));
    let nomePessoa = document.getElementById("nomePessoa");
    let txtComentario = document.getElementById("txtComentario");
    let tituloNoticia = document.getElementById("tituloMateria");
    //fix me: tá pegando o titulo errado .... 
    console.log(tituloNoticia);
    /* fix me: retirar
      console.log(tituloNoticia.innerText);
      console.log(nomePessoa.value);
      console.log(txtComentario.value);
      console.log(localStorage.getItem("contador"));
      
      if (contador == NaN){
          console.log("SOU Not a number");
      }
      */

    if (nomePessoa.value != "" && txtComentario.value != "") {
        if (
            localStorage.getItem("contador") == null ||
            localStorage.getItem("contador") == "undefined" ||
            isNaN(contador)
        ) {
            contador = 1;
        }
        localStorage.setItem("contador", JSON.stringify(contador));
        localStorage.setItem(`pessoa${contador}`, JSON.stringify(nomePessoa.value));
        localStorage.setItem(
            `titulo${contador}`,
            JSON.stringify(tituloNoticia.innerText)
        );
        localStorage.setItem(
            `texto${contador}`,
            JSON.stringify(txtComentario.value)
        );
        window.alert("Comentário Salvo com Sucesso!");
        modal.style.display = "none";
        localStorage.setItem("contador", JSON.stringify(contador + 1));
        limparCampos();
        window.location.reload(true);
    } else {
        window.alert("Favor preencher os campos");
    }
}

function limparCampos() {
    let nomePessoa = document.getElementById("nomePessoa");
    let txtComentario = document.getElementById("txtComentario");
    nomePessoa.value = "";
    txtComentario.value = "";
}

function zerarTudo() {
    localStorage.clear();
    window.location.reload(true);
}

//on load
function start() {
    getFutebol(URL_API_FUTEBOL, preencheFutebol);
}

window.addEventListener("load", start);



/* MODAL SCRIPT */
// Get the modal
var modal = document.getElementById("myModal");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
};

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
};
