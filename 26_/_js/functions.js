/*
 * Function de Apoio
 */

var listaPokemons = new Array();

const fillDestaques = (data) => {
    data.results.forEach((p, i) => {
        if (i > 3) return;
        let item = `
            <div class="col-3">
              <div class="card">
                  <div class="card-header bg-danger"> 
                        <h3 class="text-white">${p.name}</h3>
                  </div>
              </div>
            </div>
            <div class="card-body">${p.url}</div>
            <div> </div>`;
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

const atualizarListaPKMNStorage =  (force = false) => {
    if (!verificarAtualizacaoLista() || !force){
        return;
    }
    listaPokemons = new Array();
    //percorre lista de pokemons na propriedade results
    getAPI(URL_API_PKMN, (data) => {
        data.results.forEach((p) => {
            getInfosApiPromise(p.url).then((objPokemon) => {
                let pkmn = {
                    id: 0,
                    name: p.name, 
                    url: p.url,
                    img: ''
                }
                
            listaPokemons.push(pkmn);
            
            //atualiza lista no storage
            stg.setJson(KEY_LISTA_PKMN, listaPokemons);
            });
            
        });
        
    });
}

const verificarAtualizacaoLista = () => {
    let listaPkmn = stg.getJson(KEY_LISTA_PKMN); 
    if (listaPkmn && listaPkmn.length < 0){
        return true; 
    }else {
        return false;
    }
}

const atualizarInfoPokemon = () => {
    if (listaPokemons == null || listaPokemons.length == 0)
        return; 
    
    listaPokemons.forEach((p) => {
        getAPI(`${p.url}`, (data)=> {
            p.id = data.id; 
            p.img = data.sprites.front_default;
        });
    });
}