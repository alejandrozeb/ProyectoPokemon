using Microsoft.AspNetCore.Mvc;
using proyectoPokemon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace proyectoPokemon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        // GET: api/<PokemonController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            PokemonService allPokemons = new PokemonService();
            string[] pokemons = new string[] { "pikachu", "https..." };
            return pokemons;
        }

        // GET api/<PokemonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PokemonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PokemonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PokemonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
