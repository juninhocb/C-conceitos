/*
 * LocalStorage
 */

const KEY_LISTA_PKMN = "LISTA_POKEMON";
const KEY_POKEMON_FAVORITO = 'POKEMON_FAVORITO';
const KEY_MEUS_POKEMONS = 'MEUS_POKEMONS';

const stg = {
    set: (key, value) => {
        localStorage.setItem(key, value);
    },

    get: (key) => {
        return localStorage.getItem(key);
    },

    setJson: (key, value) => {
        let obj = JSON.stringify(value);
        localStorage.setItem(key, obj);
    },

    getJson: (key) => {
        return JSON.parse(localStorage.getItem(key));
    },

    del: (key) => {
        localStorage.removeItem(key);
    },

    delAll: () => {
        localStorage.clear();
    },
};

/*
* Services APIs
*/

const getInfosApiPromise = (url) => {

}


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

