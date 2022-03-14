using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace proyectoPokemon.Models
{
    public class DatabaseModel
    {
        private static string Host = "177.222.49.52";
        private static string User = "alejandro";
        private static string DBname = "db_pokemon";
        private static string Password = "alejandro";
        private static string Port = "5432";

        public PokemonClass[] getAllPokemons()
        {
            string connString = String.Format(
                "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                 Host,
                 User,
                 DBname,
                 Port,
                 Password
                 );
            PokemonClass[] resultPokemons = new PokemonClass[] { };

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM pokemon", conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        PokemonClass pokemon = new PokemonClass();
                        pokemon.id = reader.GetInt32(0);
                        pokemon.name = reader.GetString(1);
                        pokemon.url = reader.GetString(2);
                        Console.Out.WriteLine(
                            pokemon.name + " " + pokemon.url + " " + pokemon.id
                            );
                        resultPokemons.Append(pokemon);
                    }
                    reader.Close();
                    //var reader = command.ExecuteReader();
                    Console.Out.WriteLine(reader);
                    Console.Out.WriteLine("cccccccccc");
                }
            }

            return resultPokemons;
        }
    }
}
