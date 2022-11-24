const URL_API_PKMN = "https://pokeapi.co/api/v2/pokemon/";

$(document).ready(() => {
  console.log("JQuery is loaded");
  init();
});

const init = () => {
  //Carregar Views
  getView("home", "#root");

  initializeServices();
  initializeEvents();

};

const initializeServices = () => {
  //Carregar/Armezenar Pokemons da API
  atualizarListaPKMNStorage();

  // Destaques
  getAPI(URL_API_PKMN, fillDestaques);
}

const initializeEvents = () => {

  //Meus pokemons
  $(`#pagMeusPokemons`).click(() => getView("meus_pokemons", "#root"));

  //Botao pesquisar
  $("#btn-pesquisa").click((e) => {
    e.preventDeafult(); //tira o comportamento padrão do botão de pesquisar
    let valorPesquisa = $("input-pesquisa").val();
  });
}


