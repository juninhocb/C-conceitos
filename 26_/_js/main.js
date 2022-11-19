const URL_API_PKMN = "https://pokeapi.co/api/v2/pokemon/";

$(document).ready(() => {
  console.log("JQuery is loaded");
  init();
});

const init = () => {
  //Carregar Views
  getView("home", "#root");

  //Meus pokemons
  $(`#pagMeusPokemons`).click(() => getView("meus_pokemons", "#root"));

  //Botao pesquisar
  $("#btn-pesquisa").click((e) => {
    e.preventDeafult(); //tira o comportamento padrão do botão de pesquisar
    let valorPesquisa = $("input-pesquisa").val();
  });

  //Carregar serviços
  // Destaques
  getAPI(URL_API_PKMN, fillDestaques);
};

const fillDestaques = (data) => {
  data.results.forEach((p, i) => {
    if (i > 3) return;
    let item = document.createElement("div");
    item.classList.add("col-4");
    $(item).html(`
            <div class="card">
                <div class="card-header bg-danger"> </div>
            </div>`);
    $("#destaque").append(item);
  });
};

const getView = (viewName, target) => {
  let ajaxConfig = {
    url: `_views/${viewName}.html`,
    dataType: `html`,
    success: (response) => {
      $(target).html(response);
      //html (parametro) sobrescreve o que está no target
      //html  sem nd, ele pega o que está dentro de target
    },
  };

  $.ajax(ajaxConfig);
};

const getAPI = (url, functionCallback) => {
  $.ajax({
    url: url,
    dataType: "json",
    success: (data) => functionCallback(data),
  });
};

/* OBJETO como os outros
const getAPI2 = (url, functionCallback) => {
    let ajaxConfig = {};
    ajaxConfig.url = url;
    ajaxConfig.dataType = 'json';
    ajaxConfig.success =  (data) => functionCallback(data);
}
*/
