using proyectoPokemon.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectoPokemon.Models;

namespace proyectoPokemon.Services
{
    public class PokemonService
    {
        public List<PokemonClass> getAllPokemons()
        {
            PokemonRepository allPokemons = new PokemonRepository();
            List<PokemonClass> pokemons = allPokemons.obtainAllPokemons();

            return pokemons;
        }

        public PokemonClass getSinglePokemon(string name) {
            PokemonRepository allPokemons = new PokemonRepository();
            PokemonClass pokemon = allPokemons.obtainSinglePokemon();

            return pokemon;
        }
    }
}
