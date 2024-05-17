using PokemonApplication.Interfaces;
using PokemonApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PokemonApplication.Services
{
    public class PokemonApiService: IPokemonApiService
    {
        private readonly HttpClient _httpClient;
        public PokemonApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.API_BASE_URL);

        }


        public PokemonApiResponse GetPokemonInformation(string pokemonName)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            {
                return null;
            }

            var response = _httpClient.GetAsync($"{pokemonName}").Result;
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<PokemonApiResponse>(content);
            }
            else
            {
                return null;
            }
        }

        public async Task<PokemonsListApiResponse> GetListOfPokemons()
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            {
                return null;
            }


            return  await _httpClient.GetFromJsonAsync<PokemonsListApiResponse>($"?limit=100&offset=0");

        }
    }
}
