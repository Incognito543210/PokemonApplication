using PokemonApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApplication.Interfaces
{
    public  interface IPokemonApiService
    {
        PokemonApiResponse GetPokemonInformation(string pokemonName);

         Task<PokemonsListApiResponse> GetListOfPokemons();
    }
}
