using proyectoPokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoPokemon.Repositories
{
    public class PokemonRepository
    {
        public List<PokemonClass> obtainAllPokemons()
        {
            DatabaseModel db = new DatabaseModel();
            List<PokemonClass> pokemons = db.findAllPokemons();
            
            return pokemons;
        }

        public PokemonClass obtainSinglePokemon(string name) {
            DatabaseModel db = new DatabaseModel();
            PokemonClass pokemon = db.findSinglePokemon(name);
            return pokemon;
        }
    }
}
