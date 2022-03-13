using proyectoPokemon.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectoPokemon.Services
{
    public class PokemonService
    {
        public String[] getAllPokemons()
        {
            PokemonRepository allPokemons = new PokemonRepository();
            return new string[] { "pikachu", "https..." };
        }
    }
}
