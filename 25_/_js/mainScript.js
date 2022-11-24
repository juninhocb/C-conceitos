//on load
function start() {
    setInterval(() => {
        nextImage();
    }, time);
}

window.addEventListener("load", start);

//slider
let time = 2000,
    currentImageIndex = 0,
    imagens = document.querySelectorAll("#slider img");
max = imagens.length;
function nextImage() {
    imagens[currentImageIndex].classList.remove("selected");
    if (currentImageIndex == max - 1) {
        currentImageIndex = 0;
    }
    currentImageIndex++;
    imagens[currentImageIndex].classList.add("selected");
}

function gravarNewslatter() {
    //usando session pra diversificar um pouco
    let txtInput = document.getElementById("txtNewsletter");
    let myAutoIncrement = parseInt(sessionStorage.getItem("ai"));
    console.log(myAutoIncrement);
    if (isNaN(myAutoIncrement))
        myAutoIncrement = 1;

    try {
        if (txtInput.value != null
            && txtInput.value != ""
            && !txtInput.value.includes(" ")
            && txtInput.value.includes("@")
            && txtInput.value.split("@")[1].includes(".com")
        ) {
            sessionStorage.setItem(`newsletter${myAutoIncrement}`, txtInput.value);
            window.alert("Email gravado com sucesso! (está gravado na sessão)");
            myAutoIncrement += 1;
            sessionStorage.setItem("ai", myAutoIncrement);
        }
        else {
            window.alert("Insira um email válido");
        }
    }
    catch (err) {
        window.alert("Insira um email válido");
        console.log("error: " + err);
    } finally {
        txtInput.value = "";
    }

}

function limparCampoInput() {
    let txtInput = document.getElementById("txtNewsletter");
    txtInput.value = "";
}


/* MODAL SCRIPT */
// Get the modal
var modal = document.getElementById("otherModal");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    console.log(modal);
    modal.style.display = "none";
};

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
};
