using proyectoPokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoPokemon.Repositories
{
    public class PokemonRepository
    {
        public PokemonClass[] obtainAllPokemons()
        {
            DatabaseModel db = new DatabaseModel();
            PokemonClass[] pokemons = db.getAllPokemons();
            
            return pokemons;
        }
    }
}
