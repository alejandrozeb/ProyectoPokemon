using Npgsql;
using System;
using System.Collections.Generic;

namespace proyectoPokemon.Models
{
    public class DatabaseModel
    {
        private static string Host = "177.222.49.52";
        private static string User = "alejandro";
        private static string DBname = "db_pokemon";
        private static string Password = "alejandro";
        private static string Port = "5432";

        public List<PokemonClass> findAllPokemons()
        {
            List<PokemonClass> resultPokemons = new List<PokemonClass>();
            string connectionDBString = this.buildConnectionString();

            using (var connection = new NpgsqlConnection(connectionDBString))
            {
                connection.Open();
                resultPokemons = this.getAllPokemonQuery(connection);
            }

            return resultPokemons;
        }

        public PokemonClass findSinglePokemon(string name) {
            PokemonClass pokemon = new PokemonClass();
            string connectionDBString = this.buildConnectionString();

            using (var connection = new NpgsqlConnection(connectionDBString))
            {
                connection.Open();
                pokemon = this.getSinglePokemonQuery(connection,name);
            }

            return pokemon;
        }

        private string buildConnectionString() {
            string connectionDBString = String.Format(
                "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                 Host,
                 User,
                 DBname,
                 Port,
                 Password
                 );

            return connectionDBString;
        }
        private List<PokemonClass>  getAllPokemonQuery(NpgsqlConnection connection) {
            List<PokemonClass> resultPokemons = new List<PokemonClass>();

            using (var command = new NpgsqlCommand("SELECT * FROM pokemon", connection))
            {
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PokemonClass pokemon = new PokemonClass();
                    pokemon.id = reader.GetInt32(0);
                    pokemon.name = reader.GetString(1);
                    pokemon.url = reader.GetString(2);

                    resultPokemons.Add(pokemon);
                }
                reader.Close();
            }

            return resultPokemons;
        }

        private PokemonClass getSinglePokemonQuery(NpgsqlConnection connection, string name) {
            PokemonClass pokemon = new PokemonClass();
            using (var command = new NpgsqlCommand($"SELECT id, name, url FROM pokemon WHERE name = '{name}'", connection))
            {
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pokemon.id = reader.GetInt32(0);
                    pokemon.name = reader.GetString(1);
                    pokemon.url = reader.GetString(2);   
                }
                reader.Close();
            }
            return pokemon;
        }
    }
}
